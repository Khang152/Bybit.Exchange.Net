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
                private string SetAutoAddMarginUrl { get; set; } = "/v5/position/set-auto-add-margin";

                public async Task<BybitResponse<SetAutoAddMarginResponse>> SetAutoAddMarginAsync(SetAutoAddMarginRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, SetAutoAddMarginUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<SetAutoAddMarginResponse>(response);
                    return results;
                }
            }
        }
    }
}