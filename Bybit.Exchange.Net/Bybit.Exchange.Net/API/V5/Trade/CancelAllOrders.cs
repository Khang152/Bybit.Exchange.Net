using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Trade;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Trade
            {
                private string CancelAllOrdersUrl { get; set; } = "/v5/order/cancel-all";

                public async Task<BybitResponse<CancelAllOrdersResponse>> CancelAllOrdersAsync(CancelAllOrdersRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, CancelAllOrdersUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<CancelAllOrdersResponse>(response);
                    return results;
                }
            }
        }
    }
}