using Bybit.Exchange.Net.Library.Interface;
using Bybit.Exchange.Net.Models.Common;
using static Bybit.Exchange.Net.API.V5.BybitRestClient;

namespace Bybit.Exchange.Net.Library
{
    public partial class BybitRestClient : IBybitRestClient
    {
        public Market Market { get; set; } = default!;
        public Trade Trade { get; set; } = default!;
        public Account Account { get; set; } = default!;
        public BybitRestOptions Options { get; set; } = default!;

        public BybitRestClient(BybitRestOptions options)
        {
            options ??= new BybitRestOptions();
            Options = options;
            Market = new Market(options);
            Trade = new Trade(options);
            Account = new Account(options);
        }
    }
}