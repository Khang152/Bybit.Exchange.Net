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
                private string BatchPlaceOrderUrl { get; set; } = "/v5/order/create-batch";

                public async Task<BybitBatchResponse<BatchPlaceOrderResponse>> BatchPlaceOrderAsync(BatchPlaceOrderRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, BatchPlaceOrderUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetBatchResponse<BatchPlaceOrderResponse>(response);
                    return results;
                }
            }
        }
    }
}