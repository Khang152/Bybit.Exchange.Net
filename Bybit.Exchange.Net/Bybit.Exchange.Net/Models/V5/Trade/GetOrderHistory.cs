using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class GetOrderHistoryRequest
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
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseCoin</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>Unified account</term>
        /// <description>inverse and Classic account does not support this param</description>
        /// </item>
        /// </list>
        /// </summary>
        public string baseCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>settleCoin</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>Unified account</term>
        /// <description>inverse and Classic account does not support this param</description>
        /// </item>
        /// </list>
        /// </summary>
        public string settleCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// Order ID
        /// </para>
        /// </summary>
        public string orderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderLinkId</c></value>
        /// <para>
        /// User customised order ID
        /// </para>
        /// </summary>
        public string orderLinkId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderFilter</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <para>
        /// Order: active order, StopOrder: conditional order for Futures and Spot, tpslOrder: spot TP/SL order, OcoOrder: Spot OCO orders, BidirectionalTpslOrder: Bidirectional TPSL order
        /// </para>
        /// <list type="bullet">
        /// <item>
        /// <term>Classic account spot</term>
        /// <description>return Order active order by default</description>
        /// </item>
        /// <item>
        /// <term>Others</term>
        /// <description>all kinds of orders by default</description>
        /// </item>
        /// </list>
        /// </summary>
        public string orderFilter { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderStatus</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>Classic spot</term>
        /// <description>not supported</description>
        /// </item>
        /// <item>
        /// <term>Others</term>
        /// <description>return all status orders if not passed</description>
        /// </item>
        /// </list>
        /// </summary>
        public OrderStatus? orderStatus { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>startTime</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>Classic spot trading does not support startTime and endTime</term>
        /// </item>
        /// <item>
        /// <term>startTime and endTime are not passed, return 7 days by default</term>
        /// </item>
        /// <item>
        /// <term>Only startTime is passed, return range between startTime and startTime +7 days</term>
        /// </item>
        /// <item>
        /// <term>Only endTime is passed, return range between endTime -7 days and endTime</term>
        /// </item>
        /// <item>
        /// <term>If both are passed, the rule is endTime - startTime &lt;= 7 days</term>
        /// </item>
        /// </list>
        /// </summary>
        public int? startTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>endTime</c></value>
        /// <para>
        /// The end timestamp (ms)
        /// </para>
        /// </summary>
        public int? endTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <para>
        /// Limit for data size per page. [1, 50]. Default: 20
        /// </para>
        /// </summary>
        public int? limit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>cursor</c></value>
        /// <para>
        /// Cursor. Use the nextPageCursor token from the response to retrieve the next page of the result set
        /// </para>
        /// </summary>
        public string cursor { get; set; } = default!;
    }

    public class GetOrderHistoryResponse
    {
        /// <summary>
        /// <value>Property <c>Category</c></value>
        /// <para>
        /// Product type
        /// </para>
        /// </summary>
        public Category? Category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>List</c></value>
        /// <para>
        /// The Array object
        /// </para>
        /// </summary>
        public OrderHistoryItem[] List { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>NextPageCursor</c></value>
        /// <para>
        /// Refer to the cursor request parameter
        /// </para>
        /// </summary>
        public string NextPageCursor { get; set; } = default!;
    }

    public class OrderHistoryItem
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
        /// User customized order ID
        /// </para>
        /// </summary>
        public string OrderLinkId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>BlockTradeId</c></value>
        /// <para>
        /// Block trade ID
        /// </para>
        /// </summary>
        public string BlockTradeId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>Symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>Price</c></value>
        /// <para>
        /// Order price
        /// </para>
        /// </summary>
        public string Price { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>Qty</c></value>
        /// <para>
        /// Order qty
        /// </para>
        /// </summary>
        public string Qty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>Side</c></value>
        /// <para>
        /// Side. Buy,Sell
        /// </para>
        /// </summary>
        public string Side { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>IsLeverage</c></value>
        /// <para>
        /// Whether to borrow. Unified spot only. 0: false, 1: true. . Classic spot is not supported, always 0
        /// </para>
        /// </summary>
        public string IsLeverage { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>PositionIdx</c></value>
        /// <para>
        /// Position index. Used to identify positions in different position modes
        /// </para>
        /// </summary>
        public PositionIdx? PositionIdx { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>OrderStatus</c></value>
        /// <para>
        /// Order status
        /// </para>
        /// </summary>
        public OrderStatus? OrderStatus { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>CreateType</c></value>
        /// <para>
        /// Order create type
        /// </para>
        /// </summary>
        public CreateType? CreateType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>CancelType</c></value>
        /// <para>
        /// Cancel type
        /// </para>
        /// </summary>
        public CancelType? CancelType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>RejectReason</c></value>
        /// <para>
        /// Reject reason. Classic spot is not supported
        /// </para>
        /// </summary>
        public RejectReason? RejectReason { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>AvgPrice</c></value>
        /// <para>
        /// Average filled price
        /// </para>
        /// </summary>
        public string AvgPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>LeavesQty</c></value>
        /// <para>
        /// The remaining qty not executed. Classic spot is not supported
        /// </para>
        /// </summary>
        public string LeavesQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>LeavesValue</c></value>
        /// <para>
        /// The estimated value not executed. Classic spot is not supported
        /// </para>
        /// </summary>
        public string LeavesValue { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>CumExecQty</c></value>
        /// <para>
        /// Cumulative executed order qty
        /// </para>
        /// </summary>
        public string CumExecQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>CumExecValue</c></value>
        /// <para>
        /// Cumulative executed order value. Classic spot is not supported
        /// </para>
        /// </summary>
        public string CumExecValue { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>CumExecFee</c></value>
        /// <para>
        /// Cumulative executed trading fee. Classic spot is not supported
        /// </para>
        /// </summary>
        public string CumExecFee { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>TimeInForce</c></value>
        /// <para>
        /// Time in force
        /// </para>
        /// </summary>
        public TimeInForce? TimeInForce { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>OrderType</c></value>
        /// <para>
        /// Order type. Market,Limit. For TP/SL order, it means the order type after triggered
        /// Block trade Roll Back, Block trade-Limit: Unique enum values for Unified account block trades
        /// </para>
        /// </summary>
        public OrderType? OrderType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>StopOrderType</c></value>
        /// <para>
        /// Stop order type
        /// </para>
        /// </summary>
        public StopOrderType? StopOrderType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>OrderIv</c></value>
        /// <para>
        /// Implied volatility
        /// </para>
        /// </summary>
        public string OrderIv { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>MarketUnit</c></value>
        /// <para>
        /// The unit for qty when create Spot market orders for UTA account. baseCoin, quoteCoin
        /// </para>
        /// </summary>
        public string MarketUnit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>TriggerPrice</c></value>
        /// <para>
        /// Trigger price. If stopOrderType=TrailingStop, it is activate price. Otherwise, it is trigger price
        /// </para>
        /// </summary>
        public string TriggerPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>TakeProfit</c></value>
        /// <para>
        /// Take profit price
        /// </para>
        /// </summary>
        public string TakeProfit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>StopLoss</c></value>
        /// <para>
        /// Stop loss price
        /// </para>
        /// </summary>
        public string StopLoss { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>TpslMode</c></value>
        /// <para>
        /// TP/SL mode, Full: entire position for TP/SL. Partial: partial position tp/sl. Spot does not have this field, and Option returns always ""
        /// </para>
        /// </summary>
        public string TpslMode { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>OcoTriggerType</c></value>
        /// <para>
        /// The trigger type of Spot OCO order.OcoTriggerByUnknown, OcoTriggerTp, OcoTriggerBySl. Classic spot is not supported
        /// </para>
        /// </summary>
        public string OcoTriggerType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>TpLimitPrice</c></value>
        /// <para>
        /// The limit order price when take profit price is triggered
        /// </para>
        /// </summary>
        public string TpLimitPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>SlLimitPrice</c></value>
        /// <para>
        /// The limit order price when stop loss price is triggered
        /// </para>
        /// </summary>
        public string SlLimitPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>TpTriggerBy</c></value>
        /// <para>
        /// The price type to trigger take profit
        /// </para>
        /// </summary>
        public TriggerBy? TpTriggerBy { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>SlTriggerBy</c></value>
        /// <para>
        /// The price type to trigger stop loss
        /// </para>
        /// </summary>
        public TriggerBy? SlTriggerBy { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>TriggerDirection</c></value>
        /// <para>
        /// Trigger direction. 1: rise, 2: fall
        /// </para>
        /// </summary>
        public TriggerDirection? TriggerDirection { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>TriggerBy</c></value>
        /// <para>
        /// The price type of trigger price
        /// </para>
        /// </summary>
        public TriggerBy? TriggerBy { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>LastPriceOnCreated</c></value>
        /// <para>
        /// Last price when place the order
        /// </para>
        /// </summary>
        public string LastPriceOnCreated { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ReduceOnly</c></value>
        /// <para>
        /// Reduce only. true means reduce position size
        /// </para>
        /// </summary>
        public bool? ReduceOnly { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>CloseOnTrigger</c></value>
        /// <para>
        /// Close on trigger. What is a close on trigger order?
        /// </para>
        /// </summary>
        public bool? CloseOnTrigger { get; set; }

        /// <summary>
        /// <value>Property <c>PlaceType</c></value>
        /// <para>
        /// Place type, option used. iv, price
        /// </para>
        /// </summary>
        public string PlaceType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>SmpType</c></value>
        /// <para>
        /// SMP execution type
        /// </para>
        /// </summary>
        public SmpType? SmpType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>SmpGroup</c></value>
        /// <para>
        /// Smp group ID. If the UID has no group, it is 0 by default
        /// </para>
        /// </summary>
        public int SmpGroup { get; set; }

        /// <summary>
        /// <value>Property <c>SmpOrderId</c></value>
        /// <para>
        /// The counterparty's orderID which triggers this SMP execution
        /// </para>
        /// </summary>
        public string SmpOrderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>CreatedTime</c></value>
        /// <para>
        /// Order created timestamp (ms)
        /// </para>
        /// </summary>
        public string CreatedTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>UpdatedTime</c></value>
        /// <para>
        /// Order updated timestamp (ms)
        /// </para>
        /// </summary>
        public string UpdatedTime { get; set; } = default!;
    }
}