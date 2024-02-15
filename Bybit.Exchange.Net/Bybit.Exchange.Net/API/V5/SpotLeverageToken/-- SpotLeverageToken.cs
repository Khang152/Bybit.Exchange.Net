using Bybit.Exchange.Net.Models.Common;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
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