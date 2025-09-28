using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Asset
{
    public class GetSubUIDRequest
    {

    }

    public class GetSubUIDResponse
    {
        /// <summary>
        /// All sub UIDs under the main UID.
        /// </summary>
        public List<string> subMemberIds { get; set; } = new();

        /// <summary>
        /// All sub UIDs that have universal transfer enabled.
        /// </summary>
        public List<string> transferableSubMemberIds { get; set; } = new();
    }
}
