using Bybit.Exchange.Net.Models.Common;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Broker
        {
            private BybitRestOptions Options { get; set; } = default!;

            public Broker(BybitRestOptions options)
            {
                Options = options;
            }
        }
    }
}