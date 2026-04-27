using System.Collections.Generic;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Market
{
    #region Request

    /// <summary>
    /// Request parameters for Get Instruments Info
    /// <para>
    /// <see href="https://bybit-exchange.github.io/docs/v5/market/instrument"/>
    /// </para>
    /// </summary>
    public class GetInstrumentsInfoRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <para>
        /// <b>Required</b>. Product type: <c>spot</c>, <c>linear</c>, <c>inverse</c>, <c>option</c>
        /// </para>
        /// </summary>
        public Category category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name, like BTCUSDT, uppercase only. Either symbol or baseCoin is required
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbolType</c></value>
        /// <para>
        /// Symbol type filter. Applies to <c>linear</c>, <c>inverse</c>, <c>spot</c> only
        /// </para>
        /// </summary>
        public string symbolType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>status</c></value>
        /// <para>
        /// Symbol status filter
        /// </para>
        /// <remarks>
        /// | linear &amp; inverse &amp; spot: By default returns only <c>Trading</c> symbols
        /// | option: By default returns <c>PreLaunch</c>, <c>Trading</c>, and <c>Delivering</c>
        /// | Spot has <c>Trading</c> only
        /// | linear &amp; inverse: when status=PreLaunch, it returns Pre-Market contracts
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
        /// <remarks>
        /// | Spot does not support pagination, so <c>limit</c> is invalid
        /// </remarks>
        /// </summary>
        public int? limit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>cursor</c></value>
        /// <para>
        /// Cursor. Use the <c>nextPageCursor</c> token from the response to retrieve the next page of the result set
        /// </para>
        /// <remarks>
        /// | Spot does not support pagination, so <c>cursor</c> is invalid
        /// </remarks>
        /// </summary>
        public string cursor { get; set; } = default!;
    }

    #endregion

    #region Response

    /// <summary>
    /// Response for Get Instruments Info
    /// <para>
    /// <see href="https://bybit-exchange.github.io/docs/v5/market/instrument"/>
    /// </para>
    /// </summary>
    public class GetInstrumentsInfoResponse
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
        /// Object array. Union of all category fields
        /// </summary>
        public List<InstrumentItem> List { get; set; } = new List<InstrumentItem>();
    }

    /// <summary>
    /// Instrument item — union of Linear/Inverse, Option, and Spot fields.
    /// Fields that do not apply to the current category will be null.
    /// </summary>
    public class InstrumentItem
    {
        #region Common fields (all categories)

        /// <summary>
        /// Symbol name
        /// </summary>
        public string Symbol { get; set; } = default!;

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
        /// Symbol type
        /// </summary>
        public string SymbolType { get; set; } = default!;

        #endregion

        #region Linear / Inverse fields

        /// <summary>
        /// Contract type. <c>LinearPerpetual</c>, <c>LinearFutures</c>, <c>InversePerpetual</c>, <c>InverseFutures</c>
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public string ContractType { get; set; } = default!;

        /// <summary>
        /// Launch timestamp (ms)
        /// <para>Applies to linear/inverse/option</para>
        /// </summary>
        public string LaunchTime { get; set; } = default!;

        /// <summary>
        /// Delivery timestamp (ms). Expired futures delivery time; Perpetual delisting time
        /// <para>Applies to linear/inverse/option</para>
        /// </summary>
        public string DeliveryTime { get; set; } = default!;

        /// <summary>
        /// Delivery fee rate
        /// <para>Applies to linear/inverse/option</para>
        /// </summary>
        public string DeliveryFeeRate { get; set; } = default!;

        /// <summary>
        /// Price scale
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public string PriceScale { get; set; } = default!;

        /// <summary>
        /// Leverage attributes
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public LeverageFilter LeverageFilter { get; set; } = default!;

        /// <summary>
        /// Price attributes
        /// <para>Applies to all categories</para>
        /// </summary>
        public PriceFilter PriceFilter { get; set; } = default!;

        /// <summary>
        /// Size attributes
        /// <para>Applies to all categories</para>
        /// </summary>
        public LotSizeFilter LotSizeFilter { get; set; } = default!;

        /// <summary>
        /// Whether to support unified margin trade
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public bool? UnifiedMarginTrade { get; set; } = default!;

        /// <summary>
        /// Funding interval (minute)
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public int? FundingInterval { get; set; } = default!;

        /// <summary>
        /// Settle coin
        /// <para>Applies to linear/inverse/option</para>
        /// </summary>
        public string SettleCoin { get; set; } = default!;

        /// <summary>
        /// Copy trading symbol or not. <c>none</c>, <c>both</c>, <c>utaOnly</c>, <c>normalOnly</c>
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public string CopyTrading { get; set; } = default!;

        /// <summary>
        /// Upper funding rate limit
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public string UpperFundingRate { get; set; } = default!;

        /// <summary>
        /// Lower funding rate limit
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public string LowerFundingRate { get; set; } = default!;

        /// <summary>
        /// Whether the contract is a pre-market contract.
        /// When the pre-market contract is converted to official contract, it will be <c>false</c>
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public bool? IsPreListing { get; set; } = default!;

        /// <summary>
        /// Pre-listing info. If <c>isPreListing=false</c>, preListingInfo=null
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public PreListingInfo PreListingInfo { get; set; } = default!;

        /// <summary>
        /// Risk parameters
        /// <para>Applies to linear/inverse/spot</para>
        /// </summary>
        public RiskParameters RiskParameters { get; set; } = default!;

        #endregion

        #region Option fields

        /// <summary>
        /// Option type. <c>Call</c>, <c>Put</c>
        /// <para>Applies to option only</para>
        /// </summary>
        public string OptionsType { get; set; } = default!;

        /// <summary>
        /// Display name, e.g. <c>BTCUSDT-27MAR26-70000-P</c>
        /// <para>Applies to option only</para>
        /// </summary>
        public string DisplayName { get; set; } = default!;

        #endregion

        #region Spot fields

        /// <summary>
        /// Symbol ID
        /// <para>Applies to spot only</para>
        /// </summary>
        public int? SymbolId { get; set; } = default!;

        /// <summary>
        /// Whether or not this is an innovation zone token. <c>0</c>: false, <c>1</c>: true
        /// <para>Applies to spot only</para>
        /// </summary>
        public string Innovation { get; set; } = default!;

        /// <summary>
        /// Margin trade symbol or not. <c>none</c>, <c>both</c>, <c>utaOnly</c>, <c>normalSpotOnly</c>
        /// <para>
        /// This is to identify if the symbol supports margin trading under different account modes.
        /// You may find some symbols do not support margin buy or margin sell, so you need to go to Collateral Info (UTA) to check if that coin is borrowable.
        /// </para>
        /// <para>Applies to spot only</para>
        /// </summary>
        public string MarginTrading { get; set; } = default!;

        /// <summary>
        /// Special treatment label. <c>0</c>: false, <c>1</c>: true
        /// <para>Applies to spot only</para>
        /// </summary>
        public string StTag { get; set; } = default!;

        #endregion
    }

    #region Filter Classes

    /// <summary>
    /// Leverage filter (linear/inverse)
    /// </summary>
    public class LeverageFilter
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

    /// <summary>
    /// Price filter (all categories)
    /// </summary>
    public class PriceFilter
    {
        /// <summary>
        /// Minimum order price
        /// <para>Applies to linear/inverse/option</para>
        /// </summary>
        public string MinPrice { get; set; } = default!;

        /// <summary>
        /// Maximum order price
        /// <para>Applies to linear/inverse/option</para>
        /// </summary>
        public string MaxPrice { get; set; } = default!;

        /// <summary>
        /// The step to increase/reduce order price
        /// </summary>
        public string TickSize { get; set; } = default!;
    }

    /// <summary>
    /// Lot size filter (all categories — union of linear/inverse, option, and spot fields)
    /// </summary>
    public class LotSizeFilter
    {
        #region Common

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
        /// <para>Applies to linear/inverse/option</para>
        /// </summary>
        public string QtyStep { get; set; } = default!;

        #endregion

        #region Linear / Inverse

        /// <summary>
        /// Maximum order qty for Market order
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public string MaxMktOrderQty { get; set; } = default!;

        /// <summary>
        /// Minimum notional value
        /// <para>Applies to linear/inverse only</para>
        /// </summary>
        public string MinNotionalValue { get; set; } = default!;

        #endregion

        #region Spot

        /// <summary>
        /// The precision of base coin
        /// <para>Applies to spot only</para>
        /// </summary>
        public string BasePrecision { get; set; } = default!;

        /// <summary>
        /// The precision of quote coin
        /// <para>Applies to spot only</para>
        /// </summary>
        public string QuotePrecision { get; set; } = default!;

        /// <summary>
        /// Minimum order amount
        /// <para>Applies to spot only</para>
        /// </summary>
        public string MinOrderAmt { get; set; } = default!;

        /// <summary>
        /// Maximum order amount
        /// <para>Applies to spot only</para>
        /// </summary>
        public string MaxOrderAmt { get; set; } = default!;

        /// <summary>
        /// Maximum limit order quantity
        /// <para>Applies to spot only</para>
        /// </summary>
        public string MaxLimitOrderQty { get; set; } = default!;

        /// <summary>
        /// Maximum market order quantity
        /// <para>Applies to spot only</para>
        /// </summary>
        public string MaxMarketOrderQty { get; set; } = default!;

        /// <summary>
        /// Maximum limit order size for PostOnly order.
        /// For post-only and RPI orders, the maximum is 5x <c>maxLimitOrderQty</c>
        /// <para>Applies to spot only</para>
        /// </summary>
        public string PostOnlyMaxLimitOrderSize { get; set; } = default!;

        #endregion
    }

    /// <summary>
    /// Risk parameters (linear/inverse/spot)
    /// </summary>
    public class RiskParameters
    {
        /// <summary>
        /// Price limit ratio X. For spot: price limit on Limit order (e.g. "0.005" means 0.5%)
        /// </summary>
        public string PriceLimitRatioX { get; set; } = default!;

        /// <summary>
        /// Price limit ratio Y. For spot: price limit on Market order (e.g. "0.01" means 1%)
        /// </summary>
        public string PriceLimitRatioY { get; set; } = default!;
    }

    #endregion

    #region Pre-Listing Info Classes

    /// <summary>
    /// Pre-listing info for pre-market contracts
    /// </summary>
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

    /// <summary>
    /// Auction phase detail
    /// </summary>
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

    /// <summary>
    /// Auction fee info
    /// </summary>
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