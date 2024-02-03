namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class SetDcpRequest
    {
        /// <summary>
        /// <value>Property <c>TimeWindow</c></value>
        /// <para>
        /// Disconnection timing window time. [3, 300], unit: second
        /// </para>
        /// </summary>
        public int? timeWindow { get; set; } = default!;
    }

    public class SetDcpResponse
    {
    }
}