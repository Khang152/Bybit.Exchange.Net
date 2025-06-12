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
                private string GetClosedPnLUrl { get; set; } = "/v5/position/closed-pnl";

                public async Task<BybitResponse<GetClosedPnLResponse>> GetClosedPnLAsync(GetClosedPnLRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetClosedPnLUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetClosedPnLResponse>(response);
                    return results;
                }
            }
        }
    }
}