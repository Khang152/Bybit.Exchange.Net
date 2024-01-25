namespace Bybit.Exchange.Net.Models.V5.C2CLending
{
    public class GetLendingCoinInfoRequest
    {
        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <para>
        /// Coin name. Return all currencies by default
        /// </para>
        /// </summary>
        public string coin { get; set; } = default!;
    }

    public class GetLendingCoinInfoResponse
    {
        public List<GetLendingCoinInfoItem> List { get; set; } = default!;
    }

    public class GetLendingCoinInfoItem
    {
        /// <summary>
        /// <value>Property <c>Coin</c></value>
        /// <para>
        /// Coin name
        /// </para>
        /// </summary>
        public string Coin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>MaxRedeemQty</c></value>
        /// <para>
        /// The maximum redeemable qty per day (measured from 0 - 24 UTC)
        /// </para>
        /// </summary>
        public string MaxRedeemQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>MinPurchaseQty</c></value>
        /// <para>
        /// The minimum qty that can be deposited per request
        /// </para>
        /// </summary>
        public string MinPurchaseQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>Precision</c></value>
        /// <para>
        /// Deposit quantity accuracy
        /// </para>
        /// </summary>
        public string Precision { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>Rate</c></value>
        /// <para>
        /// Annualized interest rate. e.g. 0.0002 means 0.02%
        /// </para>
        /// </summary>
        public string Rate { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>LoanToPoolRatio</c></value>
        /// <para>
        /// Capital utilization rate. e.g. 0.0004 means 0.04%
        /// </para>
        /// </summary>
        public string LoanToPoolRatio { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ActualApy</c></value>
        /// <para>
        /// The actual annualized interest rate
        /// </para>
        /// </summary>
        public string ActualApy { get; set; } = default!;
    }
}