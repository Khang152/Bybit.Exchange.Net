using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Account
{
    public class GetWalletBalanceRequest
    {
        /// <summary>
        /// <value>Property <c>accountType</c></value>
        /// <remarks>
        /// | Account type:
        /// </remarks>
        /// <list type="bullet">
        /// <item>
        /// <term>Unified account</term>
        /// <description>
        /// UNIFIED (trade spot/linear/options), CONTRACT(trade inverse)
        /// </description>
        /// </item>
        /// <item>
        /// <term>Classic account</term>
        /// <description>
        /// CONTRACT, SPOT
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        public AccountType? accountType { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>coin</c></value>
        /// <remarks>
        /// | Comments:
        /// </remarks>
        /// <para>
        /// If not passed, it returns non-zero asset info
        /// </para>
        /// <para>
        /// You can pass multiple coins to query, separated by comma. USDT, USDC
        /// </para>
        /// </summary>
        public string coin { get; set; } = default!;
    }

    public class GetWalletBalanceResponse
    {
        /// <summary>
        /// <value>Property <c>List</c></value>
        /// <para>
        /// The Array object
        /// </para>
        /// </summary>
        public List<WalletBalanceItem> List { get; set; } = default!;

        public class WalletBalanceItem
        {
            /// <summary>
            /// <value>Property <c>AccountType</c></value>
            /// <remarks>
            /// | Account type:
            /// </remarks>
            /// <list type="bullet">
            /// <item>
            /// <term>Unified account</term>
            /// <description>
            /// UNIFIED (trade spot/linear/options), CONTRACT(trade inverse)
            /// </description>
            /// </item>
            /// <item>
            /// <term>Classic account</term>
            /// <description>
            /// CONTRACT, SPOT
            /// </description>
            /// </item>
            /// </list>
            /// </summary>
            public AccountType? AccountType { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>AccountLTV</c></value>
            /// <remarks>
            /// This field has been depreciated
            /// </remarks>
            /// </summary>
            public string AccountLTV { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>AccountIMRate</c></value>
            /// <remarks>
            /// Initial Margin Rate: Account Total Initial Margin Base Coin / Account Margin Balance Base Coin.
            /// In non-unified mode &amp; unified (inverse) &amp; unified (isolated_margin), the field will be returned as an empty string.
            /// </remarks>
            /// </summary>
            public string AccountIMRate { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>AccountMMRate</c></value>
            /// <remarks>
            /// Maintenance Margin Rate: Account Total Maintenance Margin Base Coin / Account Margin Balance Base Coin.
            /// In non-unified mode &amp; unified (inverse) &amp; unified (isolated_margin), the field will be returned as an empty string.
            /// </remarks>
            /// </summary>
            public string AccountMMRate { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>TotalEquity</c></value>
            /// <remarks>
            /// Total Equity is calculated by adding the fiat currency valuation of the equity of each coin in your account.
            /// In non-unified mode &amp; unified (inverse), the field will be returned as an empty string.
            /// </remarks>
            /// </summary>
            public string TotalEquity { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>TotalWalletBalance</c></value>
            /// <remarks>
            /// Wallet Balance of account converted to usd：∑ Asset Wallet Balance By USD value of each asset。
            /// In non-unified mode &amp; unified (inverse) &amp; unified (isolated_margin), the field will be returned as an empty string.
            /// </remarks>
            /// </summary>
            public string TotalWalletBalance { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>TotalMarginBalance</c></value>
            /// <remarks>
            /// Margin Balance of account converted to usd：totalWalletBalance + totalPerpUPL.
            /// In non-unified mode &amp; unified (inverse) &amp; unified (isolated_margin), the field will be returned as an empty string.
            /// </remarks>
            /// </summary>
            public string TotalMarginBalance { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>TotalAvailableBalance</c></value>
            /// <remarks>
            /// Available Balance of account converted to usd：Regular mode：totalMarginBalance - totalInitialMargin.
            /// In non-unified mode &amp; unified (inverse) &amp; unified (isolated_margin), the field will be returned as an empty string.
            /// </remarks>
            /// </summary>
            public string TotalAvailableBalance { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>TotalPerpUPL</c></value>
            /// <remarks>
            /// Unrealised P&amp;L of Perpetuals and USDC Futures of account converted to usd：∑ Each Perp and USDC Futures upl by base coin.
            /// In non-unified mode &amp; unified (inverse), the field will be returned as an empty string.
            /// </remarks>
            /// </summary>
            public string TotalPerpUPL { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>TotalInitialMargin</c></value>
            /// <remarks>
            /// Initial Margin of account converted to usd：∑ Asset Total Initial Margin Base Coin.
            /// In non-unified mode &amp; unified (inverse) &amp; unified (isolated_margin), the field will be returned as an empty string.
            /// </remarks>
            /// </summary>
            public string TotalInitialMargin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>TotalMaintenanceMargin</c></value>
            /// <remarks>
            /// Maintenance Margin of account converted to usd: ∑ Asset Total Maintenance Margin Base Coin.
            /// In non-unified mode &amp; unified (inverse) &amp; unified (isolated_margin), the field will be returned as an empty string.
            /// </remarks>
            /// </summary>
            public string TotalMaintenanceMargin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>Coin</c></value>
            /// <para>
            /// The Array object
            /// </para>
            /// </summary>
            public List<CoinItem> Coin { get; set; } = default!;
        }

        public class CoinItem
        {
            /// <summary>
            /// <value>Property <c>Coin</c></value>
            /// <para>
            /// Coin name, such as BTC, ETH, USDT, USDC
            /// </para>
            /// </summary>
            public string Coin { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>Equity</c></value>
            /// <para>
            /// Equity of current coin
            /// </para>
            /// </summary>
            public string Equity { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>UsdValue</c></value>
            /// <para>
            /// USD value of current coin
            /// </para>
            /// </summary>
            public string UsdValue { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>WalletBalance</c></value>
            /// <para>
            /// Wallet balance of current coin
            /// </para>
            /// </summary>
            public string WalletBalance { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>Free</c></value>
            /// <para>
            /// Available balance for Spot wallet. This is a unique field for Classic SPOT
            /// </para>
            /// </summary>
            public string Free { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>Locked</c></value>
            /// <para>
            /// Locked balance due to the Spot open order
            /// </para>
            /// </summary>
            public string Locked { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>SpotHedgingQty</c></value>
            /// <para>
            /// The spot asset qty that is used to hedge in the portfolio margin, truncate to 8 decimals and "0" by default
            /// This is a unique field for Unified account
            /// </para>
            /// </summary>
            public string SpotHedgingQty { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>BorrowAmount</c></value>
            /// <para>
            /// Borrow amount of current coin
            /// </para>
            /// </summary>
            public string BorrowAmount { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>AvailableToBorrow</c></value>
            /// <remarks>
            /// Depreciated field, always return "" due to feature of main-sub UID sharing borrow quota.
            /// Please refer to availableToBorrow in the Get Collateral Info
            /// </remarks>
            /// </summary>
            public string AvailableToBorrow { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>AvailableToWithdraw</c></value>
            /// <para>
            /// Available amount to withdraw of current coin
            /// </para>
            /// </summary>
            public string AvailableToWithdraw { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>AccruedInterest</c></value>
            /// <para>
            /// Accrued interest
            /// </para>
            /// </summary>
            public string AccruedInterest { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>TotalOrderIM</c></value>
            /// <para>
            /// Pre-occupied margin for order. For portfolio margin mode, it returns ""
            /// </para>
            /// </summary>
            public string TotalOrderIM { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>TotalPositionIM</c></value>
            /// <para>
            /// Sum of initial margin of all positions + Pre-occupied liquidation fee.
            /// For portfolio margin mode, it returns ""
            /// </para>
            /// </summary>
            public string TotalPositionIM { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>TotalPositionMM</c></value>
            /// <para>
            /// Sum of maintenance margin for all positions. For portfolio margin mode, it returns ""
            /// </para>
            /// </summary>
            public string TotalPositionMM { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>UnrealisedPnl</c></value>
            /// <para>
            /// Unrealised P&amp;L
            /// </para>
            /// </summary>
            public string UnrealisedPnl { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>CumRealisedPnl</c></value>
            /// <para>
            /// Cumulative Realised P&amp;L
            /// </para>
            /// </summary>
            public string CumRealisedPnl { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>Bonus</c></value>
            /// <para>
            /// Bonus. This is a unique field for UNIFIED account
            /// </para>
            /// </summary>
            public string Bonus { get; set; } = default!;

            /// <summary>
            /// <value>Property <c>MarginCollateral</c></value>
            /// <para>
            /// Whether it can be used as a margin collateral currency (platform), true: YES, false: NO
            /// When marginCollateral=false, then collateralSwitch is meaningless
            /// </para>
            /// </summary>
            public bool? MarginCollateral { get; set; }

            /// <summary>
            /// <value>Property <c>CollateralSwitch</c></value>
            /// <para>
            /// Whether the collateral is turned on by user (user), true: ON, false: OFF
            /// When marginCollateral=true, then collateralSwitch is meaningful
            /// </para>
            /// </summary>
            public bool? CollateralSwitch { get; set; }
        }
    }
}