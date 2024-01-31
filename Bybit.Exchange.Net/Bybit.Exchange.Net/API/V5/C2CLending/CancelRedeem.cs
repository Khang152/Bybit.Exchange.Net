using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.C2CLending;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class C2CLending
        {
            private string CancelRedeemUrl { get; set; } = "/v5/lending/redeem-cancel";

            public async Task<BybitResponse<CancelRedeemResponse>> CancelRedeemAsync(CancelRedeemRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, CancelRedeemUrl);
                var response = await Utils.PostData(Options, requestUrl, requestData);
                var results = Utils.GetResponse<CancelRedeemResponse>(response);
                return results;
            }
        }
    }
}