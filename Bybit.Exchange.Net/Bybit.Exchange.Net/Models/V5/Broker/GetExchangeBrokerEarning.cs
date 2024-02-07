using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Broker
{
    public class GetExchangeBrokerEarningRequest
    {
        /// <summary>
        /// <value>Property <c>bizType</c></value>
        /// <para>
        /// Business type.
        /// </para>
        /// </summary>
        public BizType? bizType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>begin</c></value>
        /// <para>
        /// Begin date, in the format of YYYYMMDD, e.g., 20231201,
        /// search the data from 1st Dec 2023 00:00:00 UTC (include)
        /// </para>
        /// </summary>
        public string begin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>end</c></value>
        /// <para>
        /// End date, in the format of YYYYMMDD, e.g., 20231201,
        /// search the data before 2nd Dec 2023 00:00:00 UTC (exclude)
        /// </para>
        /// </summary>
        public string end { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>uid</c></value>
        /// <para>
        /// To get results for a specific sub-account: Enter the sub-account UID
        /// </para>
        /// <para>
        /// To get results for all sub-accounts: Leave the field empty
        /// </para>
        /// </summary>
        public string uid { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <remarks>
        /// Limit for data size per page. [1, 1000]. Default: 1000
        /// </remarks>
        /// </summary>
        public int? limit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>cursor</c></value>
        /// <para>
        /// Cursor. Use the nextPageCursor token from the response to retrieve the next page of the result set
        /// </para>
        /// </summary>
        public string cursor { get; set; } = default!;
    }

    public class GetExchangeBrokerEarningResponse
    {
        /// <summary>
        /// <value>Property <c>totalEarningCat</c></value>
        /// <para>
        /// Category statistics for total earning data
        /// </para>
        /// </summary>
        public TotalEarningCat TotalEarningCat { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>details</c></value>
        /// <para>
        /// Detailed trading information for each sub UID and each category
        /// </para>
        /// </summary>
        public List<ExchangeBrokerEarningDetail>? Details { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>nextPageCursor</c></value>
        /// <para>
        /// Refer to the cursor request parameter
        /// </para>
        /// </summary>
        public string NextPageCursor { get; set; } = default!;
    }

    public class TotalEarningCat
    {
        /// <summary>
        /// <value>Property <c>spot</c></value>
        /// <para>
        /// Earning for Spot trading. If do not have any rebate, keep empty array
        /// </para>
        /// </summary>
        public List<RebateItem>? Spot { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>derivatives</c></value>
        /// <para>
        /// Earning for Derivatives trading. If do not have any rebate, keep empty array
        /// </para>
        /// </summary>
        public List<RebateItem>? Derivatives { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>options</c></value>
        /// <para>
        /// Earning for Option trading. If do not have any rebate, keep empty array
        /// </para>
        /// </summary>
        public List<RebateItem>? Options { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>total</c></value>
        /// <para>
        /// Sum earnings of all categories. If do not have any rebate, keep empty array
        /// </para>
        /// </summary>
        public List<RebateItem>? Total { get; set; } = default!;
    }

    public class RebateItem
    {
        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <para>
        /// Rebate coin name
        /// </para>
        /// </summary>
        public string Coin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>earning</c></value>
        /// <para>
        /// Rebate amount of the coin
        /// </para>
        /// </summary>
        public string Earning { get; set; } = default!;
    }

    public class ExchangeBrokerEarningDetail
    {
        /// <summary>
        /// <value>Property <c>userId</c></value>
        /// <para>
        /// Sub UID
        /// </para>
        /// </summary>
        public string UserId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>bizType</c></value>
        /// <para>
        /// Business type. SPOT, DERIVATIVES, OPTIONS
        /// </para>
        /// </summary>
        public BizType? BizType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <para>
        /// Rebate coin name
        /// </para>
        /// </summary>
        public string Coin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>earning</c></value>
        /// <para>
        /// Rebate amount
        /// </para>
        /// </summary>
        public string Earning { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>markupEarning</c></value>
        /// <para>
        /// Earning generated from markup fee rate
        /// </para>
        /// </summary>
        public string MarkupEarning { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseFeeEarning</c></value>
        /// <para>
        /// Earning generated from base fee rate
        /// </para>
        /// </summary>
        public string BaseFeeEarning { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// Order ID
        /// </para>
        /// </summary>
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>execTime</c></value>
        /// <para>
        /// Order execution timestamp (ms)
        /// </para>
        /// </summary>
        public string ExecTime { get; set; } = default!;
    }
}