using System;
using System.Collections.Generic;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Position
{
    public class GetClosedOptionsPositionsRequest
    {
        /// <summary>
        /// Product type. <c>option</c>
        /// </summary>
        public Category? category { get; set; }

        /// <summary>
        /// Symbol name, like BTC-12JUN25-104019-C-USDT
        /// </summary>
        public string? symbol { get; set; }

        /// <summary>
        /// Base coin
        /// </summary>
        public string? baseCoin { get; set; }

        /// <summary>
        /// Expiry date
        /// </summary>
        public string? expDate { get; set; }

        /// <summary>
        /// The start timestamp in milliseconds.
        /// <para>
        /// If neither <c>startTime</c> nor <c>endTime</c> is passed, returns last 1 day by default.
        /// If only <c>startTime</c> is passed, returns data from <c>startTime</c> to <c>startTime + 1 day</c>.
        /// If both are passed, the range must be &lt;= 7 days.
        /// </para>
        /// </summary>
        public long? startTime { get; set; }

        /// <summary>
        /// The end timestamp in milliseconds.
        /// <para>
        /// If only <c>endTime</c> is passed, returns data from <c>endTime - 1 day</c> to <c>endTime</c>.
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

    public class GetClosedOptionsPositionsResponse
    {
        /// <summary>
        /// Product type (e.g., option).
        /// </summary>
        public string Category { get; set; } = default!;

        /// <summary>
        /// Cursor for pagination.
        /// <para>Use this value as the <c>cursor</c> in the next request to fetch more results.</para>
        /// </summary>
        public string? NextPageCursor { get; set; }

        /// <summary>
        /// List of closed options positions.
        /// </summary>
        public List<ClosedOptionsPositionEntry> List { get; set; } = new();

        /// <summary>
        /// Represents a single closed options position entry.
        /// </summary>
        public class ClosedOptionsPositionEntry
        {
            /// <summary>Symbol name.</summary>
            public string Symbol { get; set; } = default!;

            /// <summary>Side. Buy or Sell.</summary>
            public string Side { get; set; } = default!;

            /// <summary>Total open fee.</summary>
            public string TotalOpenFee { get; set; } = default!;

            /// <summary>Delivery fee.</summary>
            public string DeliveryFee { get; set; } = default!;

            /// <summary>Total close fee.</summary>
            public string TotalCloseFee { get; set; } = default!;

            /// <summary>Closed quantity.</summary>
            public string Qty { get; set; } = default!;

            /// <summary>Close time in milliseconds.</summary>
            public long? CloseTime { get; set; }

            /// <summary>Average exit price.</summary>
            public string AvgExitPrice { get; set; } = default!;

            /// <summary>Delivery price.</summary>
            public string DeliveryPrice { get; set; } = default!;

            /// <summary>Open time in milliseconds.</summary>
            public long? OpenTime { get; set; }

            /// <summary>Average entry price.</summary>
            public string AvgEntryPrice { get; set; } = default!;

            /// <summary>Total PnL.</summary>
            public string TotalPnl { get; set; } = default!;
        }
    }
}
