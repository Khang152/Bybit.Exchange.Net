using Bybit.Exchange.Net.Library;
using Bybit.Exchange.Net.Library.Interface;
using Bybit.Exchange.Net.Models.Common;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bybit.Exchange.Net.Extensions
{
    public static class BybitExtension
    {
        public static IServiceCollection AddBybitExchange(this IServiceCollection services, BybitRestOptions? restOptions = null)
        {
            if (restOptions != null)
            {
                services.AddTransient<IBybitRestClient, BybitRestClient>(provider =>
                {
                    return new BybitRestClient(restOptions);
                });
            }

            return services;
        }
    }
}