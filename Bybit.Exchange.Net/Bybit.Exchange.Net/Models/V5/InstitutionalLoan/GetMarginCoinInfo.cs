namespace Bybit.Exchange.Net.Models.V5.InstitutionalLoan
{
    public class GetMarginCoinInfoRequest
    {
        /// <summary>
        /// <value>Property <c>productId</c></value>
        /// <para>
        /// Product Id. If not passed, then return all products info
        /// </para>
        /// </summary>
        public string? productId { get; set; } = default!;
    }


    public class GetMarginCoinInfoResponse
    {
        /// <summary>
        /// <value>Property <c>marginToken</c></value>
        /// <para>
        /// Array of margin tokens.
        /// </para>
        /// </summary>
        public MarginTokenItem[] MarginToken { get; set; } = default!;

        public class MarginTokenItem
        {
            /// <summary>
            /// <value>Property <c>productId</c></value>
            /// <para>
            /// Product Id
            /// </para>
            /// </summary>
            public string ProductId { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>tokenInfo</c></value>
            /// <para>
            /// Array of Spot margin coins.
            /// </para>
            /// </summary>
            public TokenInfoItem[] TokenInfo { get; set; } = default!;
        }

        public class TokenInfoItem
        {
            /// <summary>
            /// <value>Property <c>token</c></value>
            /// <para>
            /// Margin coin
            /// </para>
            /// </summary>
            public string Token { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>convertRatioList</c></value>
            /// <para>
            /// Array of Margin coin convert ratio List.
            /// </para>
            /// </summary>
            public ConvertRatioListItem[] ConvertRatioList { get; set; } = default!;
        }

        public class ConvertRatioListItem
        {
            /// <summary>
            /// <value>Property <c>ladder</c></value>
            /// <para>
            /// ladder
            /// </para>
            /// </summary>
            public string Ladder { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>convertRatio</c></value>
            /// <para>
            /// Margin coin convert ratio
            /// </para>
            /// </summary>
            public string ConvertRatio { get; set; } = default!;
        }
    }
}
