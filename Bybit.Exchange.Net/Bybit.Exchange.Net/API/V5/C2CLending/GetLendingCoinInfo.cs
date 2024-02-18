using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.C2CLending;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class C2CLending
            {
                private string GetLendingCoinInfoUrl { get; set; } = "/v5/lending/info";

                public async Task<BybitResponse<GetLendingCoinInfoResponse>> GetLendingCoinInfoAsync(GetLendingCoinInfoRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetLendingCoinInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetLendingCoinInfoResponse>(response);
                    return results;
                }
            }
        }
    }
}