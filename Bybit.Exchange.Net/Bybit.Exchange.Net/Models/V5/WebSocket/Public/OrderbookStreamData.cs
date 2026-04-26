using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket.Public
{
    /// <summary>
    /// Orderbook stream data model.
    /// Topic: orderbook.{depth}.{symbol}
    /// Supports snapshot and delta updates.
    /// </summary>
    public class OrderbookStreamData
    {
        /// <summary>
        /// Symbol name
        /// </summary>
        [JsonProperty("s")]
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// Bids. [[price, size], ...]
        /// </summary>
        [JsonProperty("b")]
        public List<string[]> Bids { get; set; } = default!;

        /// <summary>
        /// Asks. [[price, size], ...]
        /// </summary>
        [JsonProperty("a")]
        public List<string[]> Asks { get; set; } = default!;

        /// <summary>
        /// Update ID. Is a sequence. Occasionally, you'll receive "u"=1, 
        /// which is a snapshot data due to the restart of the service.
        /// </summary>
        [JsonProperty("u")]
        public long UpdateId { get; set; }

        /// <summary>
        /// Cross sequence
        /// </summary>
        [JsonProperty("seq")]
        public long Seq { get; set; }
    }
}
