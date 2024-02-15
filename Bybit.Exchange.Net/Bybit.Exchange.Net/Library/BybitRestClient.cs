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
        public SpotLeverageToken SpotLeverageToken { get; set; } = default!;
        public C2CLending C2CLending { get; set; } = default!;
        public Broker Broker { get; set; } = default!;

        public BybitRestOptions Options { get; set; } = default!;

        public BybitRestClient()
        {
            Options = new BybitRestOptions();
            Market = new Market(Options);
            Trade = new Trade(Options);
            Account = new Account(Options);
            SpotLeverageToken = new SpotLeverageToken(Options);
            C2CLending = new C2CLending(Options);
            Broker = new Broker(Options);
        }

        public BybitRestClient(BybitRestOptions options)
        {
            options ??= new BybitRestOptions();
            Options = options;
            Market = new Market(options);
            Trade = new Trade(options);
            Account = new Account(options);
            SpotLeverageToken = new SpotLeverageToken(options);
            C2CLending = new C2CLending(options);
            Broker = new Broker(options);
        }
    }
}