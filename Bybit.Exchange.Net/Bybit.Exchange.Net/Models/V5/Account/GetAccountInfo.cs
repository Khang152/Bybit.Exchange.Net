using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Account
{
    public class GetAccountInfoResponse
    {
        /// <summary>
        /// <value>Property <c>unifiedMarginStatus</c></value>
        /// <para>
        /// Account status
        /// </para>
        /// </summary>
        public UnifiedMarginStatus? UnifiedMarginStatus { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>marginMode</c></value>
        /// <para>
        /// ISOLATED_MARGIN, REGULAR_MARGIN, PORTFOLIO_MARGIN
        /// </para>
        /// </summary>
        public string MarginMode { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>dcpStatus</c></value>
        /// <para>
        /// Disconnected-CancelAll-Prevention status: ON, OFF
        /// </para>
        /// </summary>
        public string DcpStatus { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>timeWindow</c></value>
        /// <remarks>
        /// DCP trigger time window which user pre-set. Between [3, 300] seconds, default: 10 sec
        /// </remarks>
        /// </summary>
        public int? TimeWindow { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>smpGroup</c></value>
        /// <remarks>
        /// Depreciated, always 0. Please query Get SMP Group ID endpoint
        /// </remarks>
        /// </summary>
        public int? SmpGroup { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>isMasterTrader</c></value>
        /// <para>
        /// Whether the account is a master trader (copytrading). true, false
        /// </para>
        /// </summary>
        public bool? IsMasterTrader { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>spotHedgingStatus</c></value>
        /// <para>
        /// Whether the unified account enables Spot hedging. ON, OFF
        /// </para>
        /// </summary>
        public string SpotHedgingStatus { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>updatedTime</c></value>
        /// <para>
        /// Account data updated timestamp (ms)
        /// </para>
        /// </summary>
        public string UpdatedTime { get; set; } = default!;
    }
}