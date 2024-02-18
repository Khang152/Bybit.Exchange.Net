using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Market;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Market
            {
                private string GetBybitServerTimeUrl { get; set; } = "/v5/market/time";

                public async Task<BybitResponse<GetBybitServerTimeResponse>> GetBybitServerTimeAsync()
                {
                    var requestUrl = Utils.GetUrl(Options, GetBybitServerTimeUrl);
                    var response = await Utils.GetData(Options, requestUrl, null, useAPIKey: false);
                    var results = Utils.GetResponse<GetBybitServerTimeResponse>(response);
                    return results;
                }
            }
        }
    }
}