using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class BatchPlaceOrderRequest
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
        public List<PlaceOrderRequest>? request { get; set; } = default!;
    }

    public class BatchPlaceOrderResponse
    {
        /// <summary>
        /// <value>Property <c>List</c></value>
        /// <para>
        /// The Array Object
        /// </para>
        /// </summary>
        public PlaceOrderResponse[]? List { get; set; } = default!;
    }
}