using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Position;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Position
            {
                private string SwitchPositionModeUrl { get; set; } = "/v5/position/switch-mode";

                public async Task<BybitResponse<SwitchPositionModeResponse>> SwitchPositionModeAsync(SwitchPositionModeRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, SwitchPositionModeUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<SwitchPositionModeResponse>(response);
                    return results;
                }
            }
        }
    }
}