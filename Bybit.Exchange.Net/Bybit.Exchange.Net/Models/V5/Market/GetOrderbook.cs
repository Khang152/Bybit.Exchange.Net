using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Market
{
    public class GetOrderbookRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// Product type:
        /// spot, linear, inverse, option
        /// </remarks>
        /// </summary>
        public Category? category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <para>
        /// Limit size for each bid and ask
        /// </para>
        /// </summary>
        public int? limit { get; set; } = default!;
    }

    public class GetOrderbookResponse
    {
        /// <summary>
        /// <value>Property <c>s</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string S { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>b</c></value>
        /// <para>
        /// Bid, buyer. Sort by price desc
        /// </para>
        /// </summary>
        public string[][] B { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>a</c></value>
        /// <para>
        /// Ask, seller. Order by price asc
        /// </para>
        /// </summary>
        public string[][] A { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ts</c></value>
        /// <para>
        /// The timestamp (ms) that the system generates the data
        /// </para>
        /// </summary>
        public double? TS { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>u</c></value>
        /// <para>
        /// Update ID, is always in sequence
        /// </para>
        /// <para>
        /// For contract, it is corresponding to u in the wss 200-level orderbook
        /// </para>
        /// <para>
        /// For spot, it is corresponding to u in the wss 200-level orderbook
        /// </para>
        /// </summary>
        public double? U { get; set; } = default!;
    }
}