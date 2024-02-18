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
                private string PlaceOrderUrl { get; set; } = "/v5/order/create";

                public async Task<BybitResponse<PlaceOrderResponse>> PlaceOrderAsync(PlaceOrderRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, PlaceOrderUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<PlaceOrderResponse>(response);
                    return results;
                }
            }
        }
    }
}