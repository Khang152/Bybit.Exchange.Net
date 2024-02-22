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
                private string GetVIPMarginDataUrl { get; set; } = "/v5/spot-margin-trade/data";

                public async Task<BybitResponse<GetVIPMarginDataUTAResponse>> GetVIPMarginDataAsync(GetVIPMarginDataUTARequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetVIPMarginDataUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                    var results = Utils.GetResponse<GetVIPMarginDataUTAResponse>(response);
                    return results;
                }
            }
        }
    }
}