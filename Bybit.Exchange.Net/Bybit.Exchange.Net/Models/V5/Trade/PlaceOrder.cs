using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Trade
{
    public class PlaceOrderRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// | Product type:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>Unified account</term>
        /// <description>
        /// spot, linear, inverse, option
        /// </description>
        /// </item>
        /// <item>
        /// <term>Classic account</term>
        /// <description>
        /// spot, linear, inverse
        /// </description>
        /// </item>
        /// </list>
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
        /// <value>Property <c>isLeverage</c></value>
        /// <para>
        /// Whether to borrow. Valid for Unified spot only. 0(default): false then spot trading, 1: true then margin trading
        /// </para>
        /// </summary>
        public int? isLeverage { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>side</c></value>
        /// <para>
        /// Buy, Sell
        /// </para>
        /// </summary>
        public Side? side { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderType</c></value>
        /// <para>
        /// Market, Limit
        /// </para>
        /// </summary>
        public OrderType? orderType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>qty</c></value>
        /// <remarks>
        /// | UTA account
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>Spot</term>
        /// <description>set marketUnit for market order qty unit, quoteCoin for market buy by default, baseCoin for market sell by default</description>
        /// </item>
        /// <item>
        /// <term>Perps, Futures &amp; Option</term>
        /// <description>always use base coin as unit</description>
        /// </item>
        /// <item>
        /// <term>Classic account</term>
        /// <description>
        /// Spot: the unit of qty is quote coin for market buy order, for others, it is base coin
        /// Perps, Futures: always use base coin as unit
        /// Perps &amp; Futures: if you pass qty="0" &amp; reduceOnly="true", you can close the whole position of the current symbol
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        public string qty { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>marketUnit</c></value>
        /// <para>
        /// The unit for qty when creating Spot market orders for UTA account
        /// </para>
        /// </summary>
        public string marketUnit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>price</c></value>
        /// <para>
        /// Order price
        /// </para>
        /// </summary>
        public string price { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>triggerDirection</c></value>
        /// <para>
        /// Conditional order param. Used to identify the expected direction of the conditional order.
        /// 1: triggered when market price rises to triggerPrice
        /// 2: triggered when market price falls to triggerPrice
        /// Valid for linear &amp; inverse
        /// </para>
        /// </summary>
        public TriggerDirection? triggerDirection { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderFilter</c></value>
        /// <remarks>
        /// | If it is not passed, Order by default.
        /// </remarks>
        /// <para>
        /// Order
        /// tpslOrder: Spot TP/SL order, the assets are occupied even before the order is triggered
        /// StopOrder: Spot conditional order, the assets will not be occupied until the price of the underlying asset reaches the trigger price, &amp; the required assets will be occupied after the Conditional order is triggered
        /// Valid for spot only
        /// </para>
        /// </summary>
        public string orderFilter { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>triggerPrice</c></value>
        /// <para>
        /// For Perps &amp; Futures, it is the conditional order trigger price.
        /// If you expect the price to rise to trigger your conditional order, make sure:
        /// triggerPrice > market price
        /// Else, triggerPrice &lt; market price
        /// For spot, it is the TP/SL &amp; Conditional order trigger price
        /// </para>
        /// </summary>
        public string triggerPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>triggerBy</c></value>
        /// <para>
        /// Trigger price type, Conditional order param for Perps &amp; Futures. LastPrice, IndexPrice, MarkPrice
        /// Valid for linear &amp; inverse
        /// </para>
        /// </summary>
        public TriggerBy? triggerBy { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderIv</c></value>
        /// <para>
        /// Implied volatility. option only. Pass the real value, e.g for 10%, 0.1 should be passed.
        /// orderIv has a higher priority when price is passed as well
        /// </para>
        /// </summary>
        public string orderIv { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>timeInForce</c></value>
        /// <para>
        /// Time in force
        /// Market order will use IOC directly
        /// If not passed, GTC is used by default
        /// </para>
        /// </summary>
        public TimeInForce? timeInForce { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>positionIdx</c></value>
        /// <para>
        /// Used to identify positions in different position modes. Under hedge-mode, this param is required (USDT perps &amp; Inverse contracts have hedge mode)
        /// 0: one-way mode
        /// 1: hedge-mode Buy side
        /// 2: hedge-mode Sell side
        /// </para>
        /// </summary>
        public PositionIdx? positionIdx { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderLinkId</c></value>
        /// <para>
        /// User customised order ID. A max of 36 characters. Combinations of numbers, letters (upper &amp; lower cases), dashes, &amp; underscores are supported.
        /// Futures &amp; Perps: orderLinkId rules:
        /// optional param always unique
        /// option orderLinkId rules:
        /// required param always unique
        /// </para>
        /// </summary>
        public string orderLinkId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>takeProfit</c></value>
        /// <para>
        /// Take profit price
        /// linear &amp; inverse: support UTA &amp; classic account
        /// spot(UTA): Spot Limit order supports take profit, stop loss or limit take profit, limit stop loss when creating an order
        /// </para>
        /// </summary>
        public string takeProfit { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>stopLoss</c></value>
        /// <para>
        /// Stop loss price
        /// linear &amp; inverse: support UTA &amp; classic account
        /// spot(UTA): Spot Limit order supports take profit, stop loss or limit take profit, limit stop loss when creating an order
        /// </para>
        /// </summary>
        public string stopLoss { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>tpTriggerBy</c></value>
        /// <para>
        /// The price type to trigger take profit. MarkPrice, IndexPrice, default: LastPrice. Valid for linear &amp; inverse
        /// </para>
        /// </summary>
        public TriggerBy? tpTriggerBy { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>slTriggerBy</c></value>
        /// <para>
        /// The price type to trigger stop loss. MarkPrice, IndexPrice, default: LastPrice. Valid for linear &amp; inverse
        /// </para>
        /// </summary>
        public TriggerBy? slTriggerBy { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>reduceOnly</c></value>
        /// <para>
        /// What is a reduce-only order? true means your position can only reduce in size if this order is triggered.
        /// You must specify it as true when you are about to close/reduce the position
        /// When reduceOnly is true, take profit/stop loss cannot be set
        /// Valid for linear, inverse &amp; option
        /// </para>
        /// </summary>
        public bool? reduceOnly { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>closeOnTrigger</c></value>
        /// <para>
        /// What is a close on trigger order? For a closing order. It can only reduce your position, not increase it.
        /// If the account has insufficient available balance when the closing order is triggered, then other active orders of similar contracts will be cancelled or reduced.
        /// It can be used to ensure your stop loss reduces your position regardless of current available margin.
        /// Valid for linear &amp; inverse
        /// </para>
        /// </summary>
        public bool? closeOnTrigger { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>smpType</c></value>
        /// <para>
        /// Smp execution type. What is SMP?
        /// </para>
        /// </summary>
        public SmpType? smpType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>mmp</c></value>
        /// <para>
        /// Market maker protection. option only. true means set the order as a market maker protection order. What is mmp?
        /// </para>
        /// </summary>
        public bool? mmp { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>tpslMode</c></value>
        /// <para>
        /// TP/SL mode
        /// Full: entire position for TP/SL. Then, tpOrderType or slOrderType must be Market
        /// Partial: partial position tp/sl. Limit TP/SL order are supported. Note: When create limit tp/sl, tpslMode is required &amp; it must be Partial
        /// Valid for linear &amp; inverse
        /// </para>
        /// </summary>
        public string tpslMode { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>tpLimitPrice</c></value>
        /// <para>
        /// The limit order price when take profit price is triggered
        /// linear &amp; inverse: only works when tpslMode=Partial &amp; tpOrderType=Limit
        /// Spot(UTA): it is required when the order has takeProfit &amp; tpOrderType=Limit
        /// </para>
        /// </summary>
        public string tpLimitPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>slLimitPrice</c></value>
        /// <para>
        /// The limit order price when stop loss price is triggered
        /// linear &amp; inverse: only works when tpslMode=Partial &amp; slOrderType=Limit
        /// Spot(UTA): it is required when the order has stopLoss &amp; slOrderType=Limit
        /// </para>
        /// </summary>
        public string slLimitPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>tpOrderType</c></value>
        /// <para>
        /// The order type when take profit is triggered
        /// linear &amp; inverse: Market(default), Limit. For tpslMode=Full, it only supports tpOrderType=Market
        /// Spot(UTA): Market: when you set "takeProfit", Limit: when you set "takeProfit" &amp; "tpLimitPrice"
        /// </para>
        /// </summary>
        public OrderType? tpOrderType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>slOrderType</c></value>
        /// <para>
        /// The order type when stop loss is triggered
        /// linear &amp; inverse: Market(default), Limit. For tpslMode=Full, it only supports slOrderType=Market
        /// Spot(UTA): Market: when you set "stopLoss", Limit: when you set "stopLoss" &amp; "slLimitPrice"
        /// </para>
        /// </summary>
        public OrderType? slOrderType { get; set; } = default!;
    }

    public class PlaceOrderResponse
    {
        /// <summary>
        /// <value>Property <c>orderId</c></value>
        /// <para>
        /// Order ID
        /// </para>
        /// </summary>
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>orderLinkId</c></value>
        /// <para>
        /// User customised order ID
        /// </para>
        /// </summary>
        public string OrderLinkId { get; set; } = default!;
    }
}