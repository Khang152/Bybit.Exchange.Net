using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Trade;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Trade
        {
            private string GetTradeHistoryUrl { get; set; } = "/v5/execution/list";

            public async Task<BybitResponse<GetTradeHistoryResponse>> GetTradeHistoryAsync(GetTradeHistoryRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetTradeHistoryUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData);
                var results = Utils.GetResponse<GetTradeHistoryResponse>(response);
                return results;
            }
        }
    }
}