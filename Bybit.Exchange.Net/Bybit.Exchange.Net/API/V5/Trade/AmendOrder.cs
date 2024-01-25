using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Trade;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Trade
        {
            private string AmendOrderUrl { get; set; } = "/v5/order/amend";

            public async Task<BybitResponse<AmendOrderResponse>> AmendOrderAsync(AmendOrderRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, AmendOrderUrl);
                var response = await Utils.PostData(Options, requestUrl, requestData);
                var results = Utils.GetResponse<AmendOrderResponse>(response);
                return results;
            }
        }
    }
}