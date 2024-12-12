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
                private string SetTradingStopUrl { get; set; } = "/v5/position/trading-stop";

                public async Task<BybitResponse<SetTradingStopResponse>> SetTradingStopAsync(SetTradingStopRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, SetTradingStopUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<SetTradingStopResponse>(response);
                    return results;
                }
            }
        }
    }
}