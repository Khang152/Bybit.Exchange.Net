using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket.Private
{
    /// <summary>
    /// Private order stream data model.
    /// Topic: order | order.spot | order.linear | order.inverse | order.option
    /// All fields use string type for API resilience.
    /// </summary>
    public class OrderStreamData
    {
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

        [JsonProperty("price")]
        public string Price { get; set; } = default!;

        [JsonProperty("qty")]
        public string Qty { get; set; } = default!;

        [JsonProperty("timeInForce")]
        public string TimeInForce { get; set; } = default!;

        [JsonProperty("orderStatus")]
        public string OrderStatus { get; set; } = default!;

        [JsonProperty("cancelType")]
        public string CancelType { get; set; } = default!;

        [JsonProperty("rejectReason")]
        public string RejectReason { get; set; } = default!;

        [JsonProperty("avgPrice")]
        public string AvgPrice { get; set; } = default!;

        [JsonProperty("leavesQty")]
        public string LeavesQty { get; set; } = default!;

        [JsonProperty("leavesValue")]
        public string LeavesValue { get; set; } = default!;

        [JsonProperty("cumExecQty")]
        public string CumExecQty { get; set; } = default!;

        [JsonProperty("cumExecValue")]
        public string CumExecValue { get; set; } = default!;

        [JsonProperty("cumExecFee")]
        public string CumExecFee { get; set; } = default!;

        [JsonProperty("orderIv")]
        public string OrderIv { get; set; } = default!;

        [JsonProperty("stopOrderType")]
        public string StopOrderType { get; set; } = default!;

        [JsonProperty("triggerPrice")]
        public string TriggerPrice { get; set; } = default!;

        [JsonProperty("takeProfit")]
        public string TakeProfit { get; set; } = default!;

        [JsonProperty("stopLoss")]
        public string StopLoss { get; set; } = default!;

        [JsonProperty("tpTriggerBy")]
        public string TpTriggerBy { get; set; } = default!;

        [JsonProperty("slTriggerBy")]
        public string SlTriggerBy { get; set; } = default!;

        [JsonProperty("tpLimitPrice")]
        public string TpLimitPrice { get; set; } = default!;

        [JsonProperty("slLimitPrice")]
        public string SlLimitPrice { get; set; } = default!;

        [JsonProperty("triggerDirection")]
        public int? TriggerDirection { get; set; } = default!;

        [JsonProperty("triggerBy")]
        public string TriggerBy { get; set; } = default!;

        [JsonProperty("lastPriceOnCreated")]
        public string LastPriceOnCreated { get; set; } = default!;

        [JsonProperty("reduceOnly")]
        public bool? ReduceOnly { get; set; } = default!;

        [JsonProperty("closeOnTrigger")]
        public bool? CloseOnTrigger { get; set; } = default!;

        [JsonProperty("tpslMode")]
        public string TpslMode { get; set; } = default!;

        [JsonProperty("smpType")]
        public string SmpType { get; set; } = default!;

        [JsonProperty("smpGroup")]
        public int? SmpGroup { get; set; } = default!;

        [JsonProperty("smpOrderId")]
        public string SmpOrderId { get; set; } = default!;

        [JsonProperty("placeType")]
        public string PlaceType { get; set; } = default!;

        [JsonProperty("positionIdx")]
        public int? PositionIdx { get; set; } = default!;

        [JsonProperty("blockTradeId")]
        public string BlockTradeId { get; set; } = default!;

        [JsonProperty("closedPnl")]
        public string ClosedPnl { get; set; } = default!;

        [JsonProperty("category")]
        public string Category { get; set; } = default!;

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; } = default!;

        [JsonProperty("updatedTime")]
        public string UpdatedTime { get; set; } = default!;

        [JsonProperty("feeCurrency")]
        public string FeeCurrency { get; set; } = default!;

        [JsonProperty("createType")]
        public string CreateType { get; set; } = default!;

        /// <summary>
        /// Cumulative fee details (for linear, spot). Key = currency, Value = fee amount
        /// </summary>
        [JsonProperty("cumFeeDetail")]
        public Dictionary<string, string> CumFeeDetail { get; set; } = default!;
    }
}
