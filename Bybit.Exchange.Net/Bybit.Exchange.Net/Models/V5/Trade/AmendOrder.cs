using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class AmendOrderRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// | Product type:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>Unified account</term>
        /// <description>
        /// linear, inverse, spot, option
        /// </description>
        /// </item>
        /// <item>
        /// <term>Classic account</term>
        /// <description>
        /// linear, inverse, spot
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        public Category? category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// Order ID. Either orderId or orderLinkId is required
        /// </para>
        /// </summary>
        public string orderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderLinkId</c></value>
        /// <para>
        /// User customised order ID. Either orderId or orderLinkId is required
        /// </para>
        /// </summary>
        public string orderLinkId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderIv</c></value>
        /// <remarks>
        /// <para>
        /// Implied volatility. option only. Pass the real value, e.g for 10%, 0.1 should be passed
        /// </para>
        /// </remarks>
        /// </summary>
        public string orderIv { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>triggerPrice</c></value>
        /// <remarks>
        /// <para>
        /// For Perps &amp; Futures, it is the conditional order trigger price. If you expect the price to rise to trigger your conditional order, make sure:
        /// triggerPrice > market price
        /// Else, triggerPrice &lt; market price
        /// For spot, it is the TP/SL and Conditional order trigger price
        /// </para>
        /// </remarks>
        /// </summary>
        public string triggerPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>qty</c></value>
        /// <para>
        /// Order quantity after modification. Do not pass it if not modify the qty
        /// </para>
        /// </summary>
        public string qty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>price</c></value>
        /// <para>
        /// Order price after modification. Do not pass it if not modify the price
        /// </para>
        /// </summary>
        public string price { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>tpslMode</c></value>
        /// <remarks>
        /// <para>
        /// TP/SL mode
        /// </para>
        /// <para>
        /// Full: entire position for TP/SL. Then, tpOrderType or slOrderType must be Market
        /// </para>
        /// <para>
        /// Partial: partial position tp/sl. Limit TP/SL order are supported. Note: When create limit tp/sl, tpslMode is required and it must be Partial
        /// </para>
        /// <para>
        /// Valid for linear &amp; inverse
        /// </para>
        /// </remarks>
        /// </summary>
        public TpSlMode? tpslMode { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>takeProfit</c></value>
        /// <para>
        /// Take profit price after modification. If pass "0", it means cancel the existing take profit of the order. Do not pass it if you do not want to modify the take profit. valid for spot(UTA), linear, inverse
        /// </para>
        /// </summary>
        public string takeProfit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>stopLoss</c></value>
        /// <para>
        /// Stop loss price after modification. If pass "0", it means cancel the existing stop loss of the order. Do not pass it if you do not want to modify the stop loss. valid for spot(UTA), linear, inverse
        /// </para>
        /// </summary>
        public string stopLoss { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>tpTriggerBy</c></value>
        /// <para>
        /// The price type to trigger take profit. When set a take profit, this param is required if no initial value for the order
        /// </para>
        /// </summary>
        public TriggerBy? tpTriggerBy { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>slTriggerBy</c></value>
        /// <para>
        /// The price type to trigger stop loss. When set a take profit, this param is required if no initial value for the order
        /// </para>
        /// </summary>
        public TriggerBy? slTriggerBy { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>triggerBy</c></value>
        /// <para>
        /// Trigger price type
        /// </para>
        /// </summary>
        public TriggerBy? triggerBy { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>tpLimitPrice</c></value>
        /// <para>
        /// Limit order price when take profit is triggered. Only working when original order sets partial limit tp/sl. valid for spot(UTA), linear, inverse
        /// </para>
        /// </summary>
        public string tpLimitPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>slLimitPrice</c></value>
        /// <para>
        /// Limit order price when stop loss is triggered. Only working when original order sets partial limit tp/sl. valid for spot(UTA), linear, inverse
        /// </para>
        /// </summary>
        public string slLimitPrice { get; set; } = default!;
    }

    public class AmendOrderResponse
    {
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