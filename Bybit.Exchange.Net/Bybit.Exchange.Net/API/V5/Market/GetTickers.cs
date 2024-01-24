using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Market;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Market
        {
            private string GetTickersUrl { get; set; } = "/v5/market/tickers";

            public async Task<BybitResponse<GetTickersResponse>> GetTickersAsync(GetTickersRequest requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetTickersUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetTickersResponse>(response);
                return results;
            }

            public async Task<BybitResponse<GetTickersResponse.Inverse>> GetTickersAsync(GetTickersRequest.Inverse requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetTickersUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetTickersResponse.Inverse>(response);
                return results;
            }

            public async Task<BybitResponse<GetTickersResponse.Linear>> GetTickersAsync(GetTickersRequest.Linear requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetTickersUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetTickersResponse.Linear>(response);
                return results;
            }

            public async Task<BybitResponse<GetTickersResponse.Option>> GetTickersAsync(GetTickersRequest.Option requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetTickersUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetTickersResponse.Option>(response);
                return results;
            }

            public async Task<BybitResponse<GetTickersResponse.Spot>> GetTickersAsync(GetTickersRequest.Spot requestData)
            {
                var requestUrl = Utils.GetUrl(Options, GetTickersUrl);
                var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetTickersResponse.Spot>(response);
                return results;
            }
        }
    }
}