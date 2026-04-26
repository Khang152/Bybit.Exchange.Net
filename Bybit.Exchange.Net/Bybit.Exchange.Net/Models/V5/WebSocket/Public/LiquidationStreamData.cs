using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket.Public
{
    /// <summary>
    /// All liquidation stream data model.
    /// Topic: allLiquidation.{symbol}
    /// Push frequency: 500ms
    /// Covers: USDT contract / USDC contract / Inverse contract
    /// </summary>
    public class LiquidationStreamData
    {
        /// <summary>
        /// The updated timestamp (ms)
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
        /// Execution size
        /// </summary>
        [JsonProperty("v")]
        public string Size { get; set; } = default!;

        /// <summary>
        /// Bankruptcy price
        /// </summary>
        [JsonProperty("p")]
        public string Price { get; set; } = default!;
    }
}
