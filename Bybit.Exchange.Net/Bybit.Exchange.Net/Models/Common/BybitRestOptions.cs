using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.Common
{
    public class BybitRestOptions
    {
        public ByBitCredentials Credentials { get; set; } = default!;
        public BybitEnvironment Environment { get; set; } = default!;
        public string BaseURL { get; set; } = default!;
        public string RecvWindow { get; set; } = default!;

        public BybitRestOptions()
        {
            Environment = BybitEnvironment.Live;
            RecvWindow = "5000";
        }
    }
}