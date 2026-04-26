using Bybit.Exchange.Net.Models.V5.Trade;
using Bybit.Exchange.Net.Models.V5.WebSocket;

namespace Bybit.Exchange.Net.Library.Interface
{
    public interface IBybitWebSocketClient : IDisposable
    {
        // Events
        event Action<string> OnRawMessage;
        event Action<BybitWebSocketResponse> OnOperationResponse;
        event Action<Exception> OnError;
        event Action OnConnected;
        event Action OnDisconnected;
        event Action OnReconnecting;

        // Connection
        Task ConnectPrivateAsync(CancellationToken ct = default);
        Task ConnectTradeAsync(CancellationToken ct = default);
        Task DisconnectAsync();

        // Authentication
        Task AuthenticateAsync();

        // Subscribe / Unsubscribe (private stream)
        Task SubscribeAsync(params string[] topics);
        Task UnsubscribeAsync(params string[] topics);

        // Typed subscription helpers (private stream)
        void OnOrderUpdate(Action<BybitWebSocketMessage<OrderStreamData>> handler);
        void OnPositionUpdate(Action<BybitWebSocketMessage<PositionStreamData>> handler);
        void OnExecutionUpdate(Action<BybitWebSocketMessage<ExecutionStreamData>> handler);
        void OnWalletUpdate(Action<BybitWebSocketMessage<WalletStreamData>> handler);

        // Trade WebSocket operations — reusing existing REST request/response models
        Task<WsTradeResponse<PlaceOrderResponse>> CreateOrderAsync(PlaceOrderRequest request);
        Task<WsTradeResponse<AmendOrderResponse>> AmendOrderAsync(AmendOrderRequest request);
        Task<WsTradeResponse<CancelOrderResponse>> CancelOrderAsync(CancelOrderRequest request);
    }
}
