using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Market;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Market
        {
            private string GetKlineUrl { get; set; } = "/v5/market/kline";

            public async Task<BybitResponse<GetKlineResponse>> GetKlineAsync(GetKlineRequest requestData)
            {
                var requestUrl = Utils.GetUrl(GetKlineUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetKlineResponse>(response);
                return results;
            }
        }
    }
}