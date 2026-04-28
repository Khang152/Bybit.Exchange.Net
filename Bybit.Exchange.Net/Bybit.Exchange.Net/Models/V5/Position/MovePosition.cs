using System;
using System.Collections.Generic;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Position
{
    public class MovePositionRequest
    {
        /// <summary>
        /// From UID (Must be a Unified Trading Account).
        /// </summary>
        public string fromUid { get; set; } = default!;

        /// <summary>
        /// To UID (Must be a Unified Trading Account).
        /// </summary>
        public string toUid { get; set; } = default!;

        /// <summary>
        /// Object containing position details. Up to 25 legs per request.
        /// </summary>
        public List<MovePositionEntry> list { get; set; } = new();

        /// <summary>
        /// Represents a single leg of the position move.
        /// </summary>
        public class MovePositionEntry
        {
            /// <summary>
            /// Product type: linear, spot, option, or inverse.
            /// </summary>
            public Category category { get; set; }

            /// <summary>
            /// Symbol name (e.g., BTCUSDT). Must be uppercase.
            /// </summary>
            public string symbol { get; set; } = default!;

            /// <summary>
            /// Trade price. (Linear/Inverse: must be within 95%-105% of mark price; Spot/Option: must follow price rules).
            /// </summary>
            public string price { get; set; } = default!;

            /// <summary>
            /// Trading side from the fromUid perspective (e.g., Sell if fromUid holds a long).
            /// </summary>
            public Side side { get; set; }

            /// <summary>
            /// Executed quantity. Must satisfy the quantity rule from Instruments Info.
            /// </summary>
            public string qty { get; set; } = default!;
        }
    }

    public class MovePositionResponse
    {
        /// <summary>
        /// The unique ID for the block trade created by the move position request.
        /// </summary>
        public string BlockTradeId { get; set; } = default!;

        /// <summary>
        /// The status of the block trade (e.g., "Processing", "Rejected").
        /// </summary>
        public string Status { get; set; } = default!;

        /// <summary>
        /// Indicates which party rejected the trade if the status is "Rejected" (e.g., "Taker", "Maker", or "bybit").
        /// </summary>
        public string RejectParty { get; set; } = default!;
    }
}
