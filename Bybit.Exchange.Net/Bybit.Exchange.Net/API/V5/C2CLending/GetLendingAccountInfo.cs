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
                private string GetLendingAccountInfoUrl { get; set; } = "/v5/lending/account";

                public async Task<BybitResponse<GetLendingAccountInfoResponse>> GetLendingAccountInfoAsync(GetLendingAccountInfoRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetLendingAccountInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetLendingAccountInfoResponse>(response);
                    return results;
                }
            }
        }
    }
}