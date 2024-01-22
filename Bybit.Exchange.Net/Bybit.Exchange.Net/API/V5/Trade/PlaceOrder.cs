using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Trade;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Trade
        {
            private string PlaceOrderUrl { get; set; } = "/v5/order/create";

            public async Task<BybitResponse<PlaceOrderResponse>> PlaceOrderAsync(PlaceOrderRequest requestData)
            {
                var requestUrl = Utils.GetUrl(PlaceOrderUrl, Options);
                var response = await Utils.PostData(requestUrl, requestData);
                var results = Utils.GetResponse<PlaceOrderResponse>(response);
                return results;
            }
        }
    }
}