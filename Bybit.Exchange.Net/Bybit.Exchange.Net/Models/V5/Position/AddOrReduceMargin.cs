using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Position
{
    public class AddOrReduceMarginRequest
    {
        /// <summary>
        /// Product type.
        /// <para>UTA2.0, UTA1.0: linear, inverse</para>
        /// <para>Classic account: linear, inverse</para>
        /// </summary>
        public Category category { get; set; }

        /// <summary>
        /// Symbol name, like BTCUSDT, uppercase only.
        /// </summary>
        public string symbol { get; set; } = string.Empty;

        /// <summary>
        /// Add or reduce margin.  
        /// Positive = add (e.g. 10), Negative = reduce (e.g. -10).  
        /// Supports up to 4 decimal places.
        /// </summary>
        public string margin { get; set; } = string.Empty;

        /// <summary>
        /// Used to identify positions in different position modes. Required for hedge mode positions.
        /// <para>0 = one-way mode</para>
        /// <para>1 = hedge-mode Buy side</para>
        /// <para>2 = hedge-mode Sell side</para>
        /// </summary>
        public int? positionIdx { get; set; }
    }

    public class AddOrReduceMarginResponse
    {
        /// <summary>
        /// Product type.
        /// </summary>
        public Category? Category { get; set; }

        /// <summary>
        /// Symbol name.
        /// </summary>
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// Position index, used to identify positions in different position modes.
        /// <para>0 = One-Way Mode</para>
        /// <para>1 = Buy side of hedge mode</para>
        /// <para>2 = Sell side of hedge mode</para>
        /// </summary>
        public PositionIdx? PositionIdx { get; set; }

        /// <summary>
        /// Risk limit ID.
        /// </summary>
        public int? RiskId { get; set; }

        /// <summary>
        /// Risk limit value.
        /// </summary>
        public string RiskLimitValue { get; set; } = string.Empty;

        /// <summary>
        /// Position size.
        /// </summary>
        public string Size { get; set; } = string.Empty;

        /// <summary>
        /// Average entry price.
        /// </summary>
        public string AvgPrice { get; set; } = string.Empty;

        /// <summary>
        /// Liquidation price.
        /// </summary>
        public string LiqPrice { get; set; } = string.Empty;

        /// <summary>
        /// Bankruptcy price.
        /// </summary>
        public string BustPrice { get; set; } = string.Empty;

        /// <summary>
        /// Last mark price.
        /// </summary>
        public string MarkPrice { get; set; } = string.Empty;

        /// <summary>
        /// Position value.
        /// </summary>
        public string PositionValue { get; set; } = string.Empty;

        /// <summary>
        /// Position leverage.
        /// </summary>
        public string Leverage { get; set; } = string.Empty;

        /// <summary>
        /// Whether to add margin automatically.
        /// <para>0 = false</para>
        /// <para>1 = true</para>
        /// </summary>
        public int? AutoAddMargin { get; set; }

        /// <summary>
        /// Position status.
        /// <para>Normal, Liq, Adl</para>
        /// </summary>
        public string PositionStatus { get; set; } = string.Empty;

        /// <summary>
        /// Initial margin.
        /// </summary>
        public string PositionIM { get; set; } = string.Empty;

        /// <summary>
        /// Maintenance margin.
        /// </summary>
        public string PositionMM { get; set; } = string.Empty;

        /// <summary>
        /// Take profit price.
        /// </summary>
        public string TakeProfit { get; set; } = string.Empty;

        /// <summary>
        /// Stop loss price.
        /// </summary>
        public string StopLoss { get; set; } = string.Empty;

        /// <summary>
        /// Trailing stop distance from market price.
        /// </summary>
        public string TrailingStop { get; set; } = string.Empty;

        /// <summary>
        /// Unrealised PnL.
        /// </summary>
        public string UnrealisedPnl { get; set; } = string.Empty;

        /// <summary>
        /// Cumulative realised PnL.
        /// </summary>
        public string CumRealisedPnl { get; set; } = string.Empty;

        /// <summary>
        /// Timestamp of the first time a position was created on this symbol (ms).
        /// </summary>
        public string CreatedTime { get; set; } = string.Empty;

        /// <summary>
        /// Position updated timestamp (ms).
        /// </summary>
        public string UpdatedTime { get; set; } = string.Empty;
    }
}
