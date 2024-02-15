namespace Bybit.Exchange.Net.Models.V5.SpotLeverageToken
{
    public class PurchaseRequest
    {
        /// <summary>
        /// <value>Property <c>ltCoin</c></value>
        /// <para>
        /// Abbreviation of the LT, such as BTC3L
        /// </para>
        /// </summary>
        public string ltCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ltAmount</c></value>
        /// <para>
        /// Purchase amount
        /// </para>
        /// </summary>
        public string ltAmount { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>serialNo</c></value>
        /// <para>
        /// Serial number
        /// </para>
        /// </summary>
        public string serialNo { get; set; } = default!;
    }

    public class PurchaseResponse
    {
        /// <summary>
        /// <value>Property <c>ltCoin</c></value>
        /// <para>
        /// Abbreviation of the LT, such as BTC3L
        /// </para>
        /// </summary>
        public string LtCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ltOrderStatus</c></value>
        /// <para>
        /// Order status. 1: completed, 2: in progress, 3: failed
        /// </para>
        /// </summary>
        public string LtOrderStatus { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>execQty</c></value>
        /// <para>
        /// Executed qty of LT
        /// </para>
        /// </summary>
        public string ExecQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>execAmt</c></value>
        /// <para>
        /// Executed amount of LT
        /// </para>
        /// </summary>
        public string ExecAmt { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>amount</c></value>
        /// <para>
        /// Purchase amount
        /// </para>
        /// </summary>
        public string Amount { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>purchaseId</c></value>
        /// <para>
        /// Order ID
        /// </para>
        /// </summary>
        public string PurchaseId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>serialNo</c></value>
        /// <para>
        /// Serial number, customised order ID
        /// </para>
        /// </summary>
        public string SerialNo { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>valueCoin</c></value>
        /// <para>
        /// Quote coin
        /// </para>
        /// </summary>
        public string ValueCoin { get; set; } = default!;
    }
}