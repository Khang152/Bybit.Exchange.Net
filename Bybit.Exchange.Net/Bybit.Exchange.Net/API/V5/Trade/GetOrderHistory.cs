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
                private string GetOrderHistorysUrl { get; set; } = "/v5/order/history";

                public async Task<BybitResponse<GetOrderHistoryResponse>> GetOrderHistoryAsync(GetOrderHistoryRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetOrderHistorysUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetOrderHistoryResponse>(response);
                    return results;
                }
            }
        }
    }
}