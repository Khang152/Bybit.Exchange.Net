using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Broker;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Broker
        {
            private string GetExchangeBrokerAccountInfoUrl { get; set; } = "/v5/broker/account-info";

            public async Task<BybitResponse<GetExchangeBrokerAccountInfoResponse>> GetExchangeBrokerAccountInfo(GetExchangeBrokerAccountInfoRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetExchangeBrokerAccountInfoUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData);
                var results = Utils.GetResponse<GetExchangeBrokerAccountInfoResponse>(response);
                return results;
            }
        }
    }
}