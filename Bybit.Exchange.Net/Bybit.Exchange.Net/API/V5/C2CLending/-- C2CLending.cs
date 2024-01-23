using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class C2CLending
        {
            private BybitRestOptions Options { get; set; } = default!;
            private BybitUtils Utils { get; set; } = default!;

            public C2CLending(BybitRestOptions options)
            {
                Options = options;
                Utils = new BybitUtils(options);
            }
        }
    }
}