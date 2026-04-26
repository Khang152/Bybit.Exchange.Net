using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket.Public
{
    /// <summary>
    /// Unified ticker stream data model covering Linear, Inverse, Spot, and Option.
    /// Topic: tickers.{symbol}
    /// Push frequency: Derivatives &amp; Options - 100ms, Spot - 50ms
    /// Fields not applicable to a given category will be null.
    /// </summary>
    public class TickerStreamData
    {
        /// <summary>
        /// Symbol name
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// Last price
        /// </summary>
        [JsonProperty("lastPrice")]
        public string? LastPrice { get; set; }

        /// <summary>
        /// The highest price in the last 24 hours
        /// </summary>
        [JsonProperty("highPrice24h")]
        public string? HighPrice24h { get; set; }

        /// <summary>
        /// The lowest price in the last 24 hours
        /// </summary>
        [JsonProperty("lowPrice24h")]
        public string? LowPrice24h { get; set; }

        /// <summary>
        /// Market price 24 hours ago
        /// </summary>
        [JsonProperty("prevPrice24h")]
        public string? PrevPrice24h { get; set; }

        /// <summary>
        /// Volume for 24h
        /// </summary>
        [JsonProperty("volume24h")]
        public string? Volume24h { get; set; }

        /// <summary>
        /// Turnover for 24h
        /// </summary>
        [JsonProperty("turnover24h")]
        public string? Turnover24h { get; set; }

        /// <summary>
        /// Percentage change of market price relative to 24h
        /// </summary>
        [JsonProperty("price24hPcnt")]
        public string? Price24hPcnt { get; set; }

        // === Linear/Inverse specific fields ===

        /// <summary>
        /// Tick direction (Linear/Inverse only)
        /// </summary>
        [JsonProperty("tickDirection")]
        public string? TickDirection { get; set; }

        /// <summary>
        /// Market price an hour ago (Linear/Inverse only)
        /// </summary>
        [JsonProperty("prevPrice1h")]
        public string? PrevPrice1h { get; set; }

        /// <summary>
        /// Mark price (Linear/Inverse/Option)
        /// </summary>
        [JsonProperty("markPrice")]
        public string? MarkPrice { get; set; }

        /// <summary>
        /// Index price (Linear/Inverse/Option)
        /// </summary>
        [JsonProperty("indexPrice")]
        public string? IndexPrice { get; set; }

        /// <summary>
        /// Open interest size (Linear/Inverse/Option)
        /// </summary>
        [JsonProperty("openInterest")]
        public string? OpenInterest { get; set; }

        /// <summary>
        /// Open interest value (Linear/Inverse only)
        /// </summary>
        [JsonProperty("openInterestValue")]
        public string? OpenInterestValue { get; set; }

        /// <summary>
        /// Funding rate (Linear/Inverse Perpetual only)
        /// </summary>
        [JsonProperty("fundingRate")]
        public string? FundingRate { get; set; }

        /// <summary>
        /// Next funding time (ms) (Linear/Inverse Perpetual only)
        /// </summary>
        [JsonProperty("nextFundingTime")]
        public string? NextFundingTime { get; set; }

        /// <summary>
        /// Funding interval hour (Linear/Inverse Perpetual only)
        /// </summary>
        [JsonProperty("fundingIntervalHour")]
        public string? FundingIntervalHour { get; set; }

        /// <summary>
        /// Funding cap (Linear/Inverse Perpetual only)
        /// </summary>
        [JsonProperty("fundingCap")]
        public string? FundingCap { get; set; }

        /// <summary>
        /// Best bid price (Linear/Inverse/Spot)
        /// </summary>
        [JsonProperty("bid1Price")]
        public string? Bid1Price { get; set; }

        /// <summary>
        /// Best bid size (Linear/Inverse/Spot)
        /// </summary>
        [JsonProperty("bid1Size")]
        public string? Bid1Size { get; set; }

        /// <summary>
        /// Best ask price (Linear/Inverse/Spot)
        /// </summary>
        [JsonProperty("ask1Price")]
        public string? Ask1Price { get; set; }

        /// <summary>
        /// Best ask size (Linear/Inverse/Spot)
        /// </summary>
        [JsonProperty("ask1Size")]
        public string? Ask1Size { get; set; }

        // === Futures specific fields ===

        /// <summary>
        /// Delivery time (UTC) (Futures only)
        /// </summary>
        [JsonProperty("deliveryTime")]
        public string? DeliveryTime { get; set; }

        /// <summary>
        /// Basis rate (Futures only)
        /// </summary>
        [JsonProperty("basisRate")]
        public string? BasisRate { get; set; }

        /// <summary>
        /// Basis rate annualized (Futures only)
        /// </summary>
        [JsonProperty("basisRateYear")]
        public string? BasisRateYear { get; set; }

        /// <summary>
        /// Delivery fee rate (Futures only)
        /// </summary>
        [JsonProperty("deliveryFeeRate")]
        public string? DeliveryFeeRate { get; set; }

        /// <summary>
        /// Predicted delivery price (Futures only)
        /// </summary>
        [JsonProperty("predictedDeliveryPrice")]
        public string? PredictedDeliveryPrice { get; set; }

        /// <summary>
        /// Basis (Futures only)
        /// </summary>
        [JsonProperty("basis")]
        public string? Basis { get; set; }

        // === PreLaunch specific fields ===

        /// <summary>
        /// Pre-open price (PreLaunch only)
        /// </summary>
        [JsonProperty("preOpenPrice")]
        public string? PreOpenPrice { get; set; }

        /// <summary>
        /// Pre-open qty (PreLaunch only)
        /// </summary>
        [JsonProperty("preQty")]
        public string? PreQty { get; set; }

        /// <summary>
        /// Current pre-listing phase (PreLaunch only)
        /// </summary>
        [JsonProperty("curPreListingPhase")]
        public string? CurPreListingPhase { get; set; }

        // === Option specific fields ===

        /// <summary>
        /// Best bid price (Option only — uses "bidPrice" instead of "bid1Price")
        /// </summary>
        [JsonProperty("bidPrice")]
        public string? BidPrice { get; set; }

        /// <summary>
        /// Best bid size (Option only — uses "bidSize" instead of "bid1Size")
        /// </summary>
        [JsonProperty("bidSize")]
        public string? BidSize { get; set; }

        /// <summary>
        /// Best bid IV (Option only)
        /// </summary>
        [JsonProperty("bidIv")]
        public string? BidIv { get; set; }

        /// <summary>
        /// Best ask price (Option only — uses "askPrice" instead of "ask1Price")
        /// </summary>
        [JsonProperty("askPrice")]
        public string? AskPrice { get; set; }

        /// <summary>
        /// Best ask size (Option only — uses "askSize" instead of "ask1Size")
        /// </summary>
        [JsonProperty("askSize")]
        public string? AskSize { get; set; }

        /// <summary>
        /// Best ask IV (Option only)
        /// </summary>
        [JsonProperty("askIv")]
        public string? AskIv { get; set; }

        /// <summary>
        /// Mark price IV (Option only)
        /// </summary>
        [JsonProperty("markPriceIv")]
        public string? MarkPriceIv { get; set; }

        /// <summary>
        /// Underlying price (Option only)
        /// </summary>
        [JsonProperty("underlyingPrice")]
        public string? UnderlyingPrice { get; set; }

        /// <summary>
        /// Total volume (Option only)
        /// </summary>
        [JsonProperty("totalVolume")]
        public string? TotalVolume { get; set; }

        /// <summary>
        /// Total turnover (Option only)
        /// </summary>
        [JsonProperty("totalTurnover")]
        public string? TotalTurnover { get; set; }

        /// <summary>
        /// Delta (Option only)
        /// </summary>
        [JsonProperty("delta")]
        public string? Delta { get; set; }

        /// <summary>
        /// Gamma (Option only)
        /// </summary>
        [JsonProperty("gamma")]
        public string? Gamma { get; set; }

        /// <summary>
        /// Vega (Option only)
        /// </summary>
        [JsonProperty("vega")]
        public string? Vega { get; set; }

        /// <summary>
        /// Theta (Option only)
        /// </summary>
        [JsonProperty("theta")]
        public string? Theta { get; set; }

        /// <summary>
        /// Change in last 24h (Option only)
        /// </summary>
        [JsonProperty("change24h")]
        public string? Change24h { get; set; }

        // === Spot specific fields ===

        /// <summary>
        /// USD index price (Spot only)
        /// </summary>
        [JsonProperty("usdIndexPrice")]
        public string? UsdIndexPrice { get; set; }
    }
}
