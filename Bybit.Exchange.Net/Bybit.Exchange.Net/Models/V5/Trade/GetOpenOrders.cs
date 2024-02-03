using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class GetOpenOrdersRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <para>
        /// Product type
        /// </para>
        /// <remarks>
        /// | Comments:
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
        /// Symbol name. For linear, either symbol, baseCoin, settleCoin is required
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseCoin</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <para>
        /// Base coin
        /// </para>
        /// <list type="bullet">
        /// <item>
        /// <term>Supports linear, inverse &amp; option</term>
        /// </item>
        /// <item>
        /// <term>option: it returns all option open orders by default</term>
        /// </item>
        /// </list>
        /// </summary>
        public string baseCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>settleCoin</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <para>
        /// Settle coin
        /// </para>
        /// <list type="bullet">
        /// <item>
        /// <term>linear: either symbol, baseCoin or settleCoin is required</term>
        /// </item>
        /// <item>
        /// <term>spot: not supported</term>
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
        /// <value>Property <c>openOnly</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>Unified account &amp; Classic account: 0 (default) - query open orders only</term>
        /// </item>
        /// <item>
        /// <term>Unified account - spot / linear / option: 1</term>
        /// </item>
        /// <item>
        /// <term>Unified account - inverse &amp; Classic account - linear / inverse: 2</term>
        /// <description>
        /// return cancelled, rejected or totally filled orders, a maximum of 500 records are kept under each account.
        /// If the Bybit service is restarted due to an update, this part of the data will be cleared and accumulated again,
        /// but the order records will still be queried in order history
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        public int? openOnly { get; set; } = default!;

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
        /// <value>Property <c>limit</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
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

    public class GetOpenOrdersResponse
    {
        /// <summary>
        /// Product type
        /// </summary>
        public Category? Category { get; set; } = default!;

        /// <summary>
        /// Refer to the cursor request parameter
        /// </summary>
        public string NextPageCursor { get; set; } = default!;

        /// <summary>
        /// List of open orders
        /// </summary>
        public List<OpenOrderItem> List { get; set; } = default!;
    }

    public class OpenOrderItem
    {
        /// <summary>
        /// Order ID
        /// </summary>
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// User customised order ID
        /// </summary>
        public string OrderLinkId { get; set; } = default!;

        /// <summary>
        /// Paradigm block trade ID
        /// </summary>
        public string BlockTradeId { get; set; } = default!;

        /// <summary>
        /// Symbol name
        /// </summary>
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// Order price
        /// </summary>
        public string Price { get; set; } = default!;

        /// <summary>
        /// Order quantity
        /// </summary>
        public string Qty { get; set; } = default!;

        /// <summary>
        /// Side (Buy, Sell)
        /// </summary>
        public string Side { get; set; } = default!;

        /// <summary>
        /// Whether to borrow. Unified spot only. 0: false, 1: true. Classic spot is not supported, always 0
        /// </summary>
        public string IsLeverage { get; set; } = default!;

        /// <summary>
        /// Position index. Used to identify positions in different position modes.
        /// </summary>
        public PositionIdx? PositionIdx { get; set; }

        /// <summary>
        /// Order status
        /// </summary>
        public OrderStatus? OrderStatus { get; set; } = default!;

        /// <summary>
        /// Order create type. Only for category=linear or inverse. Spot, Option do not have this key.
        /// </summary>
        public CreateType? CreateType { get; set; } = default!;

        /// <summary>
        /// Cancel type
        /// </summary>
        public CancelType? CancelType { get; set; } = default!;

        /// <summary>
        /// Reject reason. Classic spot is not supported
        /// </summary>
        public RejectReason? RejectReason { get; set; } = default!;

        /// <summary>
        /// Average filled price. UTA: returns "" for those orders without avg price. Classic account: returns "0" for those orders without avg price.
        /// </summary>
        public string AvgPrice { get; set; } = default!;

        /// <summary>
        /// The remaining qty not executed. Classic spot is not supported
        /// </summary>
        public string LeavesQty { get; set; } = default!;

        /// <summary>
        /// The estimated value not executed. Classic spot is not supported
        /// </summary>
        public string LeavesValue { get; set; } = default!;

        /// <summary>
        /// Cumulative executed order qty
        /// </summary>
        public string CumExecQty { get; set; } = default!;

        /// <summary>
        /// Cumulative executed order value. Classic spot is not supported
        /// </summary>
        public string CumExecValue { get; set; } = default!;

        /// <summary>
        /// Cumulative executed trading fee. Classic spot is not supported
        /// </summary>
        public string CumExecFee { get; set; } = default!;

        /// <summary>
        /// Time in force
        /// </summary>
        public TimeInForce? TimeInForce { get; set; } = default!;

        /// <summary>
        /// Order type. Market, Limit. For TP/SL order, it means the order type after triggered
        /// </summary>
        public OrderType? OrderType { get; set; } = default!;

        /// <summary>
        /// Stop order type
        /// </summary>
        public StopOrderType? StopOrderType { get; set; } = default!;

        /// <summary>
        /// Implied volatility
        /// </summary>
        public string OrderIv { get; set; } = default!;

        /// <summary>
        /// The unit for qty when creating Spot market orders for UTA account. baseCoin, quoteCoin
        /// </summary>
        public string MarketUnit { get; set; } = default!;

        /// <summary>
        /// Trigger price. If stopOrderType=TrailingStop, it is the activate price. Otherwise, it is the trigger price
        /// </summary>
        public string TriggerPrice { get; set; } = default!;

        /// <summary>
        /// Take profit price
        /// </summary>
        public string TakeProfit { get; set; } = default!;

        /// <summary>
        /// Stop loss price
        /// </summary>
        public string StopLoss { get; set; } = default!;

        /// <summary>
        /// TP/SL mode, Full: entire position for TP/SL. Partial: partial position tp/sl. Spot does not have this field, and Option returns always ""
        /// </summary>
        public TpSlMode? TpSlMode { get; set; } = default!;

        /// <summary>
        /// The trigger type of Spot OCO order. OcoTriggerByUnknown, OcoTriggerTp, OcoTriggerBySl. Classic spot is not supported
        /// </summary>
        public string OcoTriggerType { get; set; } = default!;

        /// <summary>
        /// The limit order price when take profit price is triggered
        /// </summary>
        public string TpLimitPrice { get; set; } = default!;

        /// <summary>
        /// The limit order price when stop loss price is triggered
        /// </summary>
        public string SlLimitPrice { get; set; } = default!;

        /// <summary>
        /// The price type to trigger take profit
        /// </summary>
        public TriggerBy? TpTriggerBy { get; set; } = default!;

        /// <summary>
        /// The price type to trigger stop loss
        /// </summary>
        public TriggerBy? SlTriggerBy { get; set; } = default!;

        /// <summary>
        /// Trigger direction. 1: rise, 2: fall
        /// </summary>
        public TriggerDirection? TriggerDirection { get; set; }

        /// <summary>
        /// The price type of trigger price
        /// </summary>
        public TriggerBy? TriggerBy { get; set; } = default!;

        /// <summary>
        /// Last price when placing the order
        /// </summary>
        public string LastPriceOnCreated { get; set; } = default!;

        /// <summary>
        /// Reduce only. true means reduce position size
        /// </summary>
        public bool? ReduceOnly { get; set; }

        /// <summary>
        /// Close on trigger. What is a close on trigger order?
        /// </summary>
        public bool? CloseOnTrigger { get; set; }

        /// <summary>
        /// Place type, option used. iv, price
        /// </summary>
        public string PlaceType { get; set; } = default!;

        /// <summary>
        /// SMP execution type
        /// </summary>
        public SmpType? SmpType { get; set; } = default!;

        /// <summary>
        /// SMP group ID. If the UID has no group, it is 0 by default
        /// </summary>
        public int? SmpGroup { get; set; }

        /// <summary>
        /// The counterparty's orderID which triggers this SMP execution
        /// </summary>
        public string SmpOrderId { get; set; } = default!;

        /// <summary>
        /// Order created timestamp (ms)
        /// </summary>
        public string CreatedTime { get; set; } = default!;

        /// <summary>
        /// Order updated timestamp (ms)
        /// </summary>
        public string UpdatedTime { get; set; } = default!;
    }
}