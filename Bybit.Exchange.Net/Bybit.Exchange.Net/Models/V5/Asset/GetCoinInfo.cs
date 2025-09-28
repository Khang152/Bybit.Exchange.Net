using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Asset
{
    public class GetCoinInfoRequest
    {
        /// <summary>
        /// Coin symbol, uppercase only (e.g., BTC, ETH). Optional.
        /// </summary>
        public string? coin { get; set; }
    }
    public class GetCoinInfoResponse
    {
        /// <summary>
        /// List of coin information rows.
        /// </summary>
        public List<CoinInfo_GetCoinInfo> Rows { get; set; } = new();
    }

    public class CoinInfo_GetCoinInfo
    {
        /// <summary>
        /// Coin name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Coin symbol.
        /// </summary>
        public string Coin { get; set; } = string.Empty;

        /// <summary>
        /// Maximum withdraw amount per transaction.
        /// </summary>
        public string RemainAmount { get; set; } = string.Empty;

        /// <summary>
        /// Available chains for this coin.
        /// </summary>
        public List<CoinChain_GetCoinInfo> Chains { get; set; } = new();
    }

    public class CoinChain_GetCoinInfo
    {
        /// <summary>
        /// Chain name.
        /// </summary>
        public string Chain { get; set; } = string.Empty;

        /// <summary>
        /// Chain type.
        /// </summary>
        public string ChainType { get; set; } = string.Empty;

        /// <summary>
        /// Number of confirmations required for deposit.
        /// </summary>
        public string Confirmation { get; set; } = string.Empty;

        /// <summary>
        /// Withdraw fee. Empty means this coin does not support withdrawal.
        /// </summary>
        public string WithdrawFee { get; set; } = string.Empty;

        /// <summary>
        /// Minimum deposit amount.
        /// </summary>
        public string DepositMin { get; set; } = string.Empty;

        /// <summary>
        /// Minimum withdraw amount.
        /// </summary>
        public string WithdrawMin { get; set; } = string.Empty;

        /// <summary>
        /// Precision for withdraw or deposit.
        /// </summary>
        public string MinAccuracy { get; set; } = string.Empty;

        /// <summary>
        /// Deposit status for this chain. 0 = suspend, 1 = normal.
        /// </summary>
        public string ChainDeposit { get; set; } = string.Empty;

        /// <summary>
        /// Withdraw status for this chain. 0 = suspend, 1 = normal.
        /// </summary>
        public string ChainWithdraw { get; set; } = string.Empty;

        /// <summary>
        /// Withdraw fee percentage. Example: 0.022 means 2.2%.
        /// </summary>
        public string WithdrawPercentageFee { get; set; } = string.Empty;

        /// <summary>
        /// Contract address. Empty string means no contract address.
        /// </summary>
        public string ContractAddress { get; set; } = string.Empty;

        /// <summary>
        /// Number of security confirmations required to fully unlock funds for withdrawal.
        /// </summary>
        public string SafeConfirmNumber { get; set; } = string.Empty;
    }
}
