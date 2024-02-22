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
                private string ToggleMarginTradeUrl { get; set; } = "/v5/spot-margin-trade/switch-mode";

                public async Task<BybitResponse<ToggleMarginTradeResponse>> ToggleMarginTradeAsync(ToggleMarginTradeRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, ToggleMarginTradeUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<ToggleMarginTradeResponse>(response);
                    return results;
                }
            }
        }
    }
}