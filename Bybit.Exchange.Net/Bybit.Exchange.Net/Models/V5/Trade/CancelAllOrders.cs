using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class CancelAllOrdersRequest
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
        /// spot, linear, inverse, option
        /// </description>
        /// </item>
        /// <item>
        /// <term>Classic account</term>
        /// <description>
        /// spot, linear, inverse
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        public Category? category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <remarks>
        /// <para>
        /// Symbol name. linear &amp; inverse: Required if not passing baseCoin or settleCoin
        /// </para>
        /// <para>
        /// baseCoin false string Base coin
        /// </para>
        /// <para>
        /// linear &amp; inverse(Classic account): If cancel all by baseCoin, it will cancel all linear &amp; inverse orders. Required if not passing symbol or settleCoin
        /// </para>
        /// <para>
        /// linear &amp; inverse(Unified account): If cancel all by baseCoin, it will cancel all corresponding category orders. Required if not passing symbol or settleCoin
        /// </para>
        /// <para>
        /// Classic spot: invalid
        /// </para>
        /// </remarks>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseCoin</c></value>
        /// <remarks>
        /// <para>
        /// Base coin
        /// </para>
        /// <para>
        /// linear &amp; inverse(Classic account): If cancel all by baseCoin, it will cancel all linear &amp; inverse orders. Required if not passing symbol or settleCoin
        /// </para>
        /// <para>
        /// linear &amp; inverse(Unified account): If cancel all by baseCoin, it will cancel all corresponding category orders. Required if not passing symbol or settleCoin
        /// </para>
        /// </remarks>
        /// </summary>
        public string baseCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>settleCoin</c></value>
        /// <remarks>
        /// <para>
        /// Settle coin
        /// </para>
        /// <para>
        /// linear &amp; inverse: Required if not passing symbol or baseCoin
        /// </para>
        /// <para>
        /// Does not support spot
        /// </para>
        /// </remarks>
        /// </summary>
        public string settleCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderFilter</c></value>
        /// <remarks>
        /// <para>
        /// category=spot, you can pass Order, tpslOrder, StopOrder, OcoOrder, BidirectionalTpslOrder. If not passed, Order by default
        /// </para>
        /// <para>
        /// category=linear or inverse, you can pass Order, StopOrder. If not passed, all kinds of orders will be cancelled, like active order, conditional order, TP/SL order and trailing stop order
        /// </para>
        /// <para>
        /// category=option, you can pass Order. No matter it is passed or not, always cancel all orders
        /// </para>
        /// </remarks>
        /// </summary>
        public string orderFilter { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>stopOrderType</c></value>
        /// <remarks>
        /// <para>
        /// Stop order type Stop
        /// </para>
        /// <para>
        /// Only used for category=linear or inverse and orderFilter=StopOrder,you can cancel conditional orders except TP/SL order and Trailing stop orders with this param
        /// </para>
        /// </remarks>
        /// </summary>
        public StopOrderType? stopOrderType { get; set; } = default!;
    }

    public class CancelAllOrdersResponse
    {
        /// <summary>
        /// <value>Property <c>success</c></value>
        /// <para>
        /// 1: success, 0: fail
        /// </para>
        /// </summary>
        public string Success { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// Array of <see cref="CancelAllOrdersItem"/> objects
        /// </para>
        /// </summary>
        public List<CancelAllOrdersItem> List { get; set; } = new List<CancelAllOrdersItem>();
    }

    public class CancelAllOrdersItem
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