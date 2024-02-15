using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.SpotLeverageToken;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class SpotLeverageToken
        {
            private string GetLeveragedTokenMarketUrl { get; set; } = "/v5/spot-lever-token/reference";

            public async Task<BybitResponse<GetLeveragedTokenMarketResponse>> GetLeveragedTokenMarketAsync(GetLeveragedTokenMarketRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetLeveragedTokenMarketUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetLeveragedTokenMarketResponse>(response);
                return results;
            }
        }
    }
}