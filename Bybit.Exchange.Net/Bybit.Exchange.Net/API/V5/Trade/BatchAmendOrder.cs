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
                private string BatchAmendOrderUrl { get; set; } = "/v5/order/amend-batch";

                public async Task<BybitBatchResponse<BatchAmendOrderResponse>> BatchAmendOrderAsync(BatchAmendOrderRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, BatchAmendOrderUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetBatchResponse<BatchAmendOrderResponse>(response);
                    return results;
                }
            }
        }
    }
}