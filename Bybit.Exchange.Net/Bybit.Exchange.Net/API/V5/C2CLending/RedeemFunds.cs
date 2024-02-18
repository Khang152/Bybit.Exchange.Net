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
                private string RedeemFundsUrl { get; set; } = "/v5/lending/redeem";

                public async Task<BybitResponse<RedeemFundsResponse>> RedeemFundsAsync(RedeemFundsRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, RedeemFundsUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<RedeemFundsResponse>(response);
                    return results;
                }
            }
        }
    }
}