using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket.Trade
{
    public class WsTradeRequest
    {
        [JsonProperty("reqId")]
        public string ReqId { get; set; } = default!;

        [JsonProperty("op")]
        public string Op { get; set; } = default!;

        [JsonProperty("header")]
        public WsTradeHeader Header { get; set; } = default!;

        [JsonProperty("args")]
        public List<object> Args { get; set; } = default!;
    }

    public class WsTradeHeader
    {
        [JsonProperty("X-BAPI-TIMESTAMP")]
        public string Timestamp { get; set; } = default!;

        [JsonProperty("X-BAPI-RECV-WINDOW")]
        public string RecvWindow { get; set; } = default!;
    }
}
