using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Account;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Account
        {
            private string GetWalletBalanceUrl { get; set; } = "/v5/account/wallet-balance";

            public async Task<BybitResponse<GetWalletBalanceResponse>> GetWalletBalanceAsync(GetWalletBalanceRequest requestData)
            {
                var requestUrl = Utils.GetUrl(GetWalletBalanceUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData);
                var results = Utils.GetResponse<GetWalletBalanceResponse>(response);
                return results;
            }
        }
    }
}