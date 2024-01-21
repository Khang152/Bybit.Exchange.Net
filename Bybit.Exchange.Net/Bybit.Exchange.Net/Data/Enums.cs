using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Bybit.Exchange.Net.Data
{
    public class Enums
    {
        public enum BybitEnvironment
        {
            [Description("Live")]
            Live = 0,

            [Description("Testnet")]
            Testnet = 1,
        };

        public enum Category
        {
            [EnumMember(Value = "spot")]
            Spot = 0,

            [EnumMember(Value = "linear")]
            Linear = 1,

            [EnumMember(Value = "inverse")]
            Inverse = 2,

            [EnumMember(Value = "option")]
            Option = 3,
        };

        public enum OrderStatus
        {
            Created,
            New,
            Rejected,
            PartiallyFilled,
            PartiallyFilledCanceled,
            Filled,
            Cancelled,
            Untriggered,
            Triggered,
            Deactivated
        }

        public enum PositionIdx
        {
            OnewayMode = 0,
            BuySideOfHedgeMode = 1,
            SellSideOfHedgeMode = 2,
        };

        public enum TriggerDirection
        {
            None = 0,
            Rise = 1,
            Fall = 2,
        };

        public enum CreateType
        {
            CreateByUser,
            CreateByAdminClosing,
            CreateByStopOrder,             // Futures conditional order
            CreateByTakeProfit,           // Futures take profit order
            CreateByPartialTakeProfit,    // Futures partial take profit order
            CreateByStopLoss,             // Futures stop loss order
            CreateByPartialStopLoss,      // Futures partial stop loss order
            CreateByTrailingStop,         // Futures trailing stop order
            CreateByLiq,                  // Laddered liquidation to reduce the required maintenance margin
            CreateByTakeOver_PassThrough, // If the position is still subject to liquidation (i.e., does not meet the required maintenance margin level), the position shall be taken over by the liquidation engine and closed at the bankruptcy price.
            CreateByAdl_PassThrough,      // Auto-Deleveraging(ADL)
            CreateByBlock_PassThrough,    // Order placed via Paradigm
            CreateByBlockTradeMovePosition_PassThrough, // Order created by move position
            CreateByClosing,              // The close order placed via web or app position area - web/app
            CreateByFGridBot,             // Order created via grid bot - web/app
            CloseByFGridBot,              // Order closed via grid bot - web/app
            CreateByTWAP,                 // Order created by TWAP - web/app
            CreateByTVSignal,             // Order created by TV webhook - web/app
            CreateByMmRateClose,          // Order created by Mm rate close function - web/app
            CreateByMartingaleBot,        // Order created by Martingale bot - web/app
            CloseByMartingaleBot,         // Order closed by Martingale bot - web/app
            CreateByIceBerg,              // Order created by Ice berg strategy - web/app
            CreateByArbitrage             // Order created by arbitrage - web/app
        }

        public enum CancelType
        {
            UNKNOWN,
            CancelByUser,
            CancelByReduceOnly,             // cancelled by reduceOnly
            CancelByPrepareLiq,
            CancelAllBeforeLiq,             // cancelled in order to attempt liquidation prevention by freeing up margin
            CancelByPrepareAdl,
            CancelAllBeforeAdl,             // cancelled due to ADL
            CancelByAdmin,
            CancelByTpSlTsClear,            // TP/SL order cancelled successfully
            CancelByPzSideCh,               // cancel TP/SL when the position was closed by another order
            CancelBySmp,                    // cancelled by SMP
            CancelBySettle,
            CancelByCannotAffordOrderCost,
            CancelByPmTrialMmOverEquity,
            CancelByAccountBlocking,
            CancelByDelivery,
            CancelByMmpTriggered,
            CancelByCrossSelfMuch,
            CancelByCrossReachMaxTradeNum,
            CancelByDCP
        }

        public enum RejectReason
        {
            EC_NoError,
            EC_Others,
            EC_UnknownMessageType,
            EC_MissingClOrdID,
            EC_MissingOrigClOrdID,
            EC_ClOrdIDOrigClOrdIDAreTheSame,
            EC_DuplicatedClOrdID,
            EC_OrigClOrdIDDoesNotExist,
            EC_TooLateToCancel,
            EC_UnknownOrderType,
            EC_UnknownSide,
            EC_UnknownTimeInForce,
            EC_WronglyRouted,
            EC_MarketOrderPriceIsNotZero,
            EC_LimitOrderInvalidPrice,
            EC_NoEnoughQtyToFill,
            EC_NoImmediateQtyToFill,
            EC_PerCancelRequest,
            EC_MarketOrderCannotBePostOnly,
            EC_PostOnlyWillTakeLiquidity,
            EC_CancelReplaceOrder,
            EC_InvalidSymbolStatus,
            EC_CancelForNoFullFill
        }

        public enum TimeInForce
        {
            GTC,      // GoodTillCancel
            IOC,      // ImmediateOrCancel
            FOK,      // FillOrKill
            PostOnly
        }

        public enum OrderType
        {
            Market,
            Limit,
            UNKNOWN    // is not a valid request parameter value. Is only used in some responses. Mainly, it is used when execType is Funding.
        }

        public enum StopOrderType
        {
            TakeProfit,
            StopLoss,
            TrailingStop,
            Stop,
            PartialTakeProfit,
            PartialStopLoss,
            tpslOrder,            // spot TP/SL order
            OcoOrder,             // spot Oco order
            MmRateClose,          // On web or app can set MMR to close position
            BidirectionalTpslOrder // Spot bidirectional tpsl order
        }

        public enum TriggerBy
        {
            LastPrice,
            IndexPrice,
            MarkPrice
        }

        public enum SmpType
        {
            None,
            CancelMaker,
            CancelTaker,
            CancelBoth
        }

        public enum Status
        {
            PreLaunch,
            Trading,
            Settling, // The unique status for USDC Perpetual 8-hour settlement
            Delivering,
            Closed
        }

        public enum ContractType
        {
            InversePerpetual,
            LinearPerpetual,
            LinearFutures, // USDC Futures
            InverseFutures
        }

        public enum CopyTrading
        {
            none, // Regardless of normal account or UTA account, this trading pair does not support copy trading
            both, // For both normal account and UTA account, this trading pair supports copy trading
            utaOnly, // Only for UTA account, this trading pair supports copy trading
            normalOnly // Only for normal account, this trading pair supports copy trading
        }

        public enum MarginTrading
        {
            none, // Regardless of normal account or UTA account, this trading pair does not support margin trading
            both, // For both normal account and UTA account, this trading pair supports margin trading
            utaOnly, // Only for UTA account, this trading pair supports margin trading
            normalSpotOnly // Only for normal account, this trading pair supports margin trading
        }
    }
}