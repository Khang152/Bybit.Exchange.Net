using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Account;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Account
            {
                private string GetAccountInfoUrl { get; set; } = "/v5/account/info";

                public async Task<BybitResponse<GetAccountInfoResponse>> GetAccountInfoAsync()
                {
                    var requestUrl = Utils.GetUrl(Options, GetAccountInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, null);
                    var results = Utils.GetResponse<GetAccountInfoResponse>(response);
                    return results;
                }
            }
        }
    }
}