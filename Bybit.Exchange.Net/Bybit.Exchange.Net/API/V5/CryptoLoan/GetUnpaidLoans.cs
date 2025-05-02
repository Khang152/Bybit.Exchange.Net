using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.InstitutionalLoan;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class InstitutionalLoan
            {
                private string GetUnpaidLoansUrl { get; set; } = "/v5/crypto-loan/ongoing-orders";

                public async Task<BybitResponse<GetUnpaidLoansResponse>> GetUnpaidLoansAsync(GetUnpaidLoansRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetUnpaidLoansUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: true);
                    var results = Utils.GetResponse<GetUnpaidLoansResponse>(response);
                    return results;
                }
            }
        }
    }
}
