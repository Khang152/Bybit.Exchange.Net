using Bybit.Exchange.Net.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bybit.Exchange.Net.API.V5.BybitRestClient;

namespace Bybit.Exchange.Net.Library.Interface
{
    public interface IBybitRestClient
    {
        Market Market { get; set; }
        Trade Trade { get; set; }
        BybitRestOptions Options { get; set; }
    }
}