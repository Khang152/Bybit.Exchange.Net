using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Market;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Market
            {
                private string GetOrderbookUrl { get; set; } = "/v5/market/orderbook";

                public async Task<BybitResponse<GetOrderbookResponse>> GetOrderbookAsync(GetOrderbookRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetOrderbookUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                    var results = Utils.GetResponse<GetOrderbookResponse>(response);
                    return results;
                }
            }
        }
    }
}