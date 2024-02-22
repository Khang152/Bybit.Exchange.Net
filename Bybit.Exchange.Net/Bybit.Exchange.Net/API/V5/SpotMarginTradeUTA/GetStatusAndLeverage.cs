using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.SpotMarginTradeUTA;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class SpotMarginTradeUTA
            {
                private string GetStatusAndLeverageUrl { get; set; } = "/v5/spot-margin-trade/state";

                public async Task<BybitResponse<GetStatusAndLeverageResponse>> GetStatusAndLeverageAsync()
                {
                    var requestUrl = Utils.GetUrl(Options, GetStatusAndLeverageUrl);
                    var response = await Utils.GetData(Options, requestUrl, null);
                    var results = Utils.GetResponse<GetStatusAndLeverageResponse>(response);
                    return results;
                }
            }
        }
    }
}