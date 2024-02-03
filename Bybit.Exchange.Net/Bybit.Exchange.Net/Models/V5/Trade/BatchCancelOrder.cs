using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class BatchCancelOrderRequest
    {
        /// <summary>
        /// <value>Property <c>Category</c></value>
        /// <para>
        /// Product type: linear, option | Covers: Option (UTA, UTA Pro) / USDT Perpetual, UDSC Perpetual, USDC Futures (UTA Pro)
        /// </para>
        /// </summary>
        public Category? category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>Request</c></value>
        /// <para>
        /// The Array Request
        /// </para>
        /// </summary>
        public List<CancelOrderRequest>? request { get; set; } = default!;
    }

    public class BatchCancelOrderResponse
    {
        /// <summary>
        /// <value>Property <c>List</c></value>
        /// <para>
        /// The Array Object
        /// </para>
        /// </summary>
        public List<BatchCancelOrderItem>? List { get; set; } = default!;
    }

    public class BatchCancelOrderItem
    {
        /// <summary>
        /// <value>Property <c>Category</c></value>
        /// <para>
        /// Product type: linear, option | Covers: Option (UTA, UTA Pro) / USDT Perpetual, UDSC Perpetual, USDC Futures (UTA Pro)
        /// </para>
        /// </summary>
        public Category? Category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// Order ID
        /// </para>
        /// </summary>
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderLinkId</c></value>
        /// <para>
        /// User customised order ID
        /// </para>
        /// </summary>
        public string OrderLinkId { get; set; } = default!;
    }
}