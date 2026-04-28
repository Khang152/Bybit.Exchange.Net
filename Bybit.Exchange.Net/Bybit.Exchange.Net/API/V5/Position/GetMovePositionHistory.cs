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
                private string GetMovePositionHistoryUrl { get; set; } = "/v5/position/move-history";

                public async Task<BybitResponse<GetMovePositionHistoryResponse>> GetMovePositionHistoryAsync(GetMovePositionHistoryRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetMovePositionHistoryUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetMovePositionHistoryResponse>(response);
                    return results;
                }
            }
        }
    }
}
