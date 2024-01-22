using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Market;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Market
        {
            private string GetBybitServerTimeUrl { get; set; } = "/v5/market/time";

            public async Task<BybitResponse<GetBybitServerTimeResponse>> GetBybitServerTimeAsync()
            {
                var requestUrl = Utils.GetUrl(GetBybitServerTimeUrl, Options);
                var response = await Utils.GetData(requestUrl, null, useAPIKey: false);
                var results = Utils.GetResponse<GetBybitServerTimeResponse>(response);
                return results;
            }
        }
    }
}