using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class BatchAmendOrderRequest
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
        public List<AmendOrderRequest>? request { get; set; } = default!;
    }

    public class BatchAmendOrderResponse
    {
        /// <summary>
        /// <value>Property <c>List</c></value>
        /// <para>
        /// The Array Object
        /// </para>
        /// </summary>
        public List<BatchAmendOrderItem>? List { get; set; } = default!;
    }

    public class BatchAmendOrderItem
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