using Bybit.Exchange.Net.Models.V5.Trade;
using Bybit.Exchange.Net.Models.V5.WebSocket;
using Bybit.Exchange.Net.Models.V5.WebSocket.Private;
using Bybit.Exchange.Net.Models.V5.WebSocket.Public;
using Bybit.Exchange.Net.Models.V5.WebSocket.Trade;
using static Bybit.Exchange.Net.Data.Enums;

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
        Task ConnectPublicAsync(PublicChannelType channelType, CancellationToken ct = default);
        Task DisconnectAsync();

        // Authentication
        Task AuthenticateAsync();

        // Subscribe / Unsubscribe
        Task SubscribeAsync(params string[] topics);
        Task UnsubscribeAsync(params string[] topics);

        // Typed subscription helpers — Private stream
        void OnOrderUpdate(Action<BybitWebSocketMessage<OrderStreamData>> handler);
        void OnPositionUpdate(Action<BybitWebSocketMessage<PositionStreamData>> handler);
        void OnExecutionUpdate(Action<BybitWebSocketMessage<ExecutionStreamData>> handler);
        void OnWalletUpdate(Action<BybitWebSocketMessage<WalletStreamData>> handler);

        // Typed subscription helpers — Public stream
        void OnOrderbookUpdate(Action<PublicStreamMessage<OrderbookStreamData>> handler);
        void OnPublicTradeUpdate(Action<PublicStreamMessage<List<PublicTradeStreamData>>> handler);
        void OnTickerUpdate(Action<PublicStreamMessage<TickerStreamData>> handler);
        void OnKlineUpdate(Action<PublicStreamMessage<List<KlineStreamData>>> handler);
        void OnLiquidationUpdate(Action<PublicStreamMessage<List<LiquidationStreamData>>> handler);

        // Trade WebSocket operations — reusing existing REST request/response models
        Task<WsTradeResponse<PlaceOrderResponse>> CreateOrderAsync(PlaceOrderRequest request);
        Task<WsTradeResponse<AmendOrderResponse>> AmendOrderAsync(AmendOrderRequest request);
        Task<WsTradeResponse<CancelOrderResponse>> CancelOrderAsync(CancelOrderRequest request);
    }
}
