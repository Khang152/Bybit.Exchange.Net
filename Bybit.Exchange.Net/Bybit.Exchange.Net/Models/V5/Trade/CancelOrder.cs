using Bybit.Exchange.Net.Models.V5.Market;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class CancelOrderRequest
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
        public Category category { get; set; } = default!;

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
        /// <value>Property <c>orderFilter</c></value>
        /// <remarks>
        /// | Valid for spot only.
        /// </remarks>
        /// <para>
        /// Order, tpslOrder, StopOrder. If not passed, Order by default
        /// </para>
        /// </summary>
        public string orderFilter { get; set; } = default!;
    }

    public class CancelOrderResponse
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