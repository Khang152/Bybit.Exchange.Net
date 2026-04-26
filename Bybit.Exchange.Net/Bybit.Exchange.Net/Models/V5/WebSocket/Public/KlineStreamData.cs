using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket.Public
{
    /// <summary>
    /// Kline (candlestick) stream data model.
    /// Topic: kline.{interval}.{symbol}
    /// Push frequency: 1-60s
    /// </summary>
    public class KlineStreamData
    {
        /// <summary>
        /// The start timestamp (ms)
        /// </summary>
        [JsonProperty("start")]
        public long Start { get; set; }

        /// <summary>
        /// The end timestamp (ms)
        /// </summary>
        [JsonProperty("end")]
        public long End { get; set; }

        /// <summary>
        /// Kline interval (e.g., "1", "5", "15", "60", "D", "W", "M")
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; } = default!;

        /// <summary>
        /// Open price
        /// </summary>
        [JsonProperty("open")]
        public string Open { get; set; } = default!;

        /// <summary>
        /// Close price
        /// </summary>
        [JsonProperty("close")]
        public string Close { get; set; } = default!;

        /// <summary>
        /// Highest price
        /// </summary>
        [JsonProperty("high")]
        public string High { get; set; } = default!;

        /// <summary>
        /// Lowest price
        /// </summary>
        [JsonProperty("low")]
        public string Low { get; set; } = default!;

        /// <summary>
        /// Trade volume
        /// </summary>
        [JsonProperty("volume")]
        public string Volume { get; set; } = default!;

        /// <summary>
        /// Turnover
        /// </summary>
        [JsonProperty("turnover")]
        public string Turnover { get; set; } = default!;

        /// <summary>
        /// Whether the candle is closed. true = closed, false = still updating
        /// </summary>
        [JsonProperty("confirm")]
        public bool Confirm { get; set; }

        /// <summary>
        /// The timestamp (ms) of the last matched order in the candle
        /// </summary>
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
