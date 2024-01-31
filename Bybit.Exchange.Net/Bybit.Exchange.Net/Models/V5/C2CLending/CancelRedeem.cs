namespace Bybit.Exchange.Net.Models.V5.C2CLending
{
    public class CancelRedeemRequest
    {
        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <para>
        /// Coin name
        /// </para>
        /// </summary>
        public string coin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// The order ID of redemption
        /// </para>
        /// </summary>
        public string orderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>serialNo</c></value>
        /// <para>
        /// Serial no. The customised ID of redemption
        /// </para>
        /// </summary>
        public string serialNo { get; set; } = default!;
    }

    public class CancelRedeemResponse
    {
        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// Order ID
        /// </para>
        /// </summary>
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>serialNo</c></value>
        /// <para>
        /// Serial No
        /// </para>
        /// </summary>
        public string SerialNo { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>updatedTime</c></value>
        /// <para>
        /// Updated timestamp (ms)
        /// </para>
        /// </summary>
        public string UpdatedTime { get; set; } = default!;
    }
}