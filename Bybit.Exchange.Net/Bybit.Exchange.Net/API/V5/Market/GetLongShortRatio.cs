using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Market;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Market
        {
            private string GetLongShortRatioUrl { get; set; } = "/v5/market/account-ratio";

            public async Task<BybitResponse<GetLongShortRatioResponse>> GetLongShortRatioAsync(GetLongShortRatioRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetLongShortRatioUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetLongShortRatioResponse>(response);
                return results;
            }
        }
    }
}