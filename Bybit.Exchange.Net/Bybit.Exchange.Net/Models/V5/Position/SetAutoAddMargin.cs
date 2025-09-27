using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Position
{
    public class SetAutoAddMarginRequest
    {
        /// <summary>
        /// Product type.
        /// <para>UTA2.0, UTA1.0: linear (USDT Contract, USDC Contract)</para>
        /// <para>Classic account: linear (USDT Perps)</para>
        /// </summary>
        public Category category { get; set; }

        /// <summary>
        /// Symbol name, like BTCUSDT, uppercase only.
        /// </summary>
        public string symbol { get; set; } = string.Empty;

        /// <summary>
        /// Turn on/off auto add margin.
        /// <para>0 = off, 1 = on</para>
        /// </summary>
        public int autoAddMargin { get; set; }

        /// <summary>
        /// Used to identify positions in different position modes. Required for hedge mode positions.
        /// <para>0 = one-way mode</para>
        /// <para>1 = hedge-mode Buy side</para>
        /// <para>2 = hedge-mode Sell side</para>
        /// </summary>
        public int? positionIdx { get; set; }
    }

    public class SetAutoAddMarginResponse
    {
    }
}
