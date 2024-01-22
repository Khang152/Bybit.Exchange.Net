using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Trade;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Trade
        {
            private string GetOpenOrdersUrl { get; set; } = "/v5/order/realtime";

            public async Task<BybitResponse<GetOpenOrdersResponse>> GetOpenOrdersAsync(GetOpenOrdersRequest requestData)
            {
                var requestUrl = Utils.GetUrl(GetOpenOrdersUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData);
                var results = Utils.GetResponse<GetOpenOrdersResponse>(response);
                return results;
            }
        }
    }
}