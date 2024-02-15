namespace Bybit.Exchange.Net.Models.V5.SpotLeverageToken
{
    public class GetLeverageTokenInfoRequest
    {
        /// <summary>
        /// <value>Property <c>ltCoin</c></value>
        /// <para>
        /// Abbreviation of the LT, such as BTC3L
        /// </para>
        /// </summary>
        public string ltCoin { get; set; } = default!;
    }

    public class GetLeverageTokenInfoResponse
    {
        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// Object
        /// </para>
        /// </summary>
        public List<LeverageTokenInfo> List { get; set; } = default!;
    }

    public class LeverageTokenInfo
    {
        /// <summary>
        /// <value>Property <c>ltCoin</c></value>
        /// <para>
        /// Abbreviation
        /// </para>
        /// </summary>
        public string LtCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ltName</c></value>
        /// <para>
        /// Full name of leveraged token
        /// </para>
        /// </summary>
        public string LtName { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>maxPurchase</c></value>
        /// <para>
        /// Single maximum purchase amount
        /// </para>
        /// </summary>
        public string MaxPurchase { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>minPurchase</c></value>
        /// <para>
        /// Single minimum purchase amount
        /// </para>
        /// </summary>
        public string MinPurchase { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>maxPurchaseDaily</c></value>
        /// <para>
        /// Maximum purchase amount in a single day
        /// </para>
        /// </summary>
        public string MaxPurchaseDaily { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>maxRedeem</c></value>
        /// <para>
        /// Single Maximum redemption quantity
        /// </para>
        /// </summary>
        public string MaxRedeem { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>minRedeem</c></value>
        /// <para>
        /// Single Minimum redemption quantity
        /// </para>
        /// </summary>
        public string MinRedeem { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>maxRedeemDaily</c></value>
        /// <para>
        /// Maximum redemption quantity in a single day
        /// </para>
        /// </summary>
        public string MaxRedeemDaily { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>purchaseFeeRate</c></value>
        /// <para>
        /// Purchase fee rate
        /// </para>
        /// </summary>
        public string PurchaseFeeRate { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>redeemFeeRate</c></value>
        /// <para>
        /// Redeem fee rate
        /// </para>
        /// </summary>
        public string RedeemFeeRate { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ltStatus</c></value>
        /// <para>
        /// Whether the leverage token can be purchased or redeemed
        /// </para>
        /// </summary>
        public string LtStatus { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>fundFee</c></value>
        /// <para>
        /// Funding fee charged daily for users holding leveraged token
        /// </para>
        /// </summary>
        public string FundFee { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>fundFeeTime</c></value>
        /// <para>
        /// The time to charge funding fee
        /// </para>
        /// </summary>
        public string FundFeeTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>manageFeeRate</c></value>
        /// <para>
        /// Management fee rate
        /// </para>
        /// </summary>
        public string ManageFeeRate { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>manageFeeTime</c></value>
        /// <para>
        /// The time to charge management fee
        /// </para>
        /// </summary>
        public string ManageFeeTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>value</c></value>
        /// <para>
        /// Nominal asset value
        /// </para>
        /// </summary>
        public string Value { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>netValue</c></value>
        /// <para>
        /// Net value
        /// </para>
        /// </summary>
        public string NetValue { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>total</c></value>
        /// <para>
        /// Total purchase upper limit
        /// </para>
        /// </summary>
        public string Total { get; set; } = default!;
    }
}