namespace Bybit.Exchange.Net.Models.V5.C2CLending
{
    public class GetLendingAccountInfoRequest
    {
        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <para>
        /// Coin name
        /// </para>
        /// </summary>
        public string coin { get; set; } = default!;
    }

    public class GetLendingAccountInfoResponse
    {
        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <para>
        /// Coin name
        /// </para>
        /// </summary>
        public string Coin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>principalInterest</c></value>
        /// <para>
        /// User Redeemable interest
        /// </para>
        /// </summary>
        public string PrincipalInterest { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>principalQty</c></value>
        /// <para>
        /// Leftover quantity you can redeem for today (measured from 0 - 24 UTC), formula: min(the rest amount of principle, the amount that the user can redeem on the day)
        /// </para>
        /// </summary>
        public string PrincipalQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>principalTotal</c></value>
        /// <para>
        /// Total amount redeemable by user
        /// </para>
        /// </summary>
        public string PrincipalTotal { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>quantity</c></value>
        /// <para>
        /// Current deposit quantity
        /// </para>
        /// </summary>
        public string Quantity { get; set; } = default!;
    }
}