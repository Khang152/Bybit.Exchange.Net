using Bybit.Exchange.Net.API;
using Bybit.Exchange.Net.Library.Interface;
using Bybit.Exchange.Net.Models.Common;

namespace Bybit.Exchange.Net.Library
{
    public partial class BybitRestClient : IBybitRestClient
    {
        public V5 V5 { get; set; } = default!;

        public BybitRestOptions Options { get; set; } = default!;

        public BybitRestClient()
        {
            Options = new BybitRestOptions();
            V5 = new V5(Options);
        }

        public BybitRestClient(BybitRestOptions options)
        {
            options ??= new BybitRestOptions();
            Options = options;
            V5 = new V5(Options);
        }
    }
}