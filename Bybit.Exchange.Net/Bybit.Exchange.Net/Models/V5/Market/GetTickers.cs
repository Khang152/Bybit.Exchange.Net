using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Market
{
    public class GetTickersBaseRequest
    {
        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseCoin</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <para>
        /// Apply to option only
        /// </para>
        /// </summary>
        public string baseCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>expDate</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <para>
        /// Expiry date. e.g., 25DEC22. Apply to option only
        /// </para>
        /// </summary>
        public string expDate { get; set; } = default!;
    }

    public class GetTickersRequest : GetTickersBaseRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <para>
        /// Product type. spot, linear, inverse, option
        /// </para>
        /// </summary>
        public Category? category { get; set; } = default!;

        public class Linear() : GetTickersBaseRequest
        {
            public Category? category { get; set; } = Category.Linear;
        }

        public class Inverse() : GetTickersBaseRequest
        {
            public Category? category { get; set; } = Category.Inverse;
        }

        public class Option() : GetTickersBaseRequest
        {
            public Category? category { get; set; } = Category.Option;
        }

        public class Spot() : GetTickersBaseRequest
        {
            public Category? category { get; set; } = Category.Spot;
        }
    }

    public class GetTickersResponse
    {
        public Category? Category { get; set; } = default!;

        public List<FullItem> List { get; set; } = default!;

        public class Linear : Inverse
        {
        }

        public class Inverse
        {
            public Category? Category { get; set; } = default!;

            public List<InverseItem> List { get; set; } = default!;
        }

        public class InverseItem
        {
            public string Symbol { get; set; } = default!;
            public string LastPrice { get; set; } = default!;
            public string IndexPrice { get; set; } = default!;
            public string MarkPrice { get; set; } = default!;
            public string PrevPrice24h { get; set; } = default!;
            public string Price24hPcnt { get; set; } = default!;
            public string HighPrice24h { get; set; } = default!;
            public string LowPrice24h { get; set; } = default!;
            public string PrevPrice1h { get; set; } = default!;
            public string OpenInterest { get; set; } = default!;
            public string OpenInterestValue { get; set; } = default!;
            public string Turnover24h { get; set; } = default!;
            public string Volume24h { get; set; } = default!;
            public string FundingRate { get; set; } = default!;
            public string NextFundingTime { get; set; } = default!;
            public string PredictedDeliveryPrice { get; set; } = default!;
            public string BasisRate { get; set; } = default!;
            public string Basis { get; set; } = default!;
            public string DeliveryFeeRate { get; set; } = default!;
            public string DeliveryTime { get; set; } = default!;
            public string Ask1Size { get; set; } = default!;
            public string Bid1Price { get; set; } = default!;
            public string Ask1Price { get; set; } = default!;
            public string Bid1Size { get; set; } = default!;
        }

        public class Option
        {
            public Category? Category { get; set; } = default!;
            public List<OptionItem> List { get; set; } = default!;
        }

        public class OptionItem
        {
            public string Symbol { get; set; } = default!;
            public string Bid1Price { get; set; } = default!;
            public string Bid1Size { get; set; } = default!;
            public string Bid1Iv { get; set; } = default!;
            public string Ask1Price { get; set; } = default!;
            public string Ask1Size { get; set; } = default!;
            public string Ask1Iv { get; set; } = default!;
            public string LastPrice { get; set; } = default!;
            public string HighPrice24h { get; set; } = default!;
            public string LowPrice24h { get; set; } = default!;
            public string MarkPrice { get; set; } = default!;
            public string IndexPrice { get; set; } = default!;
            public string MarkIv { get; set; } = default!;
            public string UnderlyingPrice { get; set; } = default!;
            public string OpenInterest { get; set; } = default!;
            public string Turnover24h { get; set; } = default!;
            public string Volume24h { get; set; } = default!;
            public string TotalVolume { get; set; } = default!;
            public string TotalTurnover { get; set; } = default!;
            public string Delta { get; set; } = default!;
            public string Gamma { get; set; } = default!;
            public string Vega { get; set; } = default!;
            public string Theta { get; set; } = default!;
            public string PredictedDeliveryPrice { get; set; } = default!;
            public string Change24h { get; set; } = default!;
        }

        public class Spot
        {
            public Category? Category { get; set; } = default!;
            public List<SpotItem> List { get; set; } = default!;
        }

        public class SpotItem
        {
            public string Symbol { get; set; } = default!;
            public string Bid1Price { get; set; } = default!;
            public string Bid1Size { get; set; } = default!;
            public string Ask1Price { get; set; } = default!;
            public string Ask1Size { get; set; } = default!;
            public string LastPrice { get; set; } = default!;
            public string PrevPrice24h { get; set; } = default!;
            public string Price24hPcnt { get; set; } = default!;
            public string HighPrice24h { get; set; } = default!;
            public string LowPrice24h { get; set; } = default!;
            public string Turnover24h { get; set; } = default!;
            public string Volume24h { get; set; } = default!;
            public string UsdIndexPrice { get; set; } = default!;
        }

        public class FullItem : InverseItem
        {
            public string Ask1Iv { get; set; } = default!;
            public string MarkIv { get; set; } = default!;
            public string UnderlyingPrice { get; set; } = default!;
            public string TotalVolume { get; set; } = default!;
            public string TotalTurnover { get; set; } = default!;
            public string Delta { get; set; } = default!;
            public string Gamma { get; set; } = default!;
            public string Vega { get; set; } = default!;
            public string Theta { get; set; } = default!;
            public string Change24h { get; set; } = default!;
            public string UsdIndexPrice { get; set; } = default!;
        }
    }
}