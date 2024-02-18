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
                private string GetPurchaseRedemptionRecordsUrl { get; set; } = "/v5/spot-lever-token/order-record";

                public async Task<BybitResponse<GetPurchaseRedemptionRecordsResponse>> GetPurchaseRedemptionRecordsAsync(GetPurchaseRedemptionRecordsRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetPurchaseRedemptionRecordsUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetPurchaseRedemptionRecordsResponse>(response);
                    return results;
                }
            }
        }
    }
}