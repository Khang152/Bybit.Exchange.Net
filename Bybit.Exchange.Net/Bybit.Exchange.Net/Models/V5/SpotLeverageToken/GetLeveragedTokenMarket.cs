namespace Bybit.Exchange.Net.Models.V5.SpotLeverageToken
{
    public class GetLeveragedTokenMarketRequest
    {
        /// <summary>
        /// <value>Property <c>ltCoin</c></value>
        /// <para>
        /// Abbreviation of the LT, such as BTC3L
        /// </para>
        /// </summary>
        public string ltCoin { get; set; } = default!;
    }

    public class GetLeveragedTokenMarketResponse
    {
        /// <summary>
        /// <value>Property <c>ltCoin</c></value>
        /// <para>
        /// Abbreviation of the LT, such as BTC3L
        /// </para>
        /// </summary>
        public string LtCoin { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>nav</c></value>
        /// <para>
        /// Net value
        /// </para>
        /// </summary>
        public string Nav { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>navTime</c></value>
        /// <para>
        /// Update time for net asset value (in milliseconds and UTC time zone)
        /// </para>
        /// </summary>
        public string NavTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>circulation</c></value>
        /// <para>
        /// Circulating supply in the secondary market
        /// </para>
        /// </summary>
        public string Circulation { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>basket</c></value>
        /// <para>
        /// Basket
        /// </para>
        /// </summary>
        public string Basket { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>leverage</c></value>
        /// <para>
        /// Real leverage calculated by last traded price
        /// </para>
        /// </summary>
        public string Leverage { get; set; } = default!;
    }
}