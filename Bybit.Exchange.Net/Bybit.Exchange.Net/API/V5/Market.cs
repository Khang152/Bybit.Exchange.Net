using Bybit.Exchange.Net.Extensions;
using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Library.Interface;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Market;
using Bybit.Exchange.Net.Models.V5.Trade;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public class Market
        {
            #region Init

            private BybitRestOptions Options { get; set; } = default!;
            private BybitUtils Utils { get; set; } = default!;

            public Market(BybitRestOptions options)
            {
                Options = options;
                Utils = new BybitUtils(options);
            }

            #endregion Init

            public async Task<BybitResponse<GetBybitServerTimeResponse>> GetBybitServerTimeAsync()
            {
                var requestUrl = Utils.GetUrl(GetBybitServerTimesUrl, Options);
                var response = await Utils.GetData(requestUrl, null, useAPIKey: false);
                var results = Utils.GetResponse<GetBybitServerTimeResponse>(response);
                return results;
            }

            public async Task<BybitResponse<GetInstrumentsInfoResponse>> GetInstrumentsInfoAsync(GetInstrumentsInfoRequest requestData)
            {
                var requestUrl = Utils.GetUrl(GetInstrumentsInfoUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetInstrumentsInfoResponse>(response);
                return results;
            }

            public async Task<BybitResponse<GetInstrumentsInfoResponse.Linear>> GetInstrumentsInfoAsync(GetInstrumentsInfoRequest.Linear requestData)
            {
                var requestUrl = Utils.GetUrl(GetInstrumentsInfoUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetInstrumentsInfoResponse.Linear>(response);
                return results;
            }

            public async Task<BybitResponse<GetInstrumentsInfoResponse.Inverse>> GetInstrumentsInfoAsync(GetInstrumentsInfoRequest.Inverse requestData)
            {
                var requestUrl = Utils.GetUrl(GetInstrumentsInfoUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetInstrumentsInfoResponse.Inverse>(response);
                return results;
            }

            public async Task<BybitResponse<GetInstrumentsInfoResponse.Option>> GetInstrumentsInfoAsync(GetInstrumentsInfoRequest.Option requestData)
            {
                var requestUrl = Utils.GetUrl(GetInstrumentsInfoUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetInstrumentsInfoResponse.Option>(response);
                return results;
            }

            public async Task<BybitResponse<GetInstrumentsInfoResponse.Spot>> GetInstrumentsInfoAsync(GetInstrumentsInfoRequest.Spot requestData)
            {
                var requestUrl = Utils.GetUrl(GetInstrumentsInfoUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetInstrumentsInfoResponse.Spot>(response);
                return results;
            }

            public async Task<BybitResponse<GetTickersResponse>> GetTickersAsync(GetTickersRequest requestData)
            {
                var requestUrl = Utils.GetUrl(GetTickersUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetTickersResponse>(response);
                return results;
            }

            public async Task<BybitResponse<GetTickersResponse.Inverse>> GetTickersAsync(GetTickersRequest.Inverse requestData)
            {
                var requestUrl = Utils.GetUrl(GetTickersUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetTickersResponse.Inverse>(response);
                return results;
            }

            public async Task<BybitResponse<GetTickersResponse.Linear>> GetTickersAsync(GetTickersRequest.Linear requestData)
            {
                var requestUrl = Utils.GetUrl(GetTickersUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetTickersResponse.Linear>(response);
                return results;
            }

            public async Task<BybitResponse<GetTickersResponse.Option>> GetTickersAsync(GetTickersRequest.Option requestData)
            {
                var requestUrl = Utils.GetUrl(GetTickersUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetTickersResponse.Option>(response);
                return results;
            }

            public async Task<BybitResponse<GetTickersResponse.Spot>> GetTickersAsync(GetTickersRequest.Spot requestData)
            {
                var requestUrl = Utils.GetUrl(GetTickersUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData, useAPIKey: false);
                var results = Utils.GetResponse<GetTickersResponse.Spot>(response);
                return results;
            }

            #region Define

            private string GetBybitServerTimesUrl { get; set; } = "/v5/market/time";
            private string GetInstrumentsInfoUrl { get; set; } = "/v5/market/instruments-info";
            private string GetTickersUrl { get; set; } = "/v5/market/tickers";

            #endregion Define
        }
    }
}