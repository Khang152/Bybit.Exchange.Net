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
                private string MovePositionUrl { get; set; } = "/v5/position/move-positions";

                public async Task<BybitResponse<MovePositionResponse>> MovePositionAsync(MovePositionRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, MovePositionUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<MovePositionResponse>(response);
                    return results;
                }
            }
        }
    }
}
