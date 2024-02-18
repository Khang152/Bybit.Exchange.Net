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
                private string BatchCancelOrderUrl { get; set; } = "/v5/order/cancel-batch";

                public async Task<BybitBatchResponse<BatchCancelOrderResponse>> BatchCancelOrderAsync(BatchCancelOrderRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, BatchCancelOrderUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetBatchResponse<BatchCancelOrderResponse>(response);
                    return results;
                }
            }
        }
    }
}