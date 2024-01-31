using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.C2CLending;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class C2CLending
        {
            private string DepositFundsUrl { get; set; } = "/v5/lending/purchase";

            public async Task<BybitResponse<DepositFundsResponse>> DepositFundsAsync(DepositFundsRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, DepositFundsUrl);
                var response = await Utils.PostData(Options, requestUrl, requestData);
                var results = Utils.GetResponse<DepositFundsResponse>(response);
                return results;
            }
        }
    }
}