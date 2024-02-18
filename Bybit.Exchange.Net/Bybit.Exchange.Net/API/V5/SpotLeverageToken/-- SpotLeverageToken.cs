using Bybit.Exchange.Net.Models.Common;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class SpotLeverageToken
            {
                private BybitRestOptions Options { get; set; } = default!;

                public SpotLeverageToken(BybitRestOptions options)
                {
                    Options = options;
                }
            }
        }
    }
}