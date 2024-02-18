using Bybit.Exchange.Net.Models.Common;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Account
            {
                private BybitRestOptions Options { get; set; } = default!;

                public Account(BybitRestOptions options)
                {
                    Options = options;
                }
            }
        }
    }
}