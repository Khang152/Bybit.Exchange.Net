using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket
{
    /// <summary>
    /// Response model for WebSocket operation messages (auth, subscribe, ping/pong).
    /// Used by both Private stream and Trade stream.
    /// </summary>
    public class BybitWebSocketResponse
    {
        /// <summary>
        /// Whether the operation was successful (Private/Public stream responses)
        /// </summary>
        [JsonProperty("success")]
        public bool? Success { get; set; } = default!;

        /// <summary>
        /// Return code (Trade WS responses). 0 = success
        /// </summary>
        [JsonProperty("retCode")]
        public int? RetCode { get; set; } = default!;

        /// <summary>
        /// Return message
        /// </summary>
        [JsonProperty("retMsg")]
        public string RetMsg { get; set; } = default!;

        /// <summary>
        /// Connection ID
        /// </summary>
        [JsonProperty("connId")]
        public string ConnId { get; set; } = default!;

        /// <summary>
        /// Request ID (if provided in request)
        /// </summary>
        [JsonProperty("reqId")]
        public string ReqId { get; set; } = default!;

        /// <summary>
        /// Operation type (e.g., "auth", "subscribe", "pong")
        /// </summary>
        [JsonProperty("op")]
        public string Op { get; set; } = default!;
    }
}
