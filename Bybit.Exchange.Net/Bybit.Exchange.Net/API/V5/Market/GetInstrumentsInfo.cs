using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Market;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Market
            {
                private string GetInstrumentsInfoUrl { get; set; } = "/v5/market/instruments-info";

                public async Task<BybitResponse<GetInstrumentsInfoResponse>> GetInstrumentsInfoAsync(GetInstrumentsInfoRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetInstrumentsInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                    var results = Utils.GetResponse<GetInstrumentsInfoResponse>(response);
                    return results;
                }

                public async Task<BybitResponse<GetInstrumentsInfoResponse.Linear>> GetInstrumentsInfoAsync(GetInstrumentsInfoRequest.Linear requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetInstrumentsInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                    var results = Utils.GetResponse<GetInstrumentsInfoResponse.Linear>(response);
                    return results;
                }

                public async Task<BybitResponse<GetInstrumentsInfoResponse.Inverse>> GetInstrumentsInfoAsync(GetInstrumentsInfoRequest.Inverse requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetInstrumentsInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                    var results = Utils.GetResponse<GetInstrumentsInfoResponse.Inverse>(response);
                    return results;
                }

                public async Task<BybitResponse<GetInstrumentsInfoResponse.Option>> GetInstrumentsInfoAsync(GetInstrumentsInfoRequest.Option requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetInstrumentsInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                    var results = Utils.GetResponse<GetInstrumentsInfoResponse.Option>(response);
                    return results;
                }

                public async Task<BybitResponse<GetInstrumentsInfoResponse.Spot>> GetInstrumentsInfoAsync(GetInstrumentsInfoRequest.Spot requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetInstrumentsInfoUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                    var results = Utils.GetResponse<GetInstrumentsInfoResponse.Spot>(response);
                    return results;
                }
            }
        }
    }
}