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
                private string PreCheckOrderUrl { get; set; } = "/v5/order/pre-check";

                public async Task<BybitResponse<PreCheckOrderResponse>> PreCheckOrderAsync(PreCheckOrderRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, PreCheckOrderUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<PreCheckOrderResponse>(response);
                    return results;
                }
            }
        }
    }
}
