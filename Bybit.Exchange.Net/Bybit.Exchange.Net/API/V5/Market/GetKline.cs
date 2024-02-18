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
                private string GetKlineUrl { get; set; } = "/v5/market/kline";

                public async Task<BybitResponse<GetKlineResponse>> GetKlineAsync(GetKlineRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetKlineUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData, useAPIKey: false);
                    var results = Utils.GetResponse<GetKlineResponse>(response);

                    if (results.Result?.List?.Any() == true)
                        results.Result.ListItems = results?.Result?.List?.Select(o => new GetKlineItem()
                        {
                            StartTime = o[0],
                            OpenPrice = o[1],
                            HighPrice = o[2],
                            LowPrice = o[3],
                            ClosePrice = o[4],
                            Volume = o[5],
                            TurnOver = o[6],
                        }).ToList() ?? new List<GetKlineItem>();

                    results ??= new BybitResponse<GetKlineResponse>();
                    return results;
                }
            }
        }
    }
}