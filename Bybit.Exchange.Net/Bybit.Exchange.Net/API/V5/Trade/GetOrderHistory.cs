using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Trade;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Trade
        {
            private string GetOrderHistorysUrl { get; set; } = "/v5/order/history";

            public async Task<BybitResponse<GetOrderHistoryResponse>> GetOrderHistoryAsync(GetOrderHistoryRequest requestData)
            {
                var requestUrl = Utils.GetUrl(GetOrderHistorysUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData);
                var results = Utils.GetResponse<GetOrderHistoryResponse>(response);
                return results;
            }
        }
    }
}