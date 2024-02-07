using Bybit.Exchange.Net.Models.Common;
using static Bybit.Exchange.Net.API.V5.BybitRestClient;

namespace Bybit.Exchange.Net.Library.Interface
{
    public interface IBybitRestClient
    {
        Market Market { get; set; }
        Trade Trade { get; set; }
        Account Account { get; set; }
        C2CLending C2CLending { get; set; }
        Broker Broker { get; set; }
        BybitRestOptions Options { get; set; }
    }
}