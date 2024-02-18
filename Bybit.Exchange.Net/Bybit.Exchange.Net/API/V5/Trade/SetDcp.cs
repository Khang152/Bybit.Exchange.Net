using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Trade;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Trade
            {
                private string SetDcpUrl { get; set; } = "/v5/order/disconnected-cancel-all";

                public async Task<BybitResponse<SetDcpResponse>> SetDcpAsync(SetDcpRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, SetDcpUrl);
                    var response = await Utils.PostData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<SetDcpResponse>(response);
                    return results;
                }
            }
        }
    }
}