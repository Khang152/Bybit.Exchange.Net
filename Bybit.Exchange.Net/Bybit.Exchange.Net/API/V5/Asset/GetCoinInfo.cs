using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Asset;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Asset
            {
                private string GetCoinInfoUrl { get; set; } = "/v5/asset/coin/query-info";

                public async Task<BybitResponse<GetCoinInfoResponse>> GetCoinInfoAsync(GetCoinInfoRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetCoinInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetCoinInfoResponse>(response);
                    return results;
                }
            }
        }
    }
}