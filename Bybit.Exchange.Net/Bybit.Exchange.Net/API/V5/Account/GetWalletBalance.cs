﻿using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Models.Common;
using Bybit.Exchange.Net.Models.V5.Account;

namespace Bybit.Exchange.Net.API
{
    public partial class V5
    {
        public partial class Endpoint
        {
            public partial class Account
            {
                private string GetWalletBalanceUrl { get; set; } = "/v5/account/wallet-balance";

                public async Task<BybitResponse<GetWalletBalanceResponse>> GetWalletBalanceAsync(GetWalletBalanceRequest requestData)
                {
                    var requestUrl = Utils.GetUrl(Options, GetWalletBalanceUrl);
                    var response = await Utils.GetData(Options, requestUrl, requestData);
                    var results = Utils.GetResponse<GetWalletBalanceResponse>(response);
                    return results;
                }
            }
        }
    }
}