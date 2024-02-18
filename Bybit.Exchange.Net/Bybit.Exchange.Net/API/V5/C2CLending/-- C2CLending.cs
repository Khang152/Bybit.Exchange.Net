using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Broker;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class C2CLending
            {
                private BybitRestOptions Options { get; set; } = default!;

                public C2CLending(BybitRestOptions options)
                {
                    Options = options;
                }
            }
        }
    }
}