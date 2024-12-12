using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Position
{
    public class SwitchPositionModeRequest
    {
        /// <summary>
        /// Product type
        /// <remarks>
        /// <para>
        /// UTA2.0: linear, USDT Perp
        /// </para>
        /// <para>
        /// UTA1.0: linear, USDT Perp; inverse, Inverse Futures
        /// </para>
        /// <para>
        /// Classic: linear, USDT Perp; inverse, Inverse Futures
        /// </para>
        /// </remarks>
        /// </summary>
        public required Category category { get; set; } = default!;

        /// <summary>
        /// Symbol name, like BTCUSDT, uppercase only. Either symbol or coin is required. Symbol has a higher priority
        /// </summary>
        public string? symbol { get; set; }

        /// <summary>
        /// Coin, uppercase only
        /// </summary>
        public string? coin { get; set; }

        /// <summary>
        /// Position mode
        /// <remarks>
        /// <para>
        /// 0: Merged Single
        /// </para>
        /// <para>
        /// 3: Both Sides
        /// </para>
        /// </remarks>
        /// </summary>
        public required int mode { get; set; }
    }

    public class SwitchPositionModeResponse
    {
    }
}
