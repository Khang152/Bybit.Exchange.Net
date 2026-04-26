using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket.Public
{
    /// <summary>
    /// Public recent trades stream data model.
    /// Topic: publicTrade.{symbol}
    /// Push frequency: real-time
    /// </summary>
    public class PublicTradeStreamData
    {
        /// <summary>
        /// The timestamp (ms) that the order is filled
        /// </summary>
        [JsonProperty("T")]
        public long Timestamp { get; set; }

        /// <summary>
        /// Symbol name
        /// </summary>
        [JsonProperty("s")]
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// Side. Buy, Sell
        /// </summary>
        [JsonProperty("S")]
        public string Side { get; set; } = default!;

        /// <summary>
        /// Trade size
        /// </summary>
        [JsonProperty("v")]
        public string Size { get; set; } = default!;

        /// <summary>
        /// Trade price
        /// </summary>
        [JsonProperty("p")]
        public string Price { get; set; } = default!;

        /// <summary>
        /// Direction of price change. Tick direction
        /// </summary>
        [JsonProperty("L")]
        public string TickDirection { get; set; } = default!;

        /// <summary>
        /// Trade ID
        /// </summary>
        [JsonProperty("i")]
        public string TradeId { get; set; } = default!;

        /// <summary>
        /// Whether it is a block trade order or not
        /// </summary>
        [JsonProperty("BT")]
        public bool BlockTrade { get; set; }

        /// <summary>
        /// Cross sequence (for Futures and Spot)
        /// </summary>
        [JsonProperty("seq")]
        public long? Seq { get; set; }

        /// <summary>
        /// Mark price (option only)
        /// </summary>
        [JsonProperty("mP")]
        public string? MarkPrice { get; set; }

        /// <summary>
        /// Index price (option only)
        /// </summary>
        [JsonProperty("iP")]
        public string? IndexPrice { get; set; }

        /// <summary>
        /// Mark IV (option only)
        /// </summary>
        [JsonProperty("mIv")]
        public string? MarkIv { get; set; }

        /// <summary>
        /// IV (option only)
        /// </summary>
        [JsonProperty("iv")]
        public string? Iv { get; set; }
    }
}
