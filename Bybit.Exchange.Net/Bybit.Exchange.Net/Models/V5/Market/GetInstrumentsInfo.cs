using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Bybit.Exchange.Net.Data.Enums;
using static Bybit.Exchange.Net.Models.V5.Market.GetTickersResponse;

namespace Bybit.Exchange.Net.Models.V5.Market
{
    public class GetInstrumentsInfoBaseRequest
    {
        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>status</c></value>
        /// <remarks>
        /// | Symbol status filter
        /// </remarks>
        /// <para>
        /// spot/linear/inverse has Trading only
        /// </para>
        /// </summary>
        public Status? status { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseCoin</c></value>
        /// <remarks>
        /// | Comments: Apply to linear, inverse, option only
        /// </remarks>
        /// <para>
        /// option: it returns BTC by default
        /// </para>
        /// </summary>
        public string baseCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <para>
        /// Limit for data size per page. [1, 1000]. Default: 500
        /// </para>
        /// </summary>
        public int? limit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>cursor</c></value>
        /// <para>
        /// Cursor. Use the nextPageCursor token from the response to retrieve the next page of the result set
        /// </para>
        /// </summary>
        public string cursor { get; set; } = default!;
    }

    public class GetInstrumentsInfoRequest : GetInstrumentsInfoBaseRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// | Product type: spot, linear, inverse, option
        /// </remarks>
        public Category category { get; set; } = default!;

        public class Linear() : GetInstrumentsInfoBaseRequest
        {
            public Category category { get; set; } = Category.Linear;
        }

        public class Inverse() : GetInstrumentsInfoBaseRequest
        {
            public Category category { get; set; } = Category.Inverse;
        }

        public class Option() : GetInstrumentsInfoBaseRequest
        {
            public Category category { get; set; } = Category.Option;
        }

        public class Spot() : GetInstrumentsInfoBaseRequest
        {
            public Category category { get; set; } = Category.Spot;
        }
    }

    public class GetInstrumentsInfoResponse
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <para>
        /// Product type
        /// </para>
        /// </summary>
        public Category? Category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>nextPageCursor</c></value>
        /// <para>
        /// Cursor. Used for pagination
        /// </para>
        /// </summary>
        public string NextPageCursor { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// Object
        /// </para>
        /// </summary>
        public List<FullItem> List { get; set; } = new List<FullItem>();

        public class Linear
        {
            /// <summary>
            /// <value>Property <c>category</c></value>
            /// <para>
            /// Product type
            /// </para>
            /// </summary>
            public Category? Category { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>nextPageCursor</c></value>
            /// <para>
            /// Cursor. Used for pagination
            /// </para>
            /// </summary>
            public string NextPageCursor { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>list</c></value>
            /// <para>
            /// Object
            /// </para>
            /// </summary>
            public List<LinearItem> List { get; set; } = new List<LinearItem>();
        }

        public class LinearItem
        {
            /// <summary>
            /// <value>Property <c>symbol</c></value>
            /// <para>
            /// Symbol name
            /// </para>
            /// </summary>
            public string Symbol { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>contractType</c></value>
            /// <para>
            /// Contract type
            /// </para>
            /// </summary>
            public ContractType? ContractType { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>status</c></value>
            /// <para>
            /// Instrument status
            /// </para>
            /// </summary>
            public Status? Status { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>baseCoin</c></value>
            /// <para>
            /// Base coin
            /// </para>
            /// </summary>
            public string BaseCoin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>quoteCoin</c></value>
            /// <para>
            /// Quote coin
            /// </para>
            /// </summary>
            public string QuoteCoin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>launchTime</c></value>
            /// <para>
            /// Launch timestamp (ms)
            /// </para>
            /// </summary>
            public string LaunchTime { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>deliveryTime</c></value>
            /// <para>
            /// Delivery timestamp (ms)
            /// </para>
            /// </summary>
            public string DeliveryTime { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>deliveryFeeRate</c></value>
            /// <para>
            /// Delivery fee rate
            /// </para>
            /// </summary>
            public string DeliveryFeeRate { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>priceScale</c></value>
            /// <para>
            /// Price scale
            /// </para>
            /// </summary>
            public string PriceScale { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>leverageFilter</c></value>
            /// <para>
            /// Leverage attributes
            /// </para>
            /// </summary>
            public LeverageFilter LeverageFilter { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>priceFilter</c></value>
            /// <para>
            /// Price attributes
            /// </para>
            /// </summary>
            public PriceFilter PriceFilter { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>lotSizeFilter</c></value>
            /// <para>
            /// Size attributes
            /// </para>
            /// </summary>
            public LotSizeFilter LotSizeFilter { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>unifiedMarginTrade</c></value>
            /// <para>
            /// Whether to support unified margin trade
            /// </para>
            /// </summary>
            public bool? UnifiedMarginTrade { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>fundingInterval</c></value>
            /// <para>
            /// Funding interval (minute)
            /// </para>
            /// </summary>
            public int? FundingInterval { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>settleCoin</c></value>
            /// <para>
            /// Settle coin
            /// </para>
            /// </summary>
            public string SettleCoin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>copyTrading</c></value>
            /// <para>
            /// Copy trade symbol or not
            /// </para>
            /// </summary>
            public CopyTrading? CopyTrading { get; set; } = default!;
        }

        public class Inverse : Linear
        {
        }

        public class InverseItem : LinearItem
        {
        }

        public class Option
        {
            /// <summary>
            /// <value>Property <c>category</c></value>
            /// <para>
            /// Product type
            /// </para>
            /// </summary>
            public Category? Category { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>nextPageCursor</c></value>
            /// <para>
            /// Cursor. Used for pagination
            /// </para>
            /// </summary>
            public string NextPageCursor { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>list</c></value>
            /// <para>
            /// Object
            /// </para>
            /// </summary>
            public List<OptionItem> List { get; set; } = new List<OptionItem>();
        }

        public class OptionItem
        {
            /// <summary>
            /// <value>Property <c>symbol</c></value>
            /// <para>
            /// Symbol name
            /// </para>
            /// </summary>
            public string Symbol { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>optionsType</c></value>
            /// <para>
            /// Option type. Call, Put
            /// </para>
            /// </summary>
            public string OptionsType { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>status</c></value>
            /// <para>
            /// Instrument status
            /// </para>
            /// </summary>
            public Status? Status { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>baseCoin</c></value>
            /// <para>
            /// Base coin
            /// </para>
            /// </summary>
            public string BaseCoin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>quoteCoin</c></value>
            /// <para>
            /// Quote coin
            /// </para>
            /// </summary>
            public string QuoteCoin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>settleCoin</c></value>
            /// <para>
            /// Settle coin
            /// </para>
            /// </summary>
            public string SettleCoin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>launchTime</c></value>
            /// <para>
            /// Launch timestamp (ms)
            /// </para>
            /// </summary>
            public string LaunchTime { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>deliveryTime</c></value>
            /// <para>
            /// Delivery timestamp (ms)
            /// </para>
            /// </summary>
            public string DeliveryTime { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>deliveryFeeRate</c></value>
            /// <para>
            /// Delivery fee rate
            /// </para>
            /// </summary>
            public string DeliveryFeeRate { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>priceFilter</c></value>
            /// <para>
            /// Price attributes
            /// </para>
            /// </summary>
            public PriceFilter PriceFilter { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>lotSizeFilter</c></value>
            /// <para>
            /// Size attributes
            /// </para>
            /// </summary>
            public LotSizeFilter LotSizeFilter { get; set; } = default!;
        }

        public class Spot
        {
            /// <summary>
            /// <value>Property <c>category</c></value>
            /// <para>
            /// Product type
            /// </para>
            /// </summary>
            public Category? Category { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>nextPageCursor</c></value>
            /// <para>
            /// Cursor. Used for pagination
            /// </para>
            /// </summary>
            public string NextPageCursor { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>list</c></value>
            /// <para>
            /// Object
            /// </para>
            /// </summary>
            public List<SpotItem> List { get; set; } = new List<SpotItem>();
        }

        public class SpotItem
        {
            /// <summary>
            /// <value>Property <c>symbol</c></value>
            /// <para>
            /// Symbol name
            /// </para>
            /// </summary>
            public string Symbol { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>baseCoin</c></value>
            /// <para>
            /// Base coin
            /// </para>
            /// </summary>
            public string BaseCoin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>quoteCoin</c></value>
            /// <para>
            /// Quote coin
            /// </para>
            /// </summary>
            public string QuoteCoin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>innovation</c></value>
            /// <para>
            /// Whether or not this is an innovation zone token. 0: false, 1: true
            /// </para>
            /// </summary>
            public string Innovation { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>status</c></value>
            /// <para>
            /// Instrument status
            /// </para>
            /// </summary>
            public Status? Status { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>marginTrading</c></value>
            /// <para>
            /// Margin trade symbol or not
            /// </para>
            /// <para>
            /// This is to identify if the symbol supports margin trading under different account modes
            /// You may find some symbols not supporting margin buy or margin sell, so you need to go to Collateral Info (UTA) or Borrowable Coin (Classic) to check if that coin is borrowable
            /// </para>
            /// </summary>
            public MarginTrading? MarginTrading { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>lotSizeFilter</c></value>
            /// <para>
            /// Size attributes
            /// </para>
            /// </summary>
            public LotSizeFilter LotSizeFilter { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>priceFilter</c></value>
            /// <para>
            /// Price attributes
            /// </para>
            /// </summary>
            public PriceFilter PriceFilter { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>riskParameters</c></value>
            /// <para>
            /// Price limit parameters
            /// </para>
            /// </summary>
            public RiskParameters RiskParameters { get; set; } = default!;
        }

        public class FullItem : LinearItem
        {
            /// <summary>
            /// <value>Property <c>optionsType</c></value>
            /// <para>
            /// Option type. Call, Put
            /// </para>
            /// </summary>
            public string OptionsType { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>innovation</c></value>
            /// <para>
            /// Whether or not this is an innovation zone token. 0: false, 1: true
            /// </para>
            /// </summary>
            public string Innovation { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>marginTrading</c></value>
            /// <para>
            /// Margin trade symbol or not
            /// </para>
            /// <para>
            /// This is to identify if the symbol supports margin trading under different account modes
            /// You may find some symbols not supporting margin buy or margin sell, so you need to go to Collateral Info (UTA) or Borrowable Coin (Classic) to check if that coin is borrowable
            /// </para>
            /// </summary>
            public MarginTrading? MarginTrading { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>riskParameters</c></value>
            /// <para>
            /// Price limit parameters
            /// </para>
            /// </summary>
            public RiskParameters RiskParameters { get; set; } = default!;
        }
    }

    public class LeverageFilter
    {
        /// <summary>
        /// <value>Property <c>minLeverage</c></value>
        /// <para>
        /// Minimum leverage
        /// </para>
        /// </summary>
        public string MinLeverage { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>maxLeverage</c></value>
        /// <para>
        /// Maximum leverage
        /// </para>
        /// </summary>
        public string MaxLeverage { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>leverageStep</c></value>
        /// <para>
        /// The step to increase/reduce leverage
        /// </para>
        /// </summary>
        public string LeverageStep { get; set; } = default!;
    }

    public class PriceFilter
    {
        /// <summary>
        /// <value>Property <c>minPrice</c></value>
        /// <para>
        /// Minimum order price
        /// </para>
        /// </summary>
        public string MinPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>maxPrice</c></value>
        /// <para>
        /// Maximum order price
        /// </para>
        /// </summary>
        public string MaxPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>tickSize</c></value>
        /// <para>
        /// The step to increase/reduce order price
        /// </para>
        /// </summary>
        public string TickSize { get; set; } = default!;
    }

    public class LotSizeFilter
    {
        /// <summary>
        /// <value>Property <c>BasePrecision</c></value>
        /// <para>
        /// The precision of base coin
        /// </para>
        /// </summary>
        public string BasePrecision { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>QuotePrecision</c></value>
        /// <para>
        /// The precision of quote coin
        /// </para>
        /// </summary>
        public string QuotePrecision { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>minOrderQty</c></value>
        /// <para>
        /// Minimum order quantity
        /// </para>
        /// </summary>
        public string MinOrderQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>maxOrderQty</c></value>
        /// <para>
        /// Maximum order quantity
        /// </para>
        /// </summary>
        public string MaxOrderQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>MinOrderAmt</c></value>
        /// <para>
        /// Minimum order amount
        /// </para>
        /// </summary>
        public string MinOrderAmt { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>MaxOrderAmt</c></value>
        /// <para>
        /// Maximum order amount
        /// </para>
        /// </summary>
        public string MaxOrderAmt { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>qtyStep</c></value>
        /// <para>
        /// The step to increase/reduce order quantity
        /// </para>
        /// </summary>
        public string QtyStep { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>postOnlyMaxOrderQty</c></value>
        /// <para>
        /// Maximum order qty for PostOnly order
        /// </para>
        /// </summary>
        public string PostOnlyMaxOrderQty { get; set; } = default!;
    }

    public class RiskParameters
    {
        /// <summary>
        /// <value>Property <c>limitParameter</c></value>
        /// <para>
        /// Price limit on Limit order. For example, "0.05" means 5%, so the order price of your buy order cannot exceed 105% of the Last Traded Price, while the order price of your sell order cannot be lower than 95% of the Last Traded Price
        /// </para>
        /// </summary>
        public string LimitParameter { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>marketParameter</c></value>
        /// <para>
        /// Price limit on Market order. For example, assuming the market order limit for MNT/USDT is 5%. When the last traded price is at 2 USDT, a trader places a market order for 100,000 USDT. Any portion that could have been filled at above 2.1 USDT will be canceled. Assuming only 80,000 USDT order value can be filled at a price of 2.1 USDT or below, the remaining 20,000 USDT order value will be canceled since the deviation exceeds the 5% threshold
        /// </para>
        /// </summary>
        public string MarketParameter { get; set; } = default!;
    }
}