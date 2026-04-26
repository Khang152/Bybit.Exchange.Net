using Bybit.Exchange.Net.Extensions;
using Bybit.Exchange.Net.Library.Interface;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Trade;
using Bybit.Exchange.Net.Models.V5.WebSocket;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Text;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Library
{
    public class BybitWebSocketClient : IBybitWebSocketClient
    {
        private readonly BybitWebSocketOptions _options;
        private ClientWebSocket _webSocket = default!;
        private CancellationTokenSource _cts = default!;
        private Timer _pingTimer = default!;
        private bool _disposed;
        private int _reconnectAttempts;
        private string _currentUrl = default!;

        // Typed handlers
        private readonly List<Action<BybitWebSocketMessage<OrderStreamData>>> _orderHandlers = new();
        private readonly List<Action<BybitWebSocketMessage<PositionStreamData>>> _positionHandlers = new();
        private readonly List<Action<BybitWebSocketMessage<ExecutionStreamData>>> _executionHandlers = new();
        private readonly List<Action<BybitWebSocketMessage<WalletStreamData>>> _walletHandlers = new();

        // Trade WS pending requests — stores raw JSON strings for typed deserialization
        private readonly ConcurrentDictionary<string, TaskCompletionSource<string>> _pendingTradeRequests = new();

        // Events
        public event Action<string> OnRawMessage = default!;
        public event Action<BybitWebSocketResponse> OnOperationResponse = default!;
        public event Action<Exception> OnError = default!;
        public event Action OnConnected = default!;
        public event Action OnDisconnected = default!;
        public event Action OnReconnecting = default!;

        public BybitWebSocketClient(BybitWebSocketOptions options)
        {
            _options = options ?? new BybitWebSocketOptions();
        }

        #region Connection

        public async Task ConnectPrivateAsync(CancellationToken ct = default)
        {
            _currentUrl = GetPrivateUrl();
            await ConnectInternalAsync(_currentUrl, ct);
        }

        public async Task ConnectTradeAsync(CancellationToken ct = default)
        {
            _currentUrl = GetTradeUrl();

            if (string.IsNullOrEmpty(_currentUrl))
                throw new NotSupportedException("Trade WebSocket is not supported for Demo environment.");

            await ConnectInternalAsync(_currentUrl, ct);
        }

        private async Task ConnectInternalAsync(string url, CancellationToken ct)
        {
            _cts = CancellationTokenSource.CreateLinkedTokenSource(ct);
            _webSocket = new ClientWebSocket();

            await _webSocket.ConnectAsync(new Uri(url), _cts.Token);
            _reconnectAttempts = 0;

            OnConnected?.Invoke();

            // Start ping timer
            _pingTimer = new Timer(
                async _ => await SendPingAsync(),
                null,
                TimeSpan.FromSeconds(_options.PingIntervalSeconds),
                TimeSpan.FromSeconds(_options.PingIntervalSeconds));

            // Start receive loop
            _ = Task.Run(() => ReceiveLoopAsync(_cts.Token), _cts.Token);
        }

        public async Task DisconnectAsync()
        {
            _pingTimer?.Dispose();
            _cts?.Cancel();

            if (_webSocket?.State == WebSocketState.Open)
            {
                try
                {
                    await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Client disconnect", CancellationToken.None);
                }
                catch { }
            }

            OnDisconnected?.Invoke();
        }

        #endregion

        #region Authentication

        public async Task AuthenticateAsync()
        {
            if (_options.Credentials == null)
                throw new InvalidOperationException("Credentials are required for authentication.");

            long expires = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + 10000;
            string signature = GenerateWebSocketSignature(expires);

            var authMsg = new
            {
                op = "auth",
                args = new object[] { _options.Credentials.Key, expires, signature }
            };

            await SendAsync(authMsg);
        }

        private string GenerateWebSocketSignature(long expires)
        {
            string signPayload = $"GET/realtime{expires}";
            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(_options.Credentials.Secret));
            byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(signPayload));
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        #endregion

        #region Subscribe / Unsubscribe

        public async Task SubscribeAsync(params string[] topics)
        {
            var subMsg = new { op = "subscribe", args = topics };
            await SendAsync(subMsg);
        }

        public async Task UnsubscribeAsync(params string[] topics)
        {
            var unsubMsg = new { op = "unsubscribe", args = topics };
            await SendAsync(unsubMsg);
        }

        #endregion

        #region Typed Handlers

        public void OnOrderUpdate(Action<BybitWebSocketMessage<OrderStreamData>> handler)
        {
            _orderHandlers.Add(handler);
        }

        public void OnPositionUpdate(Action<BybitWebSocketMessage<PositionStreamData>> handler)
        {
            _positionHandlers.Add(handler);
        }

        public void OnExecutionUpdate(Action<BybitWebSocketMessage<ExecutionStreamData>> handler)
        {
            _executionHandlers.Add(handler);
        }

        public void OnWalletUpdate(Action<BybitWebSocketMessage<WalletStreamData>> handler)
        {
            _walletHandlers.Add(handler);
        }

        #endregion

        #region Trade WebSocket Operations

        public async Task<WsTradeResponse<PlaceOrderResponse>> CreateOrderAsync(PlaceOrderRequest request)
        {
            return await SendTradeRequestAsync<PlaceOrderResponse>("order.create", request);
        }

        public async Task<WsTradeResponse<AmendOrderResponse>> AmendOrderAsync(AmendOrderRequest request)
        {
            return await SendTradeRequestAsync<AmendOrderResponse>("order.amend", request);
        }

        public async Task<WsTradeResponse<CancelOrderResponse>> CancelOrderAsync(CancelOrderRequest request)
        {
            return await SendTradeRequestAsync<CancelOrderResponse>("order.cancel", request);
        }

        private async Task<WsTradeResponse<T>> SendTradeRequestAsync<T>(string op, object requestData)
        {
            string reqId = Guid.NewGuid().ToString("N");
            var tcs = new TaskCompletionSource<string>();
            _pendingTradeRequests[reqId] = tcs;

            string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();

            var request = new WsTradeRequest
            {
                ReqId = reqId,
                Op = op,
                Header = new WsTradeHeader
                {
                    Timestamp = timestamp,
                    RecvWindow = "5000"
                },
                Args = new List<object> { requestData }
            };

            await SendAsync(request);

            // Wait for response with timeout
            using var timeoutCts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            timeoutCts.Token.Register(() => tcs.TrySetCanceled());

            try
            {
                var rawJson = await tcs.Task;
                return JsonConvert.DeserializeObject<WsTradeResponse<T>>(rawJson, JsonExtension.JsonSettings())!;
            }
            finally
            {
                _pendingTradeRequests.TryRemove(reqId, out _);
            }
        }

        #endregion

        #region Send / Receive

        private async Task SendAsync(object message)
        {
            if (_webSocket?.State != WebSocketState.Open)
                throw new InvalidOperationException("WebSocket is not connected.");

            var json = JsonConvert.SerializeObject(message, JsonExtension.JsonSettings());
            var bytes = Encoding.UTF8.GetBytes(json);
            var segment = new ArraySegment<byte>(bytes);

            await _webSocket.SendAsync(segment, WebSocketMessageType.Text, true, _cts.Token);
        }

        private async Task SendPingAsync()
        {
            try
            {
                if (_webSocket?.State == WebSocketState.Open)
                {
                    await SendAsync(new { op = "ping" });
                }
            }
            catch (Exception ex)
            {
                OnError?.Invoke(ex);
            }
        }

        private async Task ReceiveLoopAsync(CancellationToken ct)
        {
            var buffer = new byte[8192];

            try
            {
                while (!ct.IsCancellationRequested && _webSocket?.State == WebSocketState.Open)
                {
                    using var ms = new MemoryStream();
                    WebSocketReceiveResult result;

                    do
                    {
                        result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), ct);
                        ms.Write(buffer, 0, result.Count);
                    }
                    while (!result.EndOfMessage);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        OnDisconnected?.Invoke();
                        break;
                    }

                    var message = Encoding.UTF8.GetString(ms.ToArray());
                    ProcessMessage(message);
                }
            }
            catch (OperationCanceledException) { }
            catch (WebSocketException ex)
            {
                OnError?.Invoke(ex);
            }
            finally
            {
                if (!ct.IsCancellationRequested && _options.AutoReconnect)
                {
                    await TryReconnectAsync();
                }
            }
        }

        private void ProcessMessage(string message)
        {
            OnRawMessage?.Invoke(message);

            try
            {
                var json = JObject.Parse(message);

                // Check if it's a Trade WS response (has reqId + retCode)
                if (json.ContainsKey("reqId") && json.ContainsKey("retCode"))
                {
                    var reqId = json["reqId"]?.ToString();
                    if (reqId != null && _pendingTradeRequests.TryRemove(reqId, out var tcs))
                    {
                        tcs.TrySetResult(message);
                    }
                    return;
                }

                // Check if it's an op response (auth, subscribe, pong)
                if (json.ContainsKey("op"))
                {
                    var opResponse = JsonConvert.DeserializeObject<BybitWebSocketResponse>(message, JsonExtension.JsonSettings());
                    if (opResponse != null)
                    {
                        OnOperationResponse?.Invoke(opResponse);
                    }
                    return;
                }

                // Check if it's a topic push message
                if (json.ContainsKey("topic"))
                {
                    var topic = json["topic"]?.ToString() ?? string.Empty;
                    DispatchTopicMessage(topic, message);
                }
            }
            catch (Exception ex)
            {
                OnError?.Invoke(ex);
            }
        }

        private void DispatchTopicMessage(string topic, string message)
        {
            var settings = JsonExtension.JsonSettings();

            if (topic.StartsWith("order"))
            {
                var msg = JsonConvert.DeserializeObject<BybitWebSocketMessage<OrderStreamData>>(message, settings);
                if (msg != null)
                {
                    foreach (var handler in _orderHandlers)
                    {
                        try { handler(msg); } catch (Exception ex) { OnError?.Invoke(ex); }
                    }
                }
            }
            else if (topic.StartsWith("position"))
            {
                var msg = JsonConvert.DeserializeObject<BybitWebSocketMessage<PositionStreamData>>(message, settings);
                if (msg != null)
                {
                    foreach (var handler in _positionHandlers)
                    {
                        try { handler(msg); } catch (Exception ex) { OnError?.Invoke(ex); }
                    }
                }
            }
            else if (topic.StartsWith("execution"))
            {
                var msg = JsonConvert.DeserializeObject<BybitWebSocketMessage<ExecutionStreamData>>(message, settings);
                if (msg != null)
                {
                    foreach (var handler in _executionHandlers)
                    {
                        try { handler(msg); } catch (Exception ex) { OnError?.Invoke(ex); }
                    }
                }
            }
            else if (topic.StartsWith("wallet"))
            {
                var msg = JsonConvert.DeserializeObject<BybitWebSocketMessage<WalletStreamData>>(message, settings);
                if (msg != null)
                {
                    foreach (var handler in _walletHandlers)
                    {
                        try { handler(msg); } catch (Exception ex) { OnError?.Invoke(ex); }
                    }
                }
            }
        }

        #endregion

        #region Reconnect

        private async Task TryReconnectAsync()
        {
            while (_reconnectAttempts < _options.MaxReconnectAttempts && !_disposed)
            {
                _reconnectAttempts++;
                OnReconnecting?.Invoke();

                try
                {
                    await Task.Delay(_options.ReconnectDelayMs);

                    _webSocket?.Dispose();
                    _webSocket = new ClientWebSocket();

                    await _webSocket.ConnectAsync(new Uri(_currentUrl), CancellationToken.None);
                    _reconnectAttempts = 0;

                    OnConnected?.Invoke();

                    // Re-authenticate after reconnect
                    if (_options.Credentials != null)
                    {
                        await AuthenticateAsync();
                    }

                    // Restart ping timer
                    _pingTimer?.Dispose();
                    _pingTimer = new Timer(
                        async _ => await SendPingAsync(),
                        null,
                        TimeSpan.FromSeconds(_options.PingIntervalSeconds),
                        TimeSpan.FromSeconds(_options.PingIntervalSeconds));

                    // Restart receive loop
                    _cts = new CancellationTokenSource();
                    _ = Task.Run(() => ReceiveLoopAsync(_cts.Token), _cts.Token);

                    return;
                }
                catch (Exception ex)
                {
                    OnError?.Invoke(ex);
                }
            }

            OnDisconnected?.Invoke();
        }

        #endregion

        #region URL Helpers

        private string GetPrivateUrl()
        {
            return _options.Environment switch
            {
                BybitEnvironment.Live => BybitBaseDomain.WsMainnetPrivate,
                BybitEnvironment.Testnet => BybitBaseDomain.WsTestnetPrivate,
                BybitEnvironment.Demo => BybitBaseDomain.WsDemoPrivate,
                _ => BybitBaseDomain.WsMainnetPrivate
            };
        }

        private string GetTradeUrl()
        {
            return _options.Environment switch
            {
                BybitEnvironment.Live => BybitBaseDomain.WsMainnetTrade,
                BybitEnvironment.Testnet => BybitBaseDomain.WsTestnetTrade,
                BybitEnvironment.Demo => string.Empty, // Trade WS not supported on Demo
                _ => BybitBaseDomain.WsMainnetTrade
            };
        }

        #endregion

        #region Dispose

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;

            _pingTimer?.Dispose();
            _cts?.Cancel();
            _cts?.Dispose();
            _webSocket?.Dispose();

            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
