using Bybit.Exchange.Net.Library;
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
                var requestUrl = Utils.GetUrl(Options, CancelOrderUrl);
                var response = await Utils.PostData(Options, requestUrl, requestData);
                var results = Utils.GetResponse<CancelOrderResponse>(response);
                return results;
            }
        }
    }
}