namespace Bybit.Exchange.Net.Models.V5.InstitutionalLoan
{
    public class GetUnpaidLoansRequest
    {
        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>Loan order ID</para>
        /// </summary>
        public string? orderId { get; set; }

        /// <summary>
        /// <value>Property <c>loanCurrency</c></value>
        /// <para>Loan coin name</para>
        /// </summary>
        public string? loanCurrency { get; set; }

        /// <summary>
        /// <value>Property <c>collateralCurrency</c></value>
        /// <para>Collateral coin name</para>
        /// </summary>
        public string? collateralCurrency { get; set; }

        /// <summary>
        /// <value>Property <c>loanTermType</c></value>
        /// <para>
        /// Loan term type:
        /// </para>
        /// <list type="bullet">
        /// <item>
        /// <term>1</term>
        /// <description>Fixed term (requires <c>loanTerm</c>)</description>
        /// </item>
        /// <item>
        /// <term>2</term>
        /// <description>Flexible term</description>
        /// </item>
        /// </list>
        /// <para>By default, queries all types</para>
        /// </summary>
        public string? loanTermType { get; set; }

        /// <summary>
        /// <value>Property <c>loanTerm</c></value>
        /// <para>
        /// Loan duration (only applies when <c>loanTermType</c> is 1): 7, 14, 30, 90, 180 days
        /// </para>
        /// </summary>
        public string? loanTerm { get; set; }

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <para>
        /// Limit for data size per page. Range: [1, 100]. Default is 10
        /// </para>
        /// </summary>
        public string? limit { get; set; }

        /// <summary>
        /// <value>Property <c>cursor</c></value>
        /// <para>
        /// Cursor token. Use <c>nextPageCursor</c> from the previous response to paginate
        /// </para>
        /// </summary>
        public string? cursor { get; set; }
    }


    public class GetUnpaidLoansResponse
    {
        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>List of unpaid loan entries</para>
        /// </summary>
        public List<LoanEntryItem> List { get; set; } = new();

        /// <summary>
        /// <value>Property <c>nextPageCursor</c></value>
        /// <para>Refer to the <c>cursor</c> request parameter for pagination</para>
        /// </summary>
        public string? NextPageCursor { get; set; }

        /// <summary>
        /// Represents an unpaid loan entry in the response list.
        /// </summary>
        public class LoanEntryItem
        {
            /// <summary>
            /// <value>Property <c>collateralAmount</c></value>
            /// <para>Collateral amount</para>
            /// </summary>
            public string CollateralAmount { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>collateralCurrency</c></value>
            /// <para>Collateral coin</para>
            /// </summary>
            public string CollateralCurrency { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>currentLTV</c></value>
            /// <para>Current Loan-to-Value ratio</para>
            /// </summary>
            public string CurrentLTV { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>expirationTime</c></value>
            /// <para>Loan maturity time. Empty string if the loan is flexible</para>
            /// </summary>
            public string ExpirationTime { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>hourlyInterestRate</c></value>
            /// <para>
            /// Hourly interest rate:
            /// </para>
            /// <list type="bullet">
            /// <item>
            /// <description>Flexible loan: real-time interest rate</description>
            /// </item>
            /// <item>
            /// <description>Fixed term loan: fixed interest rate</description>
            /// </item>
            /// </list>
            /// </summary>
            public string HourlyInterestRate { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>loanCurrency</c></value>
            /// <para>Loan coin</para>
            /// </summary>
            public string LoanCurrency { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>loanTerm</c></value>
            /// <para>Loan term: 7, 14, 30, 90, 180 days. Empty string for flexible loan</para>
            /// </summary>
            public string LoanTerm { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>orderId</c></value>
            /// <para>Loan order ID</para>
            /// </summary>
            public string OrderId { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>residualInterest</c></value>
            /// <para>Unpaid interest</para>
            /// </summary>
            public string ResidualInterest { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>residualPenaltyInterest</c></value>
            /// <para>Unpaid penalty interest</para>
            /// </summary>
            public string ResidualPenaltyInterest { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>totalDebt</c></value>
            /// <para>Unpaid principal</para>
            /// </summary>
            public string TotalDebt { get; set; } = default!;
        }
    }
}
