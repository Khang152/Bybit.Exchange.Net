using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Market
{
    public class GetLongShortRatioRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// | Product type:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>linear(USDT Perpetual)</term>
        /// </item>
        /// <item>
        /// <term>inverse</term>
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
        /// <value>Property <c>period</c></value>
        /// <para>
        /// Data recording period. 5min, 15min, 30min, 1h, 4h, 1d
        /// </para>
        /// </summary>
        public DataRecordingPeriod? period { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <para>
        /// Limit for data size per page. [1, 500]. Default: 50
        /// </para>
        /// </summary>
        public int? limit { get; set; } = default!;
    }

    public class GetLongShortRatioResponse
    {
        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// Object
        /// </para>
        /// </summary>
        public List<GetLongShortRatioItem> List { get; set; } = default!;
    }

    /// <summary>
    /// ListItem class for GetLongShortRatioResponse
    /// </summary>
    public class GetLongShortRatioItem
    {
        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>buyRatio</c></value>
        /// <para>
        /// The ratio of users with net long position
        /// </para>
        /// </summary>
        public string BuyRatio { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>sellRatio</c></value>
        /// <para>
        /// The ratio of users with net short position
        /// </para>
        /// </summary>
        public string SellRatio { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>timestamp</c></value>
        /// <para>
        /// Timestamp (ms)
        /// </para>
        /// </summary>
        public string Timestamp { get; set; } = default!;
    }
}