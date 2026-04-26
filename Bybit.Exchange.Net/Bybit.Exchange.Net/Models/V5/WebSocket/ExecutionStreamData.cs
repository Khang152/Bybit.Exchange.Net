using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket
{
    /// <summary>
    /// Private execution stream data model.
    /// Topic: execution | execution.spot | execution.linear | execution.inverse | execution.option
    /// All fields use string type for API resilience.
    /// </summary>
    public class ExecutionStreamData
    {
        [JsonProperty("category")]
        public string Category { get; set; } = default!;

        [JsonProperty("symbol")]
        public string Symbol { get; set; } = default!;

        [JsonProperty("orderId")]
        public string OrderId { get; set; } = default!;

        [JsonProperty("orderLinkId")]
        public string OrderLinkId { get; set; } = default!;

        [JsonProperty("side")]
        public string Side { get; set; } = default!;

        [JsonProperty("orderType")]
        public string OrderType { get; set; } = default!;

        [JsonProperty("orderPrice")]
        public string OrderPrice { get; set; } = default!;

        [JsonProperty("orderQty")]
        public string OrderQty { get; set; } = default!;

        [JsonProperty("stopOrderType")]
        public string StopOrderType { get; set; } = default!;

        [JsonProperty("execId")]
        public string ExecId { get; set; } = default!;

        [JsonProperty("execPrice")]
        public string ExecPrice { get; set; } = default!;

        [JsonProperty("execQty")]
        public string ExecQty { get; set; } = default!;

        [JsonProperty("execValue")]
        public string ExecValue { get; set; } = default!;

        [JsonProperty("execFee")]
        public string ExecFee { get; set; } = default!;

        [JsonProperty("execType")]
        public string ExecType { get; set; } = default!;

        [JsonProperty("execTime")]
        public string ExecTime { get; set; } = default!;

        [JsonProperty("execPnl")]
        public string ExecPnl { get; set; } = default!;

        [JsonProperty("feeRate")]
        public string FeeRate { get; set; } = default!;

        [JsonProperty("feeCurrency")]
        public string FeeCurrency { get; set; } = default!;

        [JsonProperty("leavesQty")]
        public string LeavesQty { get; set; } = default!;

        [JsonProperty("closedSize")]
        public string ClosedSize { get; set; } = default!;

        [JsonProperty("isMaker")]
        public bool? IsMaker { get; set; } = default!;

        [JsonProperty("isLeverage")]
        public string IsLeverage { get; set; } = default!;

        [JsonProperty("markPrice")]
        public string MarkPrice { get; set; } = default!;

        [JsonProperty("indexPrice")]
        public string IndexPrice { get; set; } = default!;

        [JsonProperty("underlyingPrice")]
        public string UnderlyingPrice { get; set; } = default!;

        [JsonProperty("tradeIv")]
        public string TradeIv { get; set; } = default!;

        [JsonProperty("markIv")]
        public string MarkIv { get; set; } = default!;

        [JsonProperty("blockTradeId")]
        public string BlockTradeId { get; set; } = default!;

        [JsonProperty("createType")]
        public string CreateType { get; set; } = default!;

        [JsonProperty("marketUnit")]
        public string MarketUnit { get; set; } = default!;

        [JsonProperty("seq")]
        public long? Seq { get; set; } = default!;
    }
}
