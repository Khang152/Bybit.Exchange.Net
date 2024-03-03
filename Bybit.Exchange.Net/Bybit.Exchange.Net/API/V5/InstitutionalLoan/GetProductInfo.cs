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
                private string GetProductInfoUrl { get; set; } = "/v5/ins-loan/product-infos";

                public async Task<BybitResponse<GetProductInfoResponse>> GetProductInfoAsync(GetProductInfoRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetProductInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetProductInfoResponse>(response);
                    return results;
                }
            }
        }
    }
}
