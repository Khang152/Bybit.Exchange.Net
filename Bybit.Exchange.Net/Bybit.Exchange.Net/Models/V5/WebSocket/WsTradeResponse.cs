using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket
{
    public class WsTradeResponse
    {
        [JsonProperty("reqId")]
        public string ReqId { get; set; } = default!;

        [JsonProperty("retCode")]
        public int RetCode { get; set; } = default!;

        [JsonProperty("retMsg")]
        public string RetMsg { get; set; } = default!;

        [JsonProperty("op")]
        public string Op { get; set; } = default!;

        [JsonProperty("connId")]
        public string ConnId { get; set; } = default!;

        [JsonProperty("data")]
        public WsTradeResponseData Data { get; set; } = default!;

        [JsonProperty("retExtInfo")]
        public dynamic RetExtInfo { get; set; } = default!;

        [JsonProperty("header")]
        public WsTradeResponseHeader Header { get; set; } = default!;
    }

    public class WsTradeResponseData
    {
        [JsonProperty("orderId")]
        public string OrderId { get; set; } = default!;

        [JsonProperty("orderLinkId")]
        public string OrderLinkId { get; set; } = default!;
    }

    public class WsTradeResponseHeader
    {
        [JsonProperty("Traceid")]
        public string TraceId { get; set; } = default!;

        [JsonProperty("Timenow")]
        public string TimeNow { get; set; } = default!;

        [JsonProperty("X-Bapi-Limit")]
        public string RateLimit { get; set; } = default!;

        [JsonProperty("X-Bapi-Limit-Status")]
        public string RateLimitStatus { get; set; } = default!;

        [JsonProperty("X-Bapi-Limit-Reset-Timestamp")]
        public string RateLimitResetTimestamp { get; set; } = default!;
    }
}
