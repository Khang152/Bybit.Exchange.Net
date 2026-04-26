using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.Common
{
    public class BybitWebSocketOptions
    {
        /// <summary>
        /// API credentials for authenticated streams
        /// </summary>
        public ByBitCredentials Credentials { get; set; } = default!;

        /// <summary>
        /// Trading environment (Live, Demo, Testnet)
        /// </summary>
        public BybitEnvironment Environment { get; set; } = default!;

        /// <summary>
        /// Ping interval in seconds to keep the connection alive. Default: 20
        /// </summary>
        public int PingIntervalSeconds { get; set; } = default!;

        /// <summary>
        /// Whether to automatically reconnect on disconnection. Default: true
        /// </summary>
        public bool AutoReconnect { get; set; } = default!;

        /// <summary>
        /// Delay in milliseconds between reconnection attempts. Default: 5000
        /// </summary>
        public int ReconnectDelayMs { get; set; } = default!;

        /// <summary>
        /// Maximum number of reconnection attempts. Default: 10
        /// </summary>
        public int MaxReconnectAttempts { get; set; } = default!;

        public BybitWebSocketOptions()
        {
            Environment = BybitEnvironment.Live;
            PingIntervalSeconds = 20;
            AutoReconnect = true;
            ReconnectDelayMs = 5000;
            MaxReconnectAttempts = 10;
        }
    }
}
