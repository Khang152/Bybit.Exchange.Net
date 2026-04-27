using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Position
{
    public class GetPositionInfoRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// | Product type:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>Unified account</term>
        /// <description>
        /// linear, inverse, option
        /// </description>
        /// </item>
        /// <item>
        /// <term>Classic account</term>
        /// <description>
        /// linear, inverse
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        public Category? category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <remarks>
        /// If symbol passed, it returns data regardless of having position or not.
        /// If symbol=null and settleCoin specified, it returns position size greater than zero.
        /// </remarks>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseCoin</c></value>
        /// <remarks>
        /// Base coin. option only. Return all option positions if not passed
        /// </remarks>
        /// </summary>
        public string baseCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>settleCoin</c></value>
        /// <remarks>
        /// For linear, either symbol or settleCoin is required. symbol has a higher priority
        /// </remarks>
        /// </summary>
        public string settleCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <remarks>
        /// Limit for data size per page. [1, 200]. Default: 20
        /// </remarks>
        /// </summary>
        public int? limit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>cursor</c></value>
        /// <remarks>
        /// Cursor. Use the nextPageCursor token from the response to retrieve the next page of the result set
        /// </remarks>
        /// </summary>
        public string cursor { get; set; } = default!;
    }

    public class GetPositionInfoResponse
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <para>
        /// Product type
        /// </para>
        /// </summary>
        public string Category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// Position information list
        /// </para>
        /// </summary>
        public List<PositionInfoItem> List { get; set; } = default!;
    }

    public class PositionInfoItem
    {
        /// <summary>
        /// <value>Property <c>positionIdx</c></value>
        /// <remarks>
        /// Position idx, used to identify positions in different position modes
        /// </remarks>
        /// <para>
        /// 0: One-Way Mode
        /// 1: Buy side of both side mode
        /// 2: Sell side of both side mode
        /// </para>
        /// </summary>
        public int? PositionIdx { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>riskId</c></value>
        /// <para>
        /// Risk limit ID. Note: for portfolio margin mode, this field returns 0, which means risk limit rules are invalid
        /// </para>
        /// </summary>
        public int? RiskId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>riskLimitValue</c></value>
        /// <para>
        /// Risk limit value. Note: for portfolio margin mode, this field returns 0, which means risk limit rules are invalid
        /// </para>
        /// </summary>
        public string RiskLimitValue { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>side</c></value>
        /// <para>
        /// Position side. Buy: long, Sell: short
        /// </para>
        /// </summary>
        public string Side { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>size</c></value>
        /// <para>
        /// Position size
        /// </para>
        /// </summary>
        public string Size { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>avgPrice</c></value>
        /// <para>
        /// Average entry price
        /// </para>
        /// </summary>
        public string AvgPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>positionValue</c></value>
        /// <para>
        /// Position value
        /// </para>
        /// </summary>
        public string PositionValue { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>tradeMode</c></value>
        /// <para>
        /// Trade mode
        /// </para>
        /// </summary>
        public int? TradeMode { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>autoAddMargin</c></value>
        /// <para>
        /// Whether to add margin automatically. 0: false, 1: true. For UTA, it is meaningful only when UTA enables ISOLATED_MARGIN
        /// </para>
        /// </summary>
        public int? AutoAddMargin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>positionStatus</c></value>
        /// <para>
        /// Position status. Normal, Liq, Adl
        /// </para>
        /// </summary>
        public string PositionStatus { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>leverage</c></value>
        /// <para>
        /// Position leverage. Valid for contract. Note: for portfolio margin mode, this field returns "", which means leverage rules are invalid
        /// </para>
        /// </summary>
        public string Leverage { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>breakEvenPrice</c></value>
        /// <para>
        /// Break even price, Only for linear, inverse.
        /// </para>
        /// </summary>
        public string BreakEvenPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>markPrice</c></value>
        /// <para>
        /// Last mark price
        /// </para>
        /// </summary>
        public string MarkPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>liqPrice</c></value>
        /// <para>
        /// Position liquidation price
        /// </para>
        /// </summary>
        public string LiqPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>bustPrice</c></value>
        /// <para>
        /// Bankruptcy price. Note: Unified mode returns "", no position bankruptcy price (exclude inverse trade under UTA)
        /// </para>
        /// </summary>
        public string BustPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>positionIM</c></value>
        /// <para>
        /// Initial margin. For portfolio margin mode, it returns ""
        /// </para>
        /// </summary>
        public string PositionIM { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>positionIMByMp</c></value>
        /// <para>
        /// Initial margin calculated by mark price, the same value as positionIM
        /// </para>
        /// </summary>
        public string PositionIMByMp { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>positionMM</c></value>
        /// <para>
        /// Maintenance margin. For portfolio margin mode, it returns ""
        /// </para>
        /// </summary>
        public string PositionMM { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>positionMMByMp</c></value>
        /// <para>
        /// Maintenance margin calculated by mark price, the same value as positionMM
        /// </para>
        /// </summary>
        public string PositionMMByMp { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>positionBalance</c></value>
        /// <para>
        /// Position margin
        /// </para>
        /// </summary>
        public string PositionBalance { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>tpslMode</c></value>
        /// <para>
        /// Depreciated, meaningless here, always "Full". Spot does not return this field. Option returns ""
        /// </para>
        /// </summary>
        public string TpSlMode { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>takeProfit</c></value>
        /// <para>
        /// Take profit price
        /// </para>
        /// </summary>
        public string TakeProfit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>stopLoss</c></value>
        /// <para>
        /// Stop loss price
        /// </para>
        /// </summary>
        public string StopLoss { get; set; } = default!;


        /// <summary>
        /// <value>Property <c>trailingStop</c></value>
        /// <para>
        /// Trailing stop (The distance from market price)
        /// </para>
        /// </summary>
        public string TrailingStop { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>sessionAvgPrice</c></value>
        /// <para>
        /// USDC contract session avg price, it is the same figure as avg entry price shown in the web UI
        /// </para>
        /// </summary>
        public string SessionAvgPrice { get; set; } = default!;


        /// <summary>
        /// <value>Property <c>delta</c></value>
        /// <para>
        /// Delta, unique field for option
        /// </para>
        /// </summary>
        public string Delta { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>gamma</c></value>
        /// <para>
        /// Gamma, unique field for option
        /// </para>
        /// </summary>
        public string Gamma { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>vega</c></value>
        /// <para>
        /// Vega, unique field for option
        /// </para>
        /// </summary>
        public string Vega { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>theta</c></value>
        /// <para>
        /// Theta, unique field for option
        /// </para>
        /// </summary>
        public string Theta { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>unrealisedPnl</c></value>
        /// <para>
        /// Unrealised PnL
        /// </para>
        /// </summary>
        public string UnrealisedPnl { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>curRealisedPnl</c></value>
        /// <para>
        /// The realised PnL for the current holding position
        /// </para>
        /// </summary>
        public string CurRealisedPnl { get; set; } = default!;


        /// <summary>
        /// <value>Property <c>cumRealisedPnl</c></value>
        /// <para>
        /// Cumulative realised pnl
        /// </para>
        /// </summary>
        public string CumRealisedPnl { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>adlRankIndicator</c></value>
        /// <para>
        /// Auto-deleverage rank indicator. What is Auto-Deleveraging?
        /// </para>
        /// </summary>
        public int? AdlRankIndicator { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>isReduceOnly</c></value>
        /// <para>
        /// Useful when Bybit lower the risk limit
        /// </para>
        /// <para>
        /// true: Only allowed to reduce the position. You can consider a series of measures, e.g., lower the risk limit, decrease leverage or reduce the position, add margin, or cancel orders, after these operations, you can call confirm new risk limit endpoint to check if your position can be removed the reduceOnly mark
        /// </para>
        /// <para>
        /// false: There is no restriction, and it means your position is under the risk when the risk limit is systematically adjusted
        /// </para>
        /// <para>
        /// Only meaningful for isolated margin &amp; cross margin of USDT Perp, USDC Perp, USDC Futures, Inverse Perp and Inverse Futures, meaningless for others
        /// </para>
        /// </summary>
        public bool? IsReduceOnly { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>mmrSysUpdatedTime</c></value>
        /// <para>
        /// Useful when Bybit lower the risk limit
        /// </para>
        /// <para>
        /// When isReduceOnly=true: the timestamp (ms) when the MMR will be forcibly adjusted by the system
        /// </para>
        /// <para>
        /// When isReduceOnly=false: the timestamp when the MMR had been adjusted by system
        /// </para>
        /// <para>
        /// It returns the timestamp when the system operates, and if you manually operate, there is no timestamp
        /// </para>
        /// <para>
        /// Keeps "" by default, if there was a lower risk limit system adjustment previously, it shows that system operation timestamp
        /// </para>
        /// <para>
        /// Only meaningful for isolated margin &amp; cross margin of USDT Perp, USDC Perp, USDC Futures, Inverse Perp and Inverse Futures, meaningless for others
        /// </para>
        /// </summary>
        public string MmrSysUpdatedTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>leverageSysUpdatedTime</c></value>
        /// <para>
        /// Useful when Bybit lower the risk limit
        /// </para>
        /// <para>
        /// When isReduceOnly=true: the timestamp (ms) when the leverage will be forcibly adjusted by the system
        /// </para>
        /// <para>
        /// When isReduceOnly=false: the timestamp when the leverage had been adjusted by system
        /// </para>
        /// <para>
        /// It returns the timestamp when the system operates, and if you manually operate, there is no timestamp
        /// </para>
        /// <para>
        /// Keeps "" by default, if there was a lower risk limit system adjustment previously, it shows that system operation timestamp
        /// </para>
        /// <para>
        /// Only meaningful for isolated margin &amp; cross margin of USDT Perp, USDC Perp, USDC Futures, Inverse Perp and Inverse Futures, meaningless for others
        /// </para>
        /// </summary>
        public string LeverageSysUpdatedTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>createdTime</c></value>
        /// <para>
        /// Timestamp of the first time a position was created on this symbol (ms)
        /// </para>
        /// </summary>
        public string CreatedTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>updatedTime</c></value>
        /// <para>
        /// Position updated timestamp (ms)
        /// </para>
        /// </summary>
        public string UpdatedTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>openTime</c></value>
        /// <para>
        /// Position open timestamp (ms), default: 0 (testnet only)
        /// </para>
        /// </summary>
        public string OpenTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>seq</c></value>
        /// <para>
        /// Cross sequence, used to associate each fill and each position update
        /// </para>
        /// <para>
        /// Different symbols may have the same seq, please use seq + symbol to check unique
        /// </para>
        /// <para>
        /// Returns "-1" if the symbol has never been traded
        /// </para>
        /// <para>
        /// Returns the seq updated by the last transaction when there are settings like leverage, risk limit
        /// </para>
        /// </summary>
        public long? Seq { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>nextPageCursor</c></value>
        /// <para>
        /// Refer to the cursor request parameter
        /// </para>
        /// </summary>
        public string NextPageCursor { get; set; } = default!;
    }
}
