using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Position;
using System.Threading.Tasks;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Position
            {
                private string GetClosedOptionsPositionsUrl { get; set; } = "/v5/position/get-closed-positions";

                public async Task<BybitResponse<GetClosedOptionsPositionsResponse>> GetClosedOptionsPositionsAsync(GetClosedOptionsPositionsRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetClosedOptionsPositionsUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetClosedOptionsPositionsResponse>(response);
                    return results;
                }
            }
        }
    }
}
