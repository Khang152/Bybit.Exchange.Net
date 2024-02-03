using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class GetBorrowQuotaRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <para>
        /// Product type: spot
        /// </para>
        /// </summary>
        public Category? category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>side</c></value>
        /// <para>
        /// Transaction side: Buy,Sell
        /// </para>
        /// </summary>
        public Side? side { get; set; } = default!;
    }

    public class GetBorrowQuotaResponse
    {
        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>side</c></value>
        /// <para>
        /// Side
        /// </para>
        /// </summary>
        public Side? side { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>maxTradeQty</c></value>
        /// <remarks>
        /// If spot margin trade on and symbol is margin trading pair, it returns available balance + max.borrowable amount.
        /// Otherwise, it returns actual balance.
        /// </remarks>
        /// <para>
        /// The maximum base coin qty can be traded, up to 4 decimals
        /// </para>
        /// </summary>
        public string MaxTradeQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>maxTradeAmount</c></value>
        /// <remarks>
        /// If spot margin trade on and symbol is margin trading pair, it returns available balance + max.borrowable amount.
        /// Otherwise, it returns actual balance.
        /// </remarks>
        /// <para>
        /// The maximum quote coin amount can be traded, up to 8 decimals
        /// </para>
        /// </summary>
        public string MaxTradeAmount { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>spotMaxTradeQty</c></value>
        /// <remarks>
        /// No matter your Spot margin switch on or not, it always returns actual qty of base coin you can trade or you have, up to 4 decimals
        /// </remarks>
        /// </summary>
        public string SpotMaxTradeQty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>spotMaxTradeAmount</c></value>
        /// <remarks>
        /// No matter your Spot margin switch on or not, it always returns actual amount of quote coin you can trade or you have, up to 8 decimals
        /// </remarks>
        /// </summary>
        public string SpotMaxTradeAmount { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>borrowCoin</c></value>
        /// <para>
        /// Borrow coin
        /// </para>
        /// </summary>
        public string BorrowCoin { get; set; } = default!;
    }
}