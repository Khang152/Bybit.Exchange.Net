using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.Common
{
    public class ByBitCredentials
    {
        public string Key { get; set; } = default!;
        public string Secret { get; set; } = default!;

        public ByBitCredentials(string key, string secret)
        {
            Secret = secret;
            Key = key;
        }
    }
}