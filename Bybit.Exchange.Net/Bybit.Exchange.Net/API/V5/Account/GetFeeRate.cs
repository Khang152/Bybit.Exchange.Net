using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Account;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Account
        {
            private string GetFeeRateUrl { get; set; } = "/v5/account/fee-rate";

            public async Task<BybitResponse<GetFeeRateResponse>> GetFeeRateAsync(GetFeeRateRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetFeeRateUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData);
                var results = Utils.GetResponse<GetFeeRateResponse>(response);
                return results;
            }
        }
    }
}