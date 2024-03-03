using Bybit.Exchange.Net.Models.Common;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class InstitutionalLoan
            {
                private BybitRestOptions Options { get; set; } = default!;

                public InstitutionalLoan(BybitRestOptions options)
                {
                    Options = options;
                }
            }
        }
    }
}
