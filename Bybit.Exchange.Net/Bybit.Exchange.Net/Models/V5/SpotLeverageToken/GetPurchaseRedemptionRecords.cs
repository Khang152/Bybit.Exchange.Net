namespace Bybit.Exchange.Net.Models.V5.SpotLeverageToken
{
    public class GetPurchaseRedemptionRecordsRequest
    {
        /// <summary>
        /// <value>Property <c>ltCoin</c></value>
        /// <para>
        /// Abbreviation of the LT, such as BTC3L
        /// </para>
        /// </summary>
        public string ltCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// Order ID
        /// </para>
        /// </summary>
        public string orderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>startTime</c></value>
        /// <para>
        /// The start timestamp (ms)
        /// </para>
        /// </summary>
        public double? startTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>endTime</c></value>
        /// <para>
        /// The end timestamp (ms)
        /// </para>
        /// </summary>
        public double? endTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <para>
        /// Limit for data size per page. [1, 500]. Default: 100
        /// </para>
        /// </summary>
        public int? limit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ltOrderType</c></value>
        /// <para>
        /// LT order type. 1: purchase, 2: redemption
        /// </para>
        /// </summary>
        public int? ltOrderType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>serialNo</c></value>
        /// <para>
        /// Serial number
        /// </para>
        /// </summary>
        public string serialNo { get; set; } = default!;
    }

    public class GetPurchaseRedemptionRecordsResponse
    {
        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// Object
        /// </para>
        /// </summary>
        public List<PurchaseRedemptionRecord> List { get; set; } = default!;
    }

    public class PurchaseRedemptionRecord
    {
        /// <summary>
        /// <value>Property <c>ltCoin</c></value>
        /// <para>
        /// Abbreviation of the LT, such as BTC3L
        /// </para>
        /// </summary>
        public string LtCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// Order ID
        /// </para>
        /// </summary>
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ltOrderType</c></value>
        /// <para>
        /// LT order type. 1: purchase, 2: redeem
        /// </para>
        /// </summary>
        public int? LtOrderType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderTime</c></value>
        /// <para>
        /// Order time
        /// </para>
        /// </summary>
        public double? OrderTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>updateTime</c></value>
        /// <para>
        /// Last update time of the order status
        /// </para>
        /// </summary>
        public double? UpdateTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ltOrderStatus</c></value>
        /// <para>
        /// Order status. 1: completed, 2: in progress, 3: failed
        /// </para>
        /// </summary>
        public string LtOrderStatus { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>fee</c></value>
        /// <para>
        /// Trading fees
        /// </para>
        /// </summary>
        public string Fee { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>amount</c></value>
        /// <para>
        /// Order quantity of the LT
        /// </para>
        /// </summary>
        public string Amount { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>value</c></value>
        /// <para>
        /// Filled value
        /// </para>
        /// </summary>
        public string Value { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>valueCoin</c></value>
        /// <para>
        /// Quote coin
        /// </para>
        /// </summary>
        public string ValueCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>serialNo</c></value>
        /// <para>
        /// Serial number
        /// </para>
        /// </summary>
        public string SerialNo { get; set; } = default!;
    }
}