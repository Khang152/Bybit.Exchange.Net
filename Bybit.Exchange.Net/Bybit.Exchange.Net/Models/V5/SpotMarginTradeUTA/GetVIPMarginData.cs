using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.SpotMarginTradeUTA
{
    public class GetVIPMarginDataUTARequest
    {
        /// <summary>
        /// <value>Property <c>vipLevel</c></value>
        /// <para>
        /// Vip level
        /// </para>
        /// </summary>
        public VipLevel? vipLevel { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>currency</c></value>
        /// <para>
        /// Coin name
        /// </para>
        /// </summary>
        public string currency { get; set; } = default!;
    }

    public class GetVIPMarginDataUTAResponse
    {
        /// <summary>
        /// <value>Property <c>vipCoinList</c></value>
        /// <para>
        /// Object
        /// </para>
        /// </summary>
        public VipCoinListUTA[] VipCoinList { get; set; } = default!;
    }

    public class VipCoinListUTA
    {
        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// Object
        /// </para>
        /// </summary>
        public VipCoinListItemUTA[] List { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>vipLevel</c></value>
        /// <para>
        /// Vip level
        /// </para>
        /// </summary>
        public VipLevel? VipLevel { get; set; } = default!;
    }

    public class VipCoinListItemUTA
    {
        /// <summary>
        /// <value>Property <c>borrowable</c></value>
        /// <para>
        /// Whether it is allowed to be borrowed
        /// </para>
        /// </summary>
        public bool Borrowable { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>collateralRatio</c></value>
        /// <para>
        /// Collateral ratio
        /// </para>
        /// </summary>
        public string CollateralRatio { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>currency</c></value>
        /// <para>
        /// Coin name
        /// </para>
        /// </summary>
        public string Currency { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>hourlyBorrowRate</c></value>
        /// <para>
        /// Borrow interest rate per hour
        /// </para>
        /// </summary>
        public string HourlyBorrowRate { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>liquidationOrder</c></value>
        /// <para>
        /// Liquidation order
        /// </para>
        /// </summary>
        public string LiquidationOrder { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>marginCollateral</c></value>
        /// <para>
        /// Whether it can be used as a margin collateral currency
        /// </para>
        /// </summary>
        public bool MarginCollateral { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>maxBorrowingAmount</c></value>
        /// <para>
        /// Max borrow amount
        /// </para>
        /// </summary>
        public string MaxBorrowingAmount { get; set; } = default!;
    }
}