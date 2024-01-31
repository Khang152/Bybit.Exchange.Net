using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.C2CLending;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class C2CLending
        {
            private string GetOrderRecordsUrl { get; set; } = "/v5/lending/history-order";

            public async Task<BybitResponse<GetOrderRecordsResponse>> GetOrderRecordsAsync(GetOrderRecordsRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetOrderRecordsUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData);
                var results = Utils.GetResponse<GetOrderRecordsResponse>(response);
                return results;
            }
        }
    }
}