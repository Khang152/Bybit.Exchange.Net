using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.SpotLeverageToken;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class SpotLeverageToken
            {
                private string RedeemUrl { get; set; } = "/v5/spot-lever-token/redeem";

                public async Task<BybitResponse<RedeemResponse>> RedeemAsync(RedeemRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, RedeemUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<RedeemResponse>(response);
                    return results;
                }
            }
        }
    }
}