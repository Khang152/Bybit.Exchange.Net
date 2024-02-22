namespace Bybit.Exchange.Net.Models.V5.SpotMarginTradeUTA
{
    public class ToggleMarginTradeRequest
    {
        /// <summary>
        /// <value>Property <c>spotMarginMode</c></value>
        /// <para>
        /// Spot Margin Mode | 1: on, 0: off
        /// </para>
        /// </summary>
        public string spotMarginMode { get; set; } = default!;
    }

    public class ToggleMarginTradeResponse
    {
        /// <summary>
        /// <value>Property <c>spotMarginMode</c></value>
        /// <para>
        /// Spot Margin Mode | 1: on, 0: off
        /// </para>
        /// </summary>
        public string SpotMarginMode { get; set; } = default!;
    }
}