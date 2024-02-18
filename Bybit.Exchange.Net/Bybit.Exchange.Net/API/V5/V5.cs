using Bybit.Exchange.Net.Models.Common;
using static Bybit.Exchange.Net.API.V5.Endpoint;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public Market Market { get; set; } = default!;
        public Trade Trade { get; set; } = default!;
        public Account Account { get; set; } = default!;
        public SpotLeverageToken SpotLeverageToken { get; set; } = default!;
        public C2CLending C2CLending { get; set; } = default!;
        public Broker Broker { get; set; } = default!;

        private BybitRestOptions Options { get; set; } = default!;

        public V5()
        {
            Options = new BybitRestOptions();
            Market = new Market(Options);
            Trade = new Trade(Options);
            Account = new Account(Options);
            SpotLeverageToken = new SpotLeverageToken(Options);
            C2CLending = new C2CLending(Options);
            Broker = new Broker(Options);
        }

        public V5(BybitRestOptions options)
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