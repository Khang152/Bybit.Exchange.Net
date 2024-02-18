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
                private string PurchaseUrl { get; set; } = "/v5/spot-lever-token/purchase";

                public async Task<BybitResponse<PurchaseResponse>> PurchaseAsync(PurchaseRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, PurchaseUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<PurchaseResponse>(response);
                    return results;
                }
            }
        }
    }
}