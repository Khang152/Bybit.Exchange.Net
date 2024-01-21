using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bybit.Exchange.Net.Models.Common
{
    public class BybitResponse<R>
    {
        /// <summary>
        /// Success = 0 / Error code
        /// </summary>
        public double RetCode { get; set; } = default!;

        /// <summary>
        /// Success/Error msg. OK, success, SUCCESS, "" indicate a successful response
        /// </summary>
        public string RetMsg { get; set; } = default!;

        /// <summary>
        /// Business data result
        /// </summary>
        public R? Result { get; set; } = default!;

        /// <summary>
        /// Extend info. Most of the time it is {}
        /// </summary>
        public dynamic RetExtInfo { get; set; } = default!;

        /// <summary>
        /// Current timestamp (ms)
        /// </summary>
        public double Time { get; set; } = default!;

        /// <summary>
        /// Raw Response
        /// </summary>
        public string? Raw { get; set; } = default!;

        /// <summary>
        /// Error When Try Parse Result
        /// </summary>
        public Errors? Errors { get; set; } = default!;
    }

    public class Errors
    {
        public string? Message { get; set; } = default!;
        public string? StackTrace { get; set; } = default!;
    }
}