using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket.Public
{
    /// <summary>
    /// Generic wrapper for Bybit WebSocket public stream messages.
    /// Format: { "topic": "...", "type": "snapshot"|"delta", "ts": 123456, "data": {...} | [...] }
    /// </summary>
    public class PublicStreamMessage<T>
    {
        /// <summary>
        /// Topic name (e.g., "orderbook.50.BTCUSDT", "tickers.BTCUSDT")
        /// </summary>
        [JsonProperty("topic")]
        public string Topic { get; set; } = default!;

        /// <summary>
        /// Data type. snapshot or delta
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The timestamp (ms) that the system generates the data
        /// </summary>
        [JsonProperty("ts")]
        public long Timestamp { get; set; }

        /// <summary>
        /// Cross sequence (orderbook only)
        /// </summary>
        [JsonProperty("cts")]
        public long? CrossTimestamp { get; set; }

        /// <summary>
        /// Data payload. 
        /// For orderbook/ticker: single object (T).
        /// For publicTrade/kline/liquidation: list of objects (but wrapped via JSON).
        /// </summary>
        [JsonProperty("data")]
        public T Data { get; set; } = default!;
    }
}
