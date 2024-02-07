﻿using Bybit.Exchange.Net.Models.Common;

namespace Bybit.Exchange.Net.API.V5
{
    public partial class BybitRestClient
    {
        public partial class Account
        {
            private BybitRestOptions Options { get; set; } = default!;

            public Account(BybitRestOptions options)
            {
                Options = options;
            }
        }
    }
}