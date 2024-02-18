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
                private string GetOpenOrdersUrl { get; set; } = "/v5/order/realtime";

                public async Task<BybitResponse<GetOpenOrdersResponse>> GetOpenOrdersAsync(GetOpenOrdersRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetOpenOrdersUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetOpenOrdersResponse>(response);
                    return results;
                }
            }
        }
    }
}