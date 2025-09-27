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
                private string AddOrReduceMarginUrl { get; set; } = "/v5/position/add-margin";

                public async Task<BybitResponse<AddOrReduceMarginResponse>> AddOrReduceMarginAsync(AddOrReduceMarginRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, AddOrReduceMarginUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<AddOrReduceMarginResponse>(response);
                    return results;
                }
            }
        }
    }
}