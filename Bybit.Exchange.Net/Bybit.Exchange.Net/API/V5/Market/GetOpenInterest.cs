using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Market;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Market
            {
                private string GetOpenInterestUrl { get; set; } = "/v5/market/open-interest";

                public async Task<BybitResponse<GetOpenInterestResponse>> GetOpenInterestAsync(GetOpenInterestRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetOpenInterestUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                    var results = Utils.GetResponse<GetOpenInterestResponse>(response);
                    return results;
                }
            }
        }
    }
}