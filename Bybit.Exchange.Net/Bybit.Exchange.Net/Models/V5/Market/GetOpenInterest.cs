using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Market
{
    public class GetOpenInterestRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// | Product type:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>linear</term>
        /// <description>
        /// linear
        /// </description>
        /// </item>
        /// <item>
        /// <term>inverse</term>
        /// <description>
        /// inverse
        /// </description>
        /// </item>
        /// </list>
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
        /// <value>Property <c>intervalTime</c></value>
        /// <remarks>
        /// | Interval time:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>5min</term>
        /// <description>
        /// 5min
        /// </description>
        /// </item>
        /// <item>
        /// <term>15min</term>
        /// <description>
        /// 15min
        /// </description>
        /// </item>
        /// </list>
        /// <para>
        /// 30min, 1h, 4h, 1d
        /// </para>
        /// </summary>
        public IntervalTime? intervalTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>startTime</c></value>
        /// <para>
        /// The start timestamp (ms)
        /// </para>
        /// </summary>
        public int? startTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>endTime</c></value>
        /// <para>
        /// The end timestamp (ms)
        /// </para>
        /// </summary>
        public int? endTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <remarks>
        /// | Limit for data size per page:
        /// </remarks>
        /// <para>
        /// [1, 200]. Default: 50
        /// </para>
        /// </summary>
        public int? limit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>cursor</c></value>
        /// <para>
        /// Cursor. Used to paginate
        /// </para>
        /// </summary>
        public string cursor { get; set; } = default!;
    }

    public class GetOpenInterestResponse
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <para>
        /// Product type
        /// </para>
        /// </summary>
        public Category? Category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// Object
        /// </para>
        /// </summary>
        public List<GetOpenInterestItem> List { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>nextPageCursor</c></value>
        /// <para>
        /// Used to paginate
        /// </para>
        /// </summary>
        public string NextPageCursor { get; set; } = default!;
    }

    public class GetOpenInterestItem
    {
        /// <summary>
        /// <value>Property <c>openInterest</c></value>
        /// <para>
        /// Open interest. The value is the sum of both sides
        /// </para>
        /// </summary>
        public string OpenInterest { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>timestamp</c></value>
        /// <para>
        /// The timestamp (ms)
        /// </para>
        /// </summary>
        public string Timestamp { get; set; } = default!;
    }
}