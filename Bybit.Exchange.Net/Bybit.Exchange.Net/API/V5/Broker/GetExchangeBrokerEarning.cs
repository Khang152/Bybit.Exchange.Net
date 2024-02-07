using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Broker;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Broker
        {
            private string GetExchangeBrokerEarningUrl { get; set; } = "/v5/broker/earnings-info";

            public async Task<BybitResponse<GetExchangeBrokerEarningResponse>> GetExchangeBrokerEarning(GetExchangeBrokerEarningRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetExchangeBrokerEarningUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData);
                var results = Utils.GetResponse<GetExchangeBrokerEarningResponse>(response);
                return results;
            }
        }
    }
}