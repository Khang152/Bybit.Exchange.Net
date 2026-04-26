using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket
{
    /// <summary>
    /// Generic wrapper for Bybit WebSocket push messages.
    /// Format: { "id": "...", "topic": "order", "creationTime": ..., "data": [...] }
    /// </summary>
    public class BybitWebSocketMessage<T>
    {
        /// <summary>
        /// Message ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Topic name (e.g., "order", "position", "execution", "wallet")
        /// </summary>
        [JsonProperty("topic")]
        public string Topic { get; set; } = default!;

        /// <summary>
        /// Message creation timestamp in milliseconds
        /// </summary>
        [JsonProperty("creationTime")]
        public long CreationTime { get; set; } = default!;

        /// <summary>
        /// Data payload array
        /// </summary>
        [JsonProperty("data")]
        public List<T> Data { get; set; } = default!;
    }
}
