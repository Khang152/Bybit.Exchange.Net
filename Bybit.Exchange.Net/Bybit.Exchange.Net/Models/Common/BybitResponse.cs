using System.Net.Http.Headers;

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
        public double? Time { get; set; } = default!;

        /// <summary>
        /// Error When Try Parse Result
        /// </summary>
        public Exceptions? Exceptions { get; set; } = default!;

        /// <summary>
        /// Raw Information
        /// </summary>
        public BybitResponse? Infomation { get; set; } = default!;
    }

    public class BybitResponse
    {
        /// <summary>
        /// Header Response
        /// </summary>
        public Dictionary<string, IEnumerable<string>>? Header { get; set; } = default!;

        /// <summary>
        /// Response
        /// </summary>
        public string? Response { get; set; } = default!;

        /// <summary>
        /// Request
        /// </summary>
        public string? Request { get; set; } = default!;
    }

    public class Exceptions
    {
        public string? Message { get; set; } = default!;
        public string? StackTrace { get; set; } = default!;
    }
}