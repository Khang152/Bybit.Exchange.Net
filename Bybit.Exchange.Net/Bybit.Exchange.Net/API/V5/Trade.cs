using Bybit.Exchange.Net.Extensions;
using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Library.Interface;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Market;
using Bybit.Exchange.Net.Models.V5.Trade;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public class Trade
        {
            #region Init

            private BybitRestOptions Options { get; set; } = default!;
            private BybitUtils Utils { get; set; } = default!;

            public Trade(BybitRestOptions options)
            {
                Options = options;
                Utils = new BybitUtils(options);
            }

            #endregion Init

            public async Task<BybitResponse<PlaceOrderResponse>> PlaceOrderAsync(PlaceOrderRequest requestData)
            {
                var requestUrl = Utils.GetUrl(PlaceOrderUrl, Options);
                var response = await Utils.PostData(requestUrl, requestData);
                var results = Utils.GetResponse<PlaceOrderResponse>(response);
                return results;
            }

            public async Task<BybitResponse<CancelOrderResponse>> CancelOrderAsync(CancelOrderRequest requestData)
            {
                var requestUrl = Utils.GetUrl(CancelOrderUrl, Options);
                var response = await Utils.PostData(requestUrl, requestData);
                var results = Utils.GetResponse<CancelOrderResponse>(response);
                return results;
            }

            public async Task<BybitResponse<GetOpenOrdersResponse>> GetOpenOrdersAsync(GetOpenOrdersRequest requestData)
            {
                var requestUrl = Utils.GetUrl(GetOpenOrdersUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData);
                var results = Utils.GetResponse<GetOpenOrdersResponse>(response);
                return results;
            }

            public async Task<BybitResponse<GetOrderHistoryResponse>> GetOrderHistoryAsync(GetOrderHistoryRequest requestData)
            {
                var requestUrl = Utils.GetUrl(GetOrderHistorysUrl, Options);
                var response = await Utils.GetData(requestUrl, requestData);
                var results = Utils.GetResponse<GetOrderHistoryResponse>(response);
                return results;
            }

            #region Defines

            private string PlaceOrderUrl { get; set; } = "/v5/order/create";
            private string CancelOrderUrl { get; set; } = "/v5/order/cancel";
            private string GetOpenOrdersUrl { get; set; } = "/v5/order/realtime";
            private string GetOrderHistorysUrl { get; set; } = "/v5/order/history";

            #endregion Defines
        }
    }
}