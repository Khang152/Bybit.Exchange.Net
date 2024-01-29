namespace Bybit.Exchange.Net.Models.V5.Market
{
    public class GetBybitServerTimeResponse
    {
        /// <summary>
        /// <value>Property <c>timeSecond</c></value>
        /// <para>
        /// Bybit server timestamp (sec)
        /// </para>
        /// </summary>
        public string TimeSecond { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>timeNano</c></value>
        /// <para>
        /// Bybit server timestamp (nano)
        /// </para>
        /// </summary>
        public string TimeNano { get; set; } = default!;
    }
}