using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Position
{
    public class GetClosedPnLRequest
    {
        /// <summary>
        /// Product type.
        /// <para>UTA2.0, UTA1.0: linear (USDT Contract, USDC Contract), inverse</para>
        /// <para>Classic account: linear (USDT Perps), inverse</para>
        /// </summary>
        public Category? category { get; set; }

        /// <summary>
        /// Symbol name, like BTCUSDT, uppercase only.
        /// </summary>
        public string? symbol { get; set; }

        /// <summary>
        /// The start timestamp in milliseconds.
        /// <para>
        /// If neither <c>startTime</c> nor <c>endTime</c> is passed, returns last 7 days by default.
        /// If only <c>startTime</c> is passed, returns data from <c>startTime</c> to <c>startTime + 7 days</c>.
        /// If both are passed, the range must be &lt;= 7 days.
        /// </para>
        /// </summary>
        public long? startTime { get; set; }

        /// <summary>
        /// The end timestamp in milliseconds.
        /// <para>
        /// If only <c>endTime</c> is passed, returns data from <c>endTime - 7 days</c> to <c>endTime</c>.
        /// If both are passed, the range must be &lt;= 7 days.
        /// </para>
        /// </summary>
        public long? endTime { get; set; }

        /// <summary>
        /// Limit for data size per page. [1, 100]. Default is 50.
        /// </summary>
        public int? limit { get; set; }

        /// <summary>
        /// Cursor for pagination.
        /// <para>Use the <c>nextPageCursor</c> token from the response to get the next page.</para>
        /// </summary>
        public string? cursor { get; set; }
    }

    public class GetClosedPnLResponse
    {
        /// <summary>
        /// Product type (e.g., linear, inverse).
        /// </summary>
        public Category? Category { get; set; } = default!;

        /// <summary>
        /// List of closed PnL entries.
        /// </summary>
        public List<ClosedPnLEntry> List { get; set; } = new();

        /// <summary>
        /// Cursor for pagination.
        /// <para>Use this value as the <c>cursor</c> in the next request to fetch more results.</para>
        /// </summary>
        public string? NextPageCursor { get; set; }

        /// <summary>
        /// Represents a single closed PnL entry.
        /// </summary>
        public class ClosedPnLEntry
        {
            /// <summary>Symbol name (e.g., BTCUSDT).</summary>
            public string Symbol { get; set; } = default!;

            /// <summary>Order ID.</summary>
            public string OrderId { get; set; } = default!;

            /// <summary>Side of the order. Buy or Sell.</summary>
            public Side? Side { get; set; } = default!;

            /// <summary>Order quantity.</summary>
            public string Qty { get; set; } = default!;

            /// <summary>Order price.</summary>
            public string OrderPrice { get; set; } = default!;

            /// <summary>Order type. Market or Limit.</summary>
            public OrderType? OrderType { get; set; } = default!;

            /// <summary>
            /// Execution type.
            /// <para>Examples: Trade, BustTrade, SessionSettlePnL, Settle, MovePosition</para>
            /// </summary>
            public ExecType? ExecType { get; set; } = default!;

            /// <summary>Closed size of the position.</summary>
            public string ClosedSize { get; set; } = default!;

            /// <summary>Cumulative entry value of the position.</summary>
            public string CumEntryValue { get; set; } = default!;

            /// <summary>Average entry price.</summary>
            public string AvgEntryPrice { get; set; } = default!;

            /// <summary>Cumulative exit value of the position.</summary>
            public string CumExitValue { get; set; } = default!;

            /// <summary>Average exit price.</summary>
            public string AvgExitPrice { get; set; } = default!;

            /// <summary>Closed profit and loss.</summary>
            public string ClosedPnl { get; set; } = default!;

            /// <summary>Number of fills in the order.</summary>
            public string FillCount { get; set; } = default!;

            /// <summary>Leverage used in the position.</summary>
            public string Leverage { get; set; } = default!;

            /// <summary>Creation time in milliseconds.</summary>
            public string CreatedTime { get; set; } = default!;

            /// <summary>Last update time in milliseconds.</summary>
            public string UpdatedTime { get; set; } = default!;
        }
    }

}
