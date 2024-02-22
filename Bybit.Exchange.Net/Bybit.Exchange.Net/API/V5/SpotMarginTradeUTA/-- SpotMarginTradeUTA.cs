using Bybit.Exchange.Net.Models.Common;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class SpotMarginTradeUTA
            {
                private BybitRestOptions Options { get; set; } = default!;

                public SpotMarginTradeUTA(BybitRestOptions options)
                {
                    Options = options;
                }
            }
        }
    }
}