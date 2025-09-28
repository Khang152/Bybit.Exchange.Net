using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.User;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class User
            {
                private string GetUIDWalletTypeUrl { get; set; } = "/v5/user/get-member-type";

                public async Task<BybitResponse<GetUIDWalletTypeResponse>> GetUIDWalletTypeAsync(GetUIDWalletTypeRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetUIDWalletTypeUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetUIDWalletTypeResponse>(response);
                    return results;
                }
            }
        }
    }
}