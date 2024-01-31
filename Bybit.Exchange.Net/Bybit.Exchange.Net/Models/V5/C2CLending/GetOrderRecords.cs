namespace Bybit.Exchange.Net.Models.V5.C2CLending
{
    public class GetOrderRecordsRequest
    {
        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <remarks>
        /// Coin name
        /// </remarks>
        /// </summary>
        public string coin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <remarks>
        /// Order ID
        /// </remarks>
        /// </summary>
        public string orderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>startTime</c></value>
        /// <remarks>
        /// The start timestamp (ms)
        /// </remarks>
        /// </summary>
        public long? startTime { get; set; }

        /// <summary>
        /// <value>Property <c>endTime</c></value>
        /// <remarks>
        /// The end timestamp (ms)
        /// </remarks>
        /// </summary>
        public long? endTime { get; set; }

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <remarks>
        /// Limit for data size per page. [1, 500]. Default: 50
        /// </remarks>
        /// </summary>
        public int? limit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderType</c></value>
        /// <remarks>
        /// Order type. 1: deposit, 2: redemption, 3: Payment of proceeds
        /// </remarks>
        /// </summary>
        public string orderType { get; set; } = default!;
    }

    public class GetOrderRecordsResponse
    {
        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <remarks>
        /// Object
        /// </remarks>
        /// </summary>
        public List<GetOrderRecordsItem> List { get; set; } = new List<GetOrderRecordsItem>();
    }

    public class GetOrderRecordsItem
    {
        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <remarks>
        /// Coin name
        /// </remarks>
        /// </summary>
        public string Coin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>createdTime</c></value>
        /// <remarks>
        /// Created timestamp (ms)
        /// </remarks>
        /// </summary>
        public string CreatedTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <remarks>
        /// Order ID
        /// </remarks>
        /// </summary>
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>quantity</c></value>
        /// <remarks>
        /// quantity
        /// </remarks>
        /// </summary>
        public string Quantity { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>serialNo</c></value>
        /// <remarks>
        /// Serial No
        /// </remarks>
        /// </summary>
        public string SerialNo { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>status</c></value>
        /// <remarks>
        /// Order status. 0: Initial, 1: Processing, 2: Success, 10: Failed, 11: Cancelled
        /// </remarks>
        /// </summary>
        public string Status { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>updatedTime</c></value>
        /// <remarks>
        /// Updated timestamp (ms)
        /// </remarks>
        /// </summary>
        public string UpdatedTime { get; set; } = default!;
    }
}