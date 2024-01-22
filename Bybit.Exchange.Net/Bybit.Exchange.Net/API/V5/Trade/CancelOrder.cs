using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Trade;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Trade
        {
            private string CancelOrderUrl { get; set; } = "/v5/order/cancel";

            public async Task<BybitResponse<CancelOrderResponse>> CancelOrderAsync(CancelOrderRequest requestData)
            {
                var requestUrl = Utils.GetUrl(CancelOrderUrl, Options);
                var response = await Utils.PostData(requestUrl, requestData);
                var results = Utils.GetResponse<CancelOrderResponse>(response);
                return results;
            }
        }
    }
}