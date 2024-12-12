using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Position
{
    public class SetTradingStopRequest
    {
        /// <summary>
        /// Product type
        /// <remarks>
        /// <para>
        /// UTA2.0, UTA1.0: linear, inverse
        /// </para>
        /// <para>
        /// Classic account: linear, inverse
        /// </para>
        /// </remarks>
        /// </summary>
        public required Category category { get; set; } = default!;

        /// <summary>
        /// Symbol name, like BTCUSDT, uppercase only
        /// </summary>
        public required string symbol { get; set; } = default!;

        /// <summary>
        /// Cannot be less than 0, 0 means cancel TP
        /// </summary>
        public string? takeProfit { get; set; }

        /// <summary>
        /// Cannot be less than 0, 0 means cancel SL
        /// </summary>
        public string? stopLoss { get; set; }

        /// <summary>
        /// Trailing stop by price distance. Cannot be less than 0, 0 means cancel TS
        /// </summary>
        public string? trailingStop { get; set; }

        /// <summary>
        /// Take profit trigger price type
        /// </summary>
        public TriggerBy? tpTriggerBy { get; set; }

        /// <summary>
        /// Stop loss trigger price type
        /// </summary>
        public TriggerBy? slTriggerBy { get; set; }

        /// <summary>
        /// Trailing stop trigger price. Trailing stop will be triggered when this price is reached only
        /// </summary>
        public string? activePrice { get; set; }

        /// <summary>
        /// <value>Property <c>TpSlMode</c></value>
        /// <remarks>
        /// <para>
        /// Full: entire position for TP/SL. Then, tpOrderType or slOrderType must be Market
        /// </para>
        /// <para>
        /// Partial: partial position TP/SL. Limit TP/SL order are supported. Note: When create limit TP/SL, tpslMode is required and it must be Partial
        /// </para>
        /// </remarks>
        /// </summary>
        public required TpSlMode tpslMode { get; set; } = default!;

        /// <summary>
        /// Take profit size. Valid for TP/SL partial mode. The value of tpSize and slSize must equal
        /// </summary>
        public string? tpSize { get; set; }

        /// <summary>
        /// Stop loss size. Valid for TP/SL partial mode. The value of tpSize and slSize must equal
        /// </summary>
        public string? slSize { get; set; }

        /// <summary>
        /// The limit order price when take profit price is triggered. Only works when tpslMode=Partial and tpOrderType=Limit
        /// </summary>
        public string? tpLimitPrice { get; set; }

        /// <summary>
        /// The limit order price when stop loss price is triggered. Only works when tpslMode=Partial and slOrderType=Limit
        /// </summary>
        public string? slLimitPrice { get; set; }

        /// <summary>
        /// The order type when take profit is triggered. Market(default), Limit. For tpslMode=Full, it only supports tpOrderType="Market"
        /// </summary>
        public string? tpOrderType { get; set; }

        /// <summary>
        /// The order type when stop loss is triggered. Market(default), Limit. For tpslMode=Full, it only supports slOrderType="Market"
        /// </summary>
        public string? slOrderType { get; set; }

        /// <summary>
        /// <value>Property <c>positionIdx</c></value>
        /// <remarks>
        /// <para>
        /// 0: one-way mode
        /// </para>
        /// <para>
        /// 1: hedge-mode Buy side
        /// </para>
        /// <para>
        /// 2: hedge-mode Sell side
        /// </para>
        /// </remarks>
        /// </summary>
        public required int positionIdx { get; set; }
    }

    public class SetTradingStopResponse
    {
    }
}
