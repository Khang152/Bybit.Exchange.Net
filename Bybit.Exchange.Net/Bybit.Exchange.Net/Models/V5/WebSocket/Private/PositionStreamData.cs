using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket.Private
{
    /// <summary>
    /// Private position stream data model.
    /// Topic: position | position.linear | position.inverse | position.option
    /// All fields use string type for API resilience.
    /// </summary>
    public class PositionStreamData
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; } = default!;

        [JsonProperty("side")]
        public string Side { get; set; } = default!;

        [JsonProperty("size")]
        public string Size { get; set; } = default!;

        [JsonProperty("entryPrice")]
        public string EntryPrice { get; set; } = default!;

        [JsonProperty("leverage")]
        public string Leverage { get; set; } = default!;

        [JsonProperty("positionValue")]
        public string PositionValue { get; set; } = default!;

        [JsonProperty("positionBalance")]
        public string PositionBalance { get; set; } = default!;

        [JsonProperty("markPrice")]
        public string MarkPrice { get; set; } = default!;

        [JsonProperty("positionIM")]
        public string PositionIM { get; set; } = default!;

        [JsonProperty("positionIMByMp")]
        public string PositionIMByMp { get; set; } = default!;

        [JsonProperty("positionMM")]
        public string PositionMM { get; set; } = default!;

        [JsonProperty("positionMMByMp")]
        public string PositionMMByMp { get; set; } = default!;

        [JsonProperty("takeProfit")]
        public string TakeProfit { get; set; } = default!;

        [JsonProperty("stopLoss")]
        public string StopLoss { get; set; } = default!;

        [JsonProperty("trailingStop")]
        public string TrailingStop { get; set; } = default!;

        [JsonProperty("unrealisedPnl")]
        public string UnrealisedPnl { get; set; } = default!;

        [JsonProperty("curRealisedPnl")]
        public string CurRealisedPnl { get; set; } = default!;

        [JsonProperty("cumRealisedPnl")]
        public string CumRealisedPnl { get; set; } = default!;

        [JsonProperty("sessionAvgPrice")]
        public string SessionAvgPrice { get; set; } = default!;

        [JsonProperty("breakEvenPrice")]
        public string BreakEvenPrice { get; set; } = default!;

        [JsonProperty("liqPrice")]
        public string LiqPrice { get; set; } = default!;

        [JsonProperty("bustPrice")]
        public string BustPrice { get; set; } = default!;

        [JsonProperty("tpslMode")]
        public string TpslMode { get; set; } = default!;

        [JsonProperty("positionIdx")]
        public int? PositionIdx { get; set; } = default!;

        [JsonProperty("tradeMode")]
        public int? TradeMode { get; set; } = default!;

        [JsonProperty("riskId")]
        public int? RiskId { get; set; } = default!;

        [JsonProperty("riskLimitValue")]
        public string RiskLimitValue { get; set; } = default!;

        [JsonProperty("category")]
        public string Category { get; set; } = default!;

        [JsonProperty("positionStatus")]
        public string PositionStatus { get; set; } = default!;

        [JsonProperty("adlRankIndicator")]
        public int? AdlRankIndicator { get; set; } = default!;

        [JsonProperty("autoAddMargin")]
        public int? AutoAddMargin { get; set; } = default!;

        [JsonProperty("isReduceOnly")]
        public bool? IsReduceOnly { get; set; } = default!;

        [JsonProperty("seq")]
        public long? Seq { get; set; } = default!;

        [JsonProperty("leverageSysUpdatedTime")]
        public string LeverageSysUpdatedTime { get; set; } = default!;

        [JsonProperty("mmrSysUpdatedTime")]
        public string MmrSysUpdatedTime { get; set; } = default!;

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; } = default!;

        [JsonProperty("updatedTime")]
        public string UpdatedTime { get; set; } = default!;
    }
}
