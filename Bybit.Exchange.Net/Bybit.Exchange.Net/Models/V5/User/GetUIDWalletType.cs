using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.User
{
    public class GetUIDWalletTypeRequest
    {
        /// <summary>
        /// Sub account member IDs (comma-separated).  
        /// <para>If not passed, query will return wallet types of the caller itself.</para>
        /// <para>When using a master API key to query sub UIDs, the master UID data is always returned at the top of the array.</para>
        /// <para>Multiple sub UIDs are supported, separated by commas.</para>
        /// <para>This parameter is ignored when using a sub account API key.</para>
        /// </summary>
        public string? memberIds { get; set; }
    }
    public class GetUIDWalletTypeResponse
    {
        /// <summary>
        /// List of accounts with wallet types.
        /// </summary>
        public List<AccountInfo_GetUIDWalletType> Accounts { get; set; } = new();
    }

    public class AccountInfo_GetUIDWalletType
    {
        /// <summary>
        /// Master or Sub user ID.
        /// </summary>
        public string UID { get; set; } = string.Empty;

        /// <summary>
        /// Wallet types associated with the user.
        /// <para>Possible values: SPOT, CONTRACT, FUND, OPTION, UNIFIED</para>
        /// </summary>
        public List<AccountType>? AccountType { get; set; } = new();
    }
}
