using Newtonsoft.Json;

namespace Bybit.Exchange.Net.Models.V5.WebSocket.Private
{
    /// <summary>
    /// Private wallet stream data model.
    /// Topic: wallet
    /// </summary>
    public class WalletStreamData
    {
        [JsonProperty("accountType")]
        public string AccountType { get; set; } = default!;

        [JsonProperty("accountIMRate")]
        public string AccountIMRate { get; set; } = default!;

        [JsonProperty("accountIMRateByMp")]
        public string AccountIMRateByMp { get; set; } = default!;

        [JsonProperty("accountMMRate")]
        public string AccountMMRate { get; set; } = default!;

        [JsonProperty("accountMMRateByMp")]
        public string AccountMMRateByMp { get; set; } = default!;

        [JsonProperty("totalEquity")]
        public string TotalEquity { get; set; } = default!;

        [JsonProperty("totalWalletBalance")]
        public string TotalWalletBalance { get; set; } = default!;

        [JsonProperty("totalMarginBalance")]
        public string TotalMarginBalance { get; set; } = default!;

        [JsonProperty("totalAvailableBalance")]
        public string TotalAvailableBalance { get; set; } = default!;

        [JsonProperty("totalPerpUPL")]
        public string TotalPerpUPL { get; set; } = default!;

        [JsonProperty("totalInitialMargin")]
        public string TotalInitialMargin { get; set; } = default!;

        [JsonProperty("totalInitialMarginByMp")]
        public string TotalInitialMarginByMp { get; set; } = default!;

        [JsonProperty("totalMaintenanceMargin")]
        public string TotalMaintenanceMargin { get; set; } = default!;

        [JsonProperty("totalMaintenanceMarginByMp")]
        public string TotalMaintenanceMarginByMp { get; set; } = default!;

        [JsonProperty("accountLTV")]
        public string AccountLTV { get; set; } = default!;

        /// <summary>
        /// Coin details for the wallet
        /// </summary>
        [JsonProperty("coin")]
        public List<WalletCoinData> Coin { get; set; } = default!;
    }

    /// <summary>
    /// Individual coin data within the wallet stream
    /// </summary>
    public class WalletCoinData
    {
        [JsonProperty("coin")]
        public string Coin { get; set; } = default!;

        [JsonProperty("equity")]
        public string Equity { get; set; } = default!;

        [JsonProperty("usdValue")]
        public string UsdValue { get; set; } = default!;

        [JsonProperty("walletBalance")]
        public string WalletBalance { get; set; } = default!;

        [JsonProperty("availableToWithdraw")]
        public string AvailableToWithdraw { get; set; } = default!;

        [JsonProperty("availableToBorrow")]
        public string AvailableToBorrow { get; set; } = default!;

        [JsonProperty("borrowAmount")]
        public string BorrowAmount { get; set; } = default!;

        [JsonProperty("accruedInterest")]
        public string AccruedInterest { get; set; } = default!;

        [JsonProperty("totalOrderIM")]
        public string TotalOrderIM { get; set; } = default!;

        [JsonProperty("totalPositionIM")]
        public string TotalPositionIM { get; set; } = default!;

        [JsonProperty("totalPositionMM")]
        public string TotalPositionMM { get; set; } = default!;

        [JsonProperty("unrealisedPnl")]
        public string UnrealisedPnl { get; set; } = default!;

        [JsonProperty("cumRealisedPnl")]
        public string CumRealisedPnl { get; set; } = default!;

        [JsonProperty("bonus")]
        public string Bonus { get; set; } = default!;

        [JsonProperty("collateralSwitch")]
        public bool? CollateralSwitch { get; set; } = default!;

        [JsonProperty("marginCollateral")]
        public bool? MarginCollateral { get; set; } = default!;

        [JsonProperty("locked")]
        public string Locked { get; set; } = default!;

        [JsonProperty("spotHedgingQty")]
        public string SpotHedgingQty { get; set; } = default!;

        [JsonProperty("spotBorrow")]
        public string SpotBorrow { get; set; } = default!;
    }
}
