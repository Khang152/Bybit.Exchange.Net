using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Account
{
    public class GetFeeRateRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// | Product type:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>spot</term>
        /// </item>
        /// <item>
        /// <term>linear</term>
        /// </item>
        /// <item>
        /// <term>inverse</term>
        /// </item>
        /// <item>
        /// <term>option</term>
        /// </item>
        /// </list>
        /// </summary>
        public Category? category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name. Valid for linear, inverse, spot
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseCoin</c></value>
        /// <remarks>
        /// | Base coin:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>SOL</term>
        /// </item>
        /// <item>
        /// <term>BTC</term>
        /// </item>
        /// <item>
        /// <term>ETH</term>
        /// </item>
        /// </list>
        /// <para>
        /// Valid for option
        /// </para>
        /// </summary>
        public string baseCoin { get; set; } = default!;
    }

    public class GetFeeRateResponse
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// | Product type:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>spot</term>
        /// </item>
        /// <item>
        /// <term>option</term>
        /// </item>
        /// </list>
        /// <para>
        /// Derivatives does not have this field
        /// </para>
        /// </summary>
        public Category Category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// Object
        /// </para>
        /// </summary>
        public List<GetFeeRateItem> List { get; set; } = default!;
    }

    /// <summary>
    /// ListItem class for GetFeeRateResponse
    /// </summary>
    public class GetFeeRateItem
    {
        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name. Keeps "" for Options
        /// </para>
        /// </summary>
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>baseCoin</c></value>
        /// <remarks>
        /// | Base coin:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>SOL</term>
        /// </item>
        /// <item>
        /// <term>BTC</term>
        /// </item>
        /// <item>
        /// <term>ETH</term>
        /// </item>
        /// </list>
        /// <para>
        /// Derivatives does not have this field
        /// </para>
        /// <para>
        /// Keeps "" for Spot
        /// </para>
        /// </summary>
        public string BaseCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>takerFeeRate</c></value>
        /// <para>
        /// Taker fee rate
        /// </para>
        /// </summary>
        public string TakerFeeRate { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>makerFeeRate</c></value>
        /// <para>
        /// Maker fee rate
        /// </para>
        /// </summary>
        public string MakerFeeRate { get; set; } = default!;
    }
}