using System;
using System.Collections.Generic;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Position
{
    public class GetMovePositionHistoryRequest
    {
        /// <summary>
        /// Product type: linear, spot, option.
        /// </summary>
        public Category? category { get; set; }

        /// <summary>
        /// Symbol name.
        /// </summary>
        public string? symbol { get; set; }

        /// <summary>
        /// Block trade ID.
        /// </summary>
        public string? blockTradeId { get; set; }

        /// <summary>
        /// Limit for data size per page. [1, 50]. Default: 20.
        /// </summary>
        public int? limit { get; set; }

        /// <summary>
        /// Cursor. Use the nextPageCursor token from the response for pagination.
        /// </summary>
        public string? cursor { get; set; }
    }

    public class GetMovePositionHistoryResponse
    {
        /// <summary>
        /// List of move position history entries.
        /// </summary>
        public List<MovePositionHistoryEntry> List { get; set; } = new();

        /// <summary>
        /// Cursor for pagination.
        /// </summary>
        public string? NextPageCursor { get; set; }

        public class MovePositionHistoryEntry
        {
            /// <summary>Block trade ID.</summary>
            public string BlockTradeId { get; set; } = default!;

            /// <summary>Product type.</summary>
            public string Category { get; set; } = default!;

            /// <summary>Order ID.</summary>
            public string OrderId { get; set; } = default!;

            /// <summary>User ID.</summary>
            public string UserId { get; set; } = default!;

            /// <summary>Symbol name.</summary>
            public string Symbol { get; set; } = default!;

            /// <summary>Side (e.g., Buy, Sell).</summary>
            public string Side { get; set; } = default!;

            /// <summary>Price.</summary>
            public string Price { get; set; } = default!;

            /// <summary>Quantity.</summary>
            public string Qty { get; set; } = default!;

            /// <summary>Execution fee.</summary>
            public string ExecFee { get; set; } = default!;

            /// <summary>Status (e.g., Filled, Processing, Rejected).</summary>
            public string Status { get; set; } = default!;

            /// <summary>Execution ID.</summary>
            public string ExecId { get; set; } = default!;

            /// <summary>Result code.</summary>
            public int? ResultCode { get; set; }

            /// <summary>Result message.</summary>
            public string ResultMessage { get; set; } = default!;

            /// <summary>Creation time in milliseconds.</summary>
            public long? CreatedAt { get; set; }

            /// <summary>Last update time in milliseconds.</summary>
            public long? UpdatedAt { get; set; }

            /// <summary>Reject party.</summary>
            public string RejectParty { get; set; } = default!;
        }
    }
}
