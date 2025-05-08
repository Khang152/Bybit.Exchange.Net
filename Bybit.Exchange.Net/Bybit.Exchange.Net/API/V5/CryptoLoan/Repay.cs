using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.CryptoLoan;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class CryptoLoan
            {
                private string RepayUrl { get; set; } = "/v5/crypto-loan/repay";

                public async Task<BybitResponse<RepayResponse>> RepayAsync(RepayRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, RepayUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<RepayResponse>(response);
                    return results;
                }
            }
        }
    }
}
