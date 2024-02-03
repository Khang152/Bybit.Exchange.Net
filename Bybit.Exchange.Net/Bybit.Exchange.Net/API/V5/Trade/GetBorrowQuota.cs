using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Trade;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Trade
        {
            private string GetBorrowQuotaUrl { get; set; } = "/v5/order/spot-borrow-check";

            public async Task<BybitResponse<GetBorrowQuotaResponse>> GetBorrowQuotaAsync(GetBorrowQuotaRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetBorrowQuotaUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData);
                var results = Utils.GetResponse<GetBorrowQuotaResponse>(response);
                return results;
            }
        }
    }
}