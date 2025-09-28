using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Asset;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Asset
            {
                private string GetSubUIDUrl { get; set; } = "/v5/asset/transfer/query-sub-member-list";

                public async Task<BybitResponse<GetSubUIDResponse>> GetSubUIDAsync(GetSubUIDRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetSubUIDUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetSubUIDResponse>(response);
                    return results;
                }
            }
        }
    }
}