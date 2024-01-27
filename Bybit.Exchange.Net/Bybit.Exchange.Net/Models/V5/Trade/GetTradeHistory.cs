using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class GetTradeHistoryRequest
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
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// Order ID
        /// </para>
        /// </summary>
        public string orderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderLinkId</c></value>
        /// <para>
        /// User customized order ID. Classic account does not support this parameter.
        /// </para>
        /// </summary>
        public string orderLinkId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseCoin</c></value>
        /// <para>
        /// Base coin. Unified account - inverse and Classic account do not support this parameter
        /// </para>
        /// </summary>
        public string baseCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>startTime</c></value>
        /// <para>
        /// The start timestamp (ms)
        /// </para>
        /// <para>
        /// If startTime and endTime are not passed, return 7 days by default.
        /// </para>
        /// <para>
        /// If Only startTime is passed, return range between startTime and startTime+7 days.
        /// </para>
        /// <para>
        /// If Only endTime is passed, return range between endTime-7 days and endTime.
        /// </para>
        /// <para>
        /// If both are passed, the rule is endTime - startTime &lt;= 7 days
        /// </para>
        /// </summary>
        public double? startTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>endTime</c></value>
        /// <para>
        /// The end timestamp (ms)
        /// </para>
        /// </summary>
        public double? endTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>execType</c></value>
        /// <para>
        /// Execution type. Classic spot is not supported
        /// </para>
        /// </summary>
        public ExecType? execType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <para>
        /// Limit for data size per page. [1, 100]. Default: 50
        /// </para>
        /// </summary>
        public int? limit { get; set; } = 50;

        /// <summary>
        /// <value>Property <c>cursor</c></value>
        /// <para>
        /// Cursor. Use the nextPageCursor token from the response to retrieve the next page of the result set
        /// </para>
        /// </summary>
        public string cursor { get; set; } = default!;
    }

    public class GetTradeHistoryResponse
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <para>
        /// Product type
        /// </para>
        /// </summary>
        public Category? Category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>nextPageCursor</c></value>
        /// <para>
        /// Refer to the cursor request parameter
        /// </para>
        /// </summary>
        public string NextPageCursor { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// Object
        /// </para>
        /// </summary>
        public List<TradeHistoryItem> List { get; set; } = new List<TradeHistoryItem>();
    }

    public class TradeHistoryItem
    {
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
        /// User customized order ID. Classic spot is not supported
        /// </para>
        /// </summary>
        public string OrderLinkId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>side</c></value>
        /// <para>
        /// Side. Buy, Sell
        /// </para>
        /// </summary>
        public Side? Side { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderPrice</c></value>
        /// <para>
        /// Order price
        /// </para>
        /// </summary>
        public string OrderPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderQty</c></value>
        /// <para>
        /// Order qty
        /// </para>
        /// </summary>
        public string OrderQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>leavesQty</c></value>
        /// <para>
        /// The remaining qty not executed. Classic spot is not supported
        /// </para>
        /// </summary>
        public string LeavesQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>createType</c></value>
        /// <para>
        /// Order create type
        /// </para>
        /// <para>
        /// UTA: Only for category=linear or inverse
        /// </para>
        /// <para>
        /// Classic: always ""
        /// </para>
        /// <para>
        /// Spot, Option do not have this key
        /// </para>
        /// </summary>
        public CreateType? CreateType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderType</c></value>
        /// <para>
        /// Order type. Market, Limit
        /// </para>
        /// </summary>
        public OrderType? OrderType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>stopOrderType</c></value>
        /// <para>
        /// Stop order type. If the order is not stop order, it either returns UNKNOWN or "".
        /// </para>
        /// <para>
        /// Classic spot is not supported
        /// </para>
        /// </summary>
        public StopOrderType? StopOrderType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>execFee</c></value>
        /// <para>
        /// Executed trading fee. You can get spot fee currency instruction here
        /// </para>
        /// </summary>
        public string ExecFee { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>execId</c></value>
        /// <para>
        /// Execution ID
        /// </para>
        /// </summary>
        public string ExecId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>execPrice</c></value>
        /// <para>
        /// Execution price
        /// </para>
        /// </summary>
        public string ExecPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>execQty</c></value>
        /// <para>
        /// Execution qty
        /// </para>
        /// </summary>
        public string ExecQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>execType</c></value>
        /// <para>
        /// Executed type. Classic spot is not supported
        /// </para>
        /// </summary>
        public ExecType? ExecType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>execValue</c></value>
        /// <para>
        /// Executed order value. Classic spot is not supported
        /// </para>
        /// </summary>
        public string ExecValue { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>execTime</c></value>
        /// <para>
        /// Executed timestamp (ms)
        /// </para>
        /// </summary>
        public string ExecTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>feeCurrency</c></value>
        /// <para>
        /// Spot trading fee currency. Classic spot is not supported
        /// </para>
        /// </summary>
        public string FeeCurrency { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>isMaker</c></value>
        /// <para>
        /// Is maker order. true: maker, false: taker
        /// </para>
        /// </summary>
        public bool? IsMaker { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>feeRate</c></value>
        /// <para>
        /// Trading fee rate. Classic spot is not supported
        /// </para>
        /// </summary>
        public string FeeRate { get; set; } = default!;

        // Add more properties...

        /// <summary>
        /// <value>Property <c>tradeIv</c></value>
        /// <para>
        /// Implied volatility. Valid for option
        /// </para>
        /// </summary>
        public string TradeIv { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>markIv</c></value>
        /// <para>
        /// Implied volatility of mark price. Valid for option
        /// </para>
        /// </summary>
        public string MarkIv { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>markPrice</c></value>
        /// <para>
        /// The mark price of the symbol when executing. Classic spot is not supported
        /// </para>
        /// </summary>
        public string MarkPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>indexPrice</c></value>
        /// <para>
        /// The index price of the symbol when executing. Valid for option only
        /// </para>
        /// </summary>
        public string IndexPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>underlyingPrice</c></value>
        /// <para>
        /// The underlying price of the symbol when executing. Valid for option
        /// </para>
        /// </summary>
        public string UnderlyingPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>blockTradeId</c></value>
        /// <para>
        /// Paradigm block trade ID
        /// </para>
        /// </summary>
        public string BlockTradeId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>closedSize</c></value>
        /// <para>
        /// Closed position size
        /// </para>
        /// </summary>
        public string ClosedSize { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>seq</c></value>
        /// <para>
        /// Cross sequence, used to associate each fill and each position update
        /// </para>
        /// <para>
        /// The seq will be the same when concluding multiple transactions at the same time
        /// </para>
        /// <para>
        /// Different symbols may have the same seq, please use seq + symbol to check uniqueness
        /// </para>
        /// <para>
        /// Classic account Spot trade does not have this field
        /// </para>
        /// </summary>
        public long? Seq { get; set; } = default!;
    }
}