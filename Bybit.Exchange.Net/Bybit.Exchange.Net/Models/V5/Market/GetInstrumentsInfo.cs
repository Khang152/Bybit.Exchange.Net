using System;
using System.Collections.Generic;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Market
{
    #region Request

    public class GetInstrumentsInfoBaseRequest
    {
        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name, like BTCUSDT, uppercase showing. Either symbol or baseCoin is required
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>status</c></value>
        /// <para>
        /// Symbol status filter
        /// </para>
        /// <remarks>
        /// | linear &amp; inverse &amp; spot: By default returns only <c>Trading</c> symbols
        /// | option: By default returns <c>PreLaunch</c>, <c>Trading</c>, and <c>Delivering</c>
        /// | Spot has <c>Trading</c> only
        /// </remarks>
        /// </summary>
        public Status? status { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseCoin</c></value>
        /// <para>
        /// Base coin. Applies to <c>linear</c>, <c>inverse</c>, <c>option</c> only
        /// </para>
        /// <remarks>
        /// | option: returns BTC by default
        /// </remarks>
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
        /// Cursor. Use the <c>nextPageCursor</c> token from the response to retrieve the next page of the result set
        /// </para>
        /// </summary>
        public string cursor { get; set; } = default!;
    }

    public class GetInstrumentsInfoRequest : GetInstrumentsInfoBaseRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <para>
        /// <b>Required</b>. Product type: <c>spot</c>, <c>linear</c>, <c>inverse</c>, <c>option</c>
        /// </para>
        /// </summary>
        public Category category { get; set; } = default!;

        public class Linear() : GetInstrumentsInfoBaseRequest
        {
            /// <summary>
            /// <value>Property <c>category</c></value>
            /// </summary>
            public Category category { get; set; } = Category.Linear;
        }

        public class Inverse() : GetInstrumentsInfoBaseRequest
        {
            /// <summary>
            /// <value>Property <c>category</c></value>
            /// </summary>
            public Category category { get; set; } = Category.Inverse;
        }

        public class Option() : GetInstrumentsInfoBaseRequest
        {
            /// <summary>
            /// <value>Property <c>category</c></value>
            /// </summary>
            public Category category { get; set; } = Category.Option;
        }

        public class Spot() : GetInstrumentsInfoBaseRequest
        {
            /// <summary>
            /// <value>Property <c>category</c></value>
            /// </summary>
            public Category category { get; set; } = Category.Spot;
        }
    }

    #endregion

    #region Response

    public class GetInstrumentsInfoResponse
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <para>
        /// Product type
        /// </para>
        /// </summary>
        public string Category { get; set; } = default!;

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
        /// Object array
        /// </para>
        /// </summary>
        public List<FullItem> List { get; set; } = new List<FullItem>();

        #region Linear/Inverse Response

        public class Linear
        {
            /// <summary>
            /// Product type
            /// </summary>
            public string Category { get; set; } = default!;

            /// <summary>
            /// Cursor. Used for pagination
            /// </summary>
            public string NextPageCursor { get; set; } = default!;

            /// <summary>
            /// Object array
            /// </summary>
            public List<LinearItem> List { get; set; } = new List<LinearItem>();
        }

        public class LinearItem
        {
            /// <summary>
            /// Symbol name
            /// </summary>
            public string Symbol { get; set; } = default!;

            /// <summary>
            /// Contract type. <c>LinearPerpetual</c>, <c>LinearFutures</c>, <c>InversePerpetual</c>, <c>InverseFutures</c>
            /// </summary>
            public string ContractType { get; set; } = default!;

            /// <summary>
            /// Instrument status. <c>PreLaunch</c>, <c>Trading</c>, <c>Settling</c>, <c>Delivering</c>, <c>Closed</c>
            /// </summary>
            public string Status { get; set; } = default!;

            /// <summary>
            /// Base coin
            /// </summary>
            public string BaseCoin { get; set; } = default!;

            /// <summary>
            /// Quote coin
            /// </summary>
            public string QuoteCoin { get; set; } = default!;

            /// <summary>
            /// Launch timestamp (ms)
            /// </summary>
            public string LaunchTime { get; set; } = default!;

            /// <summary>
            /// Delivery timestamp (ms). Expired futures delivery time; Perpetual delisting time
            /// </summary>
            public string DeliveryTime { get; set; } = default!;

            /// <summary>
            /// Delivery fee rate
            /// </summary>
            public string DeliveryFeeRate { get; set; } = default!;

            /// <summary>
            /// Price scale
            /// </summary>
            public string PriceScale { get; set; } = default!;

            /// <summary>
            /// Leverage attributes
            /// </summary>
            public LinearLeverageFilter LeverageFilter { get; set; } = default!;

            /// <summary>
            /// Price attributes
            /// </summary>
            public LinearPriceFilter PriceFilter { get; set; } = default!;

            /// <summary>
            /// Size attributes
            /// </summary>
            public LinearLotSizeFilter LotSizeFilter { get; set; } = default!;

            /// <summary>
            /// Whether to support unified margin trade
            /// </summary>
            public bool? UnifiedMarginTrade { get; set; } = default!;

            /// <summary>
            /// Funding interval (minute)
            /// </summary>
            public int? FundingInterval { get; set; } = default!;

            /// <summary>
            /// Settle coin
            /// </summary>
            public string SettleCoin { get; set; } = default!;

            /// <summary>
            /// Copy trading symbol or not. <c>none</c>, <c>both</c>, <c>utaOnly</c>, <c>normalOnly</c>
            /// </summary>
            public string CopyTrading { get; set; } = default!;

            /// <summary>
            /// Upper funding rate limit
            /// </summary>
            public string UpperFundingRate { get; set; } = default!;

            /// <summary>
            /// Lower funding rate limit
            /// </summary>
            public string LowerFundingRate { get; set; } = default!;

            /// <summary>
            /// Whether the contract is a pre-market contract.
            /// When the pre-market contract is converted to official contract, it will be <c>false</c>
            /// </summary>
            public bool? IsPreListing { get; set; } = default!;

            /// <summary>
            /// Pre-listing info. If <c>isPreListing=false</c>, preListingInfo=null
            /// </summary>
            public PreListingInfo PreListingInfo { get; set; } = default!;

            /// <summary>
            /// Risk parameters
            /// </summary>
            public LinearRiskParameters RiskParameters { get; set; } = default!;

            /// <summary>
            /// Symbol type
            /// </summary>
            public string SymbolType { get; set; } = default!;
        }

        public class Inverse : Linear
        {
        }

        public class InverseItem : LinearItem
        {
        }

        #endregion

        #region Option Response

        public class Option
        {
            /// <summary>
            /// Product type
            /// </summary>
            public string Category { get; set; } = default!;

            /// <summary>
            /// Cursor. Used for pagination
            /// </summary>
            public string NextPageCursor { get; set; } = default!;

            /// <summary>
            /// Object array
            /// </summary>
            public List<OptionItem> List { get; set; } = new List<OptionItem>();
        }

        public class OptionItem
        {
            /// <summary>
            /// Symbol name
            /// </summary>
            public string Symbol { get; set; } = default!;

            /// <summary>
            /// Option type. <c>Call</c>, <c>Put</c>
            /// </summary>
            public string OptionsType { get; set; } = default!;

            /// <summary>
            /// Instrument status. <c>PreLaunch</c>, <c>Trading</c>, <c>Delivering</c>
            /// </summary>
            public string Status { get; set; } = default!;

            /// <summary>
            /// Base coin
            /// </summary>
            public string BaseCoin { get; set; } = default!;

            /// <summary>
            /// Quote coin
            /// </summary>
            public string QuoteCoin { get; set; } = default!;

            /// <summary>
            /// Settle coin
            /// </summary>
            public string SettleCoin { get; set; } = default!;

            /// <summary>
            /// Launch timestamp (ms)
            /// </summary>
            public string LaunchTime { get; set; } = default!;

            /// <summary>
            /// Delivery timestamp (ms)
            /// </summary>
            public string DeliveryTime { get; set; } = default!;

            /// <summary>
            /// Delivery fee rate
            /// </summary>
            public string DeliveryFeeRate { get; set; } = default!;

            /// <summary>
            /// Price attributes
            /// </summary>
            public OptionPriceFilter PriceFilter { get; set; } = default!;

            /// <summary>
            /// Size attributes
            /// </summary>
            public OptionLotSizeFilter LotSizeFilter { get; set; } = default!;

            /// <summary>
            /// Display name, e.g. <c>BTCUSDT-27MAR26-70000-P</c>
            /// </summary>
            public string DisplayName { get; set; } = default!;
        }

        #endregion

        #region Spot Response

        public class Spot
        {
            /// <summary>
            /// Product type
            /// </summary>
            public string Category { get; set; } = default!;

            /// <summary>
            /// Object array
            /// </summary>
            public List<SpotItem> List { get; set; } = new List<SpotItem>();
        }

        public class SpotItem
        {
            /// <summary>
            /// Symbol ID
            /// </summary>
            public int? SymbolId { get; set; } = default!;

            /// <summary>
            /// Symbol name
            /// </summary>
            public string Symbol { get; set; } = default!;

            /// <summary>
            /// Base coin
            /// </summary>
            public string BaseCoin { get; set; } = default!;

            /// <summary>
            /// Quote coin
            /// </summary>
            public string QuoteCoin { get; set; } = default!;

            /// <summary>
            /// Whether or not this is an innovation zone token. <c>0</c>: false, <c>1</c>: true
            /// </summary>
            public string Innovation { get; set; } = default!;

            /// <summary>
            /// Instrument status. <c>Trading</c>
            /// </summary>
            public string Status { get; set; } = default!;

            /// <summary>
            /// Margin trade symbol or not. <c>none</c>, <c>both</c>, <c>utaOnly</c>, <c>normalSpotOnly</c>
            /// <para>
            /// This is to identify if the symbol supports margin trading under different account modes.
            /// You may find some symbols do not support margin buy or margin sell, so you need to go to Collateral Info (UTA) to check if that coin is borrowable.
            /// </para>
            /// </summary>
            public string MarginTrading { get; set; } = default!;

            /// <summary>
            /// Special treatment label. <c>0</c>: false, <c>1</c>: true
            /// </summary>
            public string StTag { get; set; } = default!;

            /// <summary>
            /// Size attributes
            /// </summary>
            public SpotLotSizeFilter LotSizeFilter { get; set; } = default!;

            /// <summary>
            /// Price attributes
            /// </summary>
            public SpotPriceFilter PriceFilter { get; set; } = default!;

            /// <summary>
            /// Risk parameters
            /// </summary>
            public SpotRiskParameters RiskParameters { get; set; } = default!;

            /// <summary>
            /// Symbol type
            /// </summary>
            public string SymbolType { get; set; } = default!;
        }

        #endregion

        #region Full Item (union of all fields)

        public class FullItem : LinearItem
        {
            /// <summary>
            /// Option type. <c>Call</c>, <c>Put</c>
            /// </summary>
            public string OptionsType { get; set; } = default!;

            /// <summary>
            /// Whether or not this is an innovation zone token. <c>0</c>: false, <c>1</c>: true
            /// </summary>
            public string Innovation { get; set; } = default!;

            /// <summary>
            /// Margin trade symbol or not. <c>none</c>, <c>both</c>, <c>utaOnly</c>, <c>normalSpotOnly</c>
            /// </summary>
            public string MarginTrading { get; set; } = default!;

            /// <summary>
            /// Special treatment label. <c>0</c>: false, <c>1</c>: true
            /// </summary>
            public string StTag { get; set; } = default!;

            /// <summary>
            /// Display name
            /// </summary>
            public string DisplayName { get; set; } = default!;
        }

        #endregion
    }

    #region Linear/Inverse Filter Classes

    public class LinearLeverageFilter
    {
        /// <summary>
        /// Minimum leverage
        /// </summary>
        public string MinLeverage { get; set; } = default!;

        /// <summary>
        /// Maximum leverage
        /// </summary>
        public string MaxLeverage { get; set; } = default!;

        /// <summary>
        /// The step to increase/reduce leverage
        /// </summary>
        public string LeverageStep { get; set; } = default!;
    }

    public class LinearPriceFilter
    {
        /// <summary>
        /// Minimum order price
        /// </summary>
        public string MinPrice { get; set; } = default!;

        /// <summary>
        /// Maximum order price
        /// </summary>
        public string MaxPrice { get; set; } = default!;

        /// <summary>
        /// The step to increase/reduce order price
        /// </summary>
        public string TickSize { get; set; } = default!;
    }

    public class LinearLotSizeFilter
    {
        /// <summary>
        /// Maximum order quantity
        /// </summary>
        public string MaxOrderQty { get; set; } = default!;

        /// <summary>
        /// Minimum order quantity
        /// </summary>
        public string MinOrderQty { get; set; } = default!;

        /// <summary>
        /// The step to increase/reduce order quantity
        /// </summary>
        public string QtyStep { get; set; } = default!;

        /// <summary>
        /// Maximum order qty for PostOnly order
        /// </summary>
        public string PostOnlyMaxOrderQty { get; set; } = default!;

        /// <summary>
        /// Maximum order qty for Market order
        /// </summary>
        public string MaxMktOrderQty { get; set; } = default!;

        /// <summary>
        /// Minimum notional value
        /// </summary>
        public string MinNotionalValue { get; set; } = default!;
    }

    public class LinearRiskParameters
    {
        /// <summary>
        /// Price limit ratio X
        /// </summary>
        public string PriceLimitRatioX { get; set; } = default!;

        /// <summary>
        /// Price limit ratio Y
        /// </summary>
        public string PriceLimitRatioY { get; set; } = default!;
    }

    #endregion

    #region Option Filter Classes

    public class OptionPriceFilter
    {
        /// <summary>
        /// Minimum order price
        /// </summary>
        public string MinPrice { get; set; } = default!;

        /// <summary>
        /// Maximum order price
        /// </summary>
        public string MaxPrice { get; set; } = default!;

        /// <summary>
        /// The step to increase/reduce order price
        /// </summary>
        public string TickSize { get; set; } = default!;
    }

    public class OptionLotSizeFilter
    {
        /// <summary>
        /// Maximum order quantity
        /// </summary>
        public string MaxOrderQty { get; set; } = default!;

        /// <summary>
        /// Minimum order quantity
        /// </summary>
        public string MinOrderQty { get; set; } = default!;

        /// <summary>
        /// The step to increase/reduce order quantity
        /// </summary>
        public string QtyStep { get; set; } = default!;
    }

    #endregion

    #region Spot Filter Classes

    public class SpotPriceFilter
    {
        /// <summary>
        /// The step to increase/reduce order price
        /// </summary>
        public string TickSize { get; set; } = default!;
    }

    public class SpotLotSizeFilter
    {
        /// <summary>
        /// The precision of base coin
        /// </summary>
        public string BasePrecision { get; set; } = default!;

        /// <summary>
        /// The precision of quote coin
        /// </summary>
        public string QuotePrecision { get; set; } = default!;

        /// <summary>
        /// Minimum order quantity
        /// </summary>
        public string MinOrderQty { get; set; } = default!;

        /// <summary>
        /// Maximum order quantity
        /// </summary>
        public string MaxOrderQty { get; set; } = default!;

        /// <summary>
        /// Minimum order amount
        /// </summary>
        public string MinOrderAmt { get; set; } = default!;

        /// <summary>
        /// Maximum order amount
        /// </summary>
        public string MaxOrderAmt { get; set; } = default!;

        /// <summary>
        /// Maximum limit order quantity
        /// </summary>
        public string MaxLimitOrderQty { get; set; } = default!;

        /// <summary>
        /// Maximum market order quantity
        /// </summary>
        public string MaxMarketOrderQty { get; set; } = default!;

        /// <summary>
        /// Maximum limit order size for PostOnly order.
        /// For post-only and RPI orders, the maximum is 5x <c>maxLimitOrderQty</c>
        /// </summary>
        public string PostOnlyMaxLimitOrderSize { get; set; } = default!;
    }

    public class SpotRiskParameters
    {
        /// <summary>
        /// Price limit on Limit order. For example, "0.005" means 0.5%
        /// </summary>
        public string PriceLimitRatioX { get; set; } = default!;

        /// <summary>
        /// Price limit on Market order. For example, "0.01" means 1%
        /// </summary>
        public string PriceLimitRatioY { get; set; } = default!;
    }

    #endregion

    #region Pre-Listing Info Classes

    public class PreListingInfo
    {
        /// <summary>
        /// Current auction phase. <c>CallAuction</c>, <c>CallAuctionNoCancel</c>, <c>CrossMatching</c>, <c>ContinuousTrading</c>
        /// </summary>
        public string CurAuctionPhase { get; set; } = default!;

        /// <summary>
        /// Auction phase list
        /// </summary>
        public List<AuctionPhase> Phases { get; set; } = new List<AuctionPhase>();

        /// <summary>
        /// Auction fee info. There is no trading fee until entering continuous trading phase
        /// </summary>
        public AuctionFeeInfo AuctionFeeInfo { get; set; } = default!;
    }

    public class AuctionPhase
    {
        /// <summary>
        /// Phase name. <c>CallAuction</c>, <c>CallAuctionNoCancel</c>, <c>CrossMatching</c>, <c>ContinuousTrading</c>
        /// </summary>
        public string Phase { get; set; } = default!;

        /// <summary>
        /// Start time (ms)
        /// </summary>
        public string StartTime { get; set; } = default!;

        /// <summary>
        /// End time (ms)
        /// </summary>
        public string EndTime { get; set; } = default!;
    }

    public class AuctionFeeInfo
    {
        /// <summary>
        /// Auction fee rate
        /// </summary>
        public string AuctionFeeRate { get; set; } = default!;

        /// <summary>
        /// Taker fee rate
        /// </summary>
        public string TakerFeeRate { get; set; } = default!;

        /// <summary>
        /// Maker fee rate
        /// </summary>
        public string MakerFeeRate { get; set; } = default!;
    }

    #endregion

    #endregion
}