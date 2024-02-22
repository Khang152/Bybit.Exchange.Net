namespace Bybit.Exchange.Net.Models.V5.SpotMarginTradeUTA
{
    public class SetLeverageRequest
    {
        /// <summary>
        /// <value>Property <c>leverage</c></value>
        /// <para>
        /// Leverage. [2, 10]
        /// </para>
        /// </summary>
        public string leverage { get; set; } = default!;
    }

    public class SetLeverageResponse
    {
    }
}