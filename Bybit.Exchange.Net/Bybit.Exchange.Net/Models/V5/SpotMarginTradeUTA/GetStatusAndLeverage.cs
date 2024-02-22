namespace Bybit.Exchange.Net.Models.V5.SpotMarginTradeUTA
{
    public class GetStatusAndLeverageResponse
    {
        /// <summary>
        /// <value>Property <c>spotLeverage</c></value>
        /// <para>
        /// Spot margin leverage. Returns "" if the margin trade is turned off
        /// </para>
        /// </summary>
        public string SpotLeverage { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>spotMarginMode</c></value>
        /// <para>
        /// Spot margin status. 1: on, 0: off
        /// </para>
        /// </summary>
        public string SpotMarginMode { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>effectiveLeverage</c></value>
        /// <para>
        /// Actual leverage ratio. Precision retains 2 decimal places, truncate downwards
        /// </para>
        /// </summary>
        public string EffectiveLeverage { get; set; } = default!;
    }
}