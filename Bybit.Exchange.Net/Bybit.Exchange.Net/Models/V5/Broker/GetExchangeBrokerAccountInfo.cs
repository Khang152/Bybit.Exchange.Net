namespace Bybit.Exchange.Net.Models.V5.Broker
{
    public class GetExchangeBrokerAccountInfoRequest
    {
    }

    public class GetExchangeBrokerAccountInfoResponse
    {
        /// <summary>
        /// <value>Property <c>subAcctQty</c></value>
        /// <para>
        /// The qty of sub account has been created
        /// </para>
        /// </summary>
        public string SubAcctQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>maxSubAcctQty</c></value>
        /// <para>
        /// The max limit of sub account can be created
        /// </para>
        /// </summary>
        public string MaxSubAcctQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseFeeRebateRate</c></value>
        /// <para>
        /// Rebate percentage of the base fee
        /// </para>
        /// </summary>
        public FeeRebateRateItem BaseFeeRebateRate { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>markupFeeRebateRate</c></value>
        /// <para>
        /// Rebate percentage of the mark up fee
        /// </para>
        /// </summary>
        public FeeRebateRateItem MarkupFeeRebateRate { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ts</c></value>
        /// <para>
        /// System timestamp (ms)
        /// </para>
        /// </summary>
        public string Ts { get; set; } = default!;
    }

    public class FeeRebateRateItem
    {
        /// <summary>
        /// <value>Property <c>spot</c></value>
        /// <para>
        /// Rebate percentage of the mark up fee for spot, e.g., 10.00%
        /// </para>
        /// </summary>
        public string Spot { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>derivatives</c></value>
        /// <para>
        /// Rebate percentage of the mark up fee for derivatives, e.g., 10.00%
        /// </para>
        /// </summary>
        public string Derivatives { get; set; } = default!;
    }
}