using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bybit.Exchange.Net.Models.Common
{
    public static class BybitBaseDomain
    {
        // === REST API ===
        public const string Mainnet = "https://api.bybit.com";
        public const string Demo = "https://api-demo.bybit.com";
        public const string Testnet = "https://api-testnet.bybit.com";
        public const string MainnetBackup = "https://api.bytick.com";

        // === MAINNET WebSocket ===
        public const string WsMainnetPrivate = "wss://stream.bybit.com/v5/private";
        public const string WsMainnetTrade = "wss://stream.bybit.com/v5/trade";

        // === TESTNET WebSocket ===
        public const string WsTestnetPrivate = "wss://stream-testnet.bybit.com/v5/private";
        public const string WsTestnetTrade = "wss://stream-testnet.bybit.com/v5/trade";

        // === DEMO WebSocket ===
        // Demo only supports private streams; public data uses mainnet; WS Trade NOT supported
        public const string WsDemoPrivate = "wss://stream-demo.bybit.com/v5/private";
    }
}