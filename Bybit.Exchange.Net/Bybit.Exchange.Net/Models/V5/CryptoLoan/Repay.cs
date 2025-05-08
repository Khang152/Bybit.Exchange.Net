namespace Bybit.Exchange.Net.Models.V5.CryptoLoan
{
    public class RepayRequest
    {
        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>Loan order ID</para>
        /// </summary>
        public required string orderId { get; set; }

        /// <summary>
        /// <value>Property <c>amount</c></value>
        /// <para>Repay amount</para>
        /// </summary>
        public required string amount { get; set; }
    }


    public class RepayResponse
    {
        /// <summary>
        /// <value>Property <c>repayId</c></value>
        /// <para>Repayment transaction ID</para>
        /// </summary>
        public string? RepayId { get; set; }
    }
}
