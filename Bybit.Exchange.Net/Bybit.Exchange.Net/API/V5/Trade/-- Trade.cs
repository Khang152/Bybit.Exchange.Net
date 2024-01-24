using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Trade
        {
            private BybitRestOptions Options { get; set; } = default!;

            public Trade(BybitRestOptions options)
            {
                Options = options;
            }
        }
    }
}