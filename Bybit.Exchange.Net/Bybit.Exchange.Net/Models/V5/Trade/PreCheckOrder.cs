using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    /// <summary>
    /// Pre Check Order request. Uses the same parameters as Place Order.
    /// Refer to <see cref="PlaceOrderRequest"/> for the request body.
    /// <para>
    /// This endpoint is used to calculate the changes in IMR and MMR of UTA account before and after placing an order.
    /// </para>
    /// <list type="bullet">
    /// <item><description>Supports orders with category = inverse, linear, option</description></item>
    /// <item><description>Only Cross Margin mode and Portfolio Margin mode are supported</description></item>
    /// <item><description>category = inverse is not supported in Cross Margin mode</description></item>
    /// <item><description>Conditional order is not supported</description></item>
    /// </list>
    /// </summary>
    public class PreCheckOrderRequest : PlaceOrderRequest
    {
    }

    public class PreCheckOrderResponse
    {
        /// <summary>
        /// <value>Property <c>OrderId</c></value>
        /// <para>
        /// Order ID
        /// </para>
        /// </summary>
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>OrderLinkId</c></value>
        /// <para>
        /// User customised order ID
        /// </para>
        /// </summary>
        public string OrderLinkId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>PreImrE4</c></value>
        /// <para>
        /// Pre-order initial margin rate, scaled by 1e4. e.g., 30 means 0.003
        /// </para>
        /// </summary>
        public long? PreImrE4 { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>PreMmrE4</c></value>
        /// <para>
        /// Pre-order maintenance margin rate, scaled by 1e4. e.g., 21 means 0.0021
        /// </para>
        /// </summary>
        public long? PreMmrE4 { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>PostImrE4</c></value>
        /// <para>
        /// Post-order initial margin rate, scaled by 1e4. e.g., 357 means 0.0357
        /// </para>
        /// </summary>
        public long? PostImrE4 { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>PostMmrE4</c></value>
        /// <para>
        /// Post-order maintenance margin rate, scaled by 1e4. e.g., 294 means 0.0294
        /// </para>
        /// </summary>
        public long? PostMmrE4 { get; set; } = default!;
    }
}
