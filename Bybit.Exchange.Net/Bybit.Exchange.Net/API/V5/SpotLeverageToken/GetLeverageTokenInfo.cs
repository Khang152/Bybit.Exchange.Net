using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.SpotLeverageToken;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class SpotLeverageToken
        {
            private string GetLeverageTokenInfoUrl { get; set; } = "/v5/spot-lever-token/info";

            public async Task<BybitResponse<GetLeverageTokenInfoResponse>> GetLeverageTokenInfoAsync(GetLeverageTokenInfoRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetLeverageTokenInfoUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetLeverageTokenInfoResponse>(response);
                return results;
            }
        }
    }
}