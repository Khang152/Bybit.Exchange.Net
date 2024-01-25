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
            [EnumMember(Value = "Created")]
            Created,

            [EnumMember(Value = "New")]
            New,

            [EnumMember(Value = "Rejected")]
            Rejected,

            [EnumMember(Value = "PartiallyFilled")]
            PartiallyFilled,

            [EnumMember(Value = "PartiallyFilledCanceled")]
            PartiallyFilledCanceled,

            [EnumMember(Value = "Filled")]
            Filled,

            [EnumMember(Value = "Cancelled")]
            Cancelled,

            [EnumMember(Value = "Untriggered")]
            Untriggered,

            [EnumMember(Value = "Triggered")]
            Triggered,

            [EnumMember(Value = "Deactivated")]
            Deactivated
        }

        public enum PositionIdx
        {
            [EnumMember(Value = "OnewayMode")]
            OnewayMode = 0,

            [EnumMember(Value = "BuySideOfHedgeMode")]
            BuySideOfHedgeMode = 1,

            [EnumMember(Value = "SellSideOfHedgeMode")]
            SellSideOfHedgeMode = 2
        }

        public enum TriggerDirection
        {
            [EnumMember(Value = "None")]
            None = 0,

            [EnumMember(Value = "Rise")]
            Rise = 1,

            [EnumMember(Value = "Fall")]
            Fall = 2
        }

        public enum CreateType
        {
            [EnumMember(Value = "CreateByUser")]
            CreateByUser,

            [EnumMember(Value = "CreateByAdminClosing")]
            CreateByAdminClosing,

            [EnumMember(Value = "CreateByStopOrder")]
            CreateByStopOrder,             // Futures conditional order

            [EnumMember(Value = "CreateByTakeProfit")]
            CreateByTakeProfit,           // Futures take profit order

            [EnumMember(Value = "CreateByPartialTakeProfit")]
            CreateByPartialTakeProfit,    // Futures partial take profit order

            [EnumMember(Value = "CreateByStopLoss")]
            CreateByStopLoss,             // Futures stop loss order

            [EnumMember(Value = "CreateByPartialStopLoss")]
            CreateByPartialStopLoss,      // Futures partial stop loss order

            [EnumMember(Value = "CreateByTrailingStop")]
            CreateByTrailingStop,         // Futures trailing stop order

            [EnumMember(Value = "CreateByLiq")]
            CreateByLiq,                  // Laddered liquidation to reduce the required maintenance margin

            [EnumMember(Value = "CreateByTakeOver_PassThrough")]
            CreateByTakeOver_PassThrough, // If the position is still subject to liquidation (i.e., does not meet the required maintenance margin level), the position shall be taken over by the liquidation engine and closed at the bankruptcy price.

            [EnumMember(Value = "CreateByAdl_PassThrough")]
            CreateByAdl_PassThrough,      // Auto-Deleveraging(ADL)

            [EnumMember(Value = "CreateByBlock_PassThrough")]
            CreateByBlock_PassThrough,    // Order placed via Paradigm

            [EnumMember(Value = "CreateByBlockTradeMovePosition_PassThrough")]
            CreateByBlockTradeMovePosition_PassThrough, // Order created by move position

            [EnumMember(Value = "CreateByClosing")]
            CreateByClosing,              // The close order placed via web or app position area - web/app

            [EnumMember(Value = "CreateByFGridBot")]
            CreateByFGridBot,             // Order created via grid bot - web/app

            [EnumMember(Value = "CloseByFGridBot")]
            CloseByFGridBot,              // Order closed via grid bot - web/app

            [EnumMember(Value = "CreateByTWAP")]
            CreateByTWAP,                 // Order created by TWAP - web/app

            [EnumMember(Value = "CreateByTVSignal")]
            CreateByTVSignal,             // Order created by TV webhook - web/app

            [EnumMember(Value = "CreateByMmRateClose")]
            CreateByMmRateClose,          // Order created by Mm rate close function - web/app

            [EnumMember(Value = "CreateByMartingaleBot")]
            CreateByMartingaleBot,        // Order created by Martingale bot - web/app

            [EnumMember(Value = "CloseByMartingaleBot")]
            CloseByMartingaleBot,         // Order closed by Martingale bot - web/app

            [EnumMember(Value = "CreateByIceBerg")]
            CreateByIceBerg,              // Order created by Ice berg strategy - web/app

            [EnumMember(Value = "CreateByArbitrage")]
            CreateByArbitrage             // Order created by arbitrage - web/app
        }

        public enum CancelType
        {
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,

            [EnumMember(Value = "CancelByUser")]
            CancelByUser,

            [EnumMember(Value = "CancelByReduceOnly")]
            CancelByReduceOnly,             // cancelled by reduceOnly

            [EnumMember(Value = "CancelByPrepareLiq")]
            CancelByPrepareLiq,

            [EnumMember(Value = "CancelAllBeforeLiq")]
            CancelAllBeforeLiq,             // cancelled in order to attempt liquidation prevention by freeing up margin

            [EnumMember(Value = "CancelByPrepareAdl")]
            CancelByPrepareAdl,

            [EnumMember(Value = "CancelAllBeforeAdl")]
            CancelAllBeforeAdl,             // cancelled due to ADL

            [EnumMember(Value = "CancelByAdmin")]
            CancelByAdmin,

            [EnumMember(Value = "CancelByTpSlTsClear")]
            CancelByTpSlTsClear,            // TP/SL order cancelled successfully

            [EnumMember(Value = "CancelByPzSideCh")]
            CancelByPzSideCh,               // cancel TP/SL when the position was closed by another order

            [EnumMember(Value = "CancelBySmp")]
            CancelBySmp,                    // cancelled by SMP

            [EnumMember(Value = "CancelBySettle")]
            CancelBySettle,

            [EnumMember(Value = "CancelByCannotAffordOrderCost")]
            CancelByCannotAffordOrderCost,

            [EnumMember(Value = "CancelByPmTrialMmOverEquity")]
            CancelByPmTrialMmOverEquity,

            [EnumMember(Value = "CancelByAccountBlocking")]
            CancelByAccountBlocking,

            [EnumMember(Value = "CancelByDelivery")]
            CancelByDelivery,

            [EnumMember(Value = "CancelByMmpTriggered")]
            CancelByMmpTriggered,

            [EnumMember(Value = "CancelByCrossSelfMuch")]
            CancelByCrossSelfMuch,

            [EnumMember(Value = "CancelByCrossReachMaxTradeNum")]
            CancelByCrossReachMaxTradeNum,

            [EnumMember(Value = "CancelByDCP")]
            CancelByDCP
        }

        public enum RejectReason
        {
            [EnumMember(Value = "EC_NoError")]
            EC_NoError,

            [EnumMember(Value = "EC_Others")]
            EC_Others,

            [EnumMember(Value = "EC_UnknownMessageType")]
            EC_UnknownMessageType,

            [EnumMember(Value = "EC_MissingClOrdID")]
            EC_MissingClOrdID,

            [EnumMember(Value = "EC_MissingOrigClOrdID")]
            EC_MissingOrigClOrdID,

            [EnumMember(Value = "EC_ClOrdIDOrigClOrdIDAreTheSame")]
            EC_ClOrdIDOrigClOrdIDAreTheSame,

            [EnumMember(Value = "EC_DuplicatedClOrdID")]
            EC_DuplicatedClOrdID,

            [EnumMember(Value = "EC_OrigClOrdIDDoesNotExist")]
            EC_OrigClOrdIDDoesNotExist,

            [EnumMember(Value = "EC_TooLateToCancel")]
            EC_TooLateToCancel,

            [EnumMember(Value = "EC_UnknownOrderType")]
            EC_UnknownOrderType,

            [EnumMember(Value = "EC_UnknownSide")]
            EC_UnknownSide,

            [EnumMember(Value = "EC_UnknownTimeInForce")]
            EC_UnknownTimeInForce,

            [EnumMember(Value = "EC_WronglyRouted")]
            EC_WronglyRouted,

            [EnumMember(Value = "EC_MarketOrderPriceIsNotZero")]
            EC_MarketOrderPriceIsNotZero,

            [EnumMember(Value = "EC_LimitOrderInvalidPrice")]
            EC_LimitOrderInvalidPrice,

            [EnumMember(Value = "EC_NoEnoughQtyToFill")]
            EC_NoEnoughQtyToFill,

            [EnumMember(Value = "EC_NoImmediateQtyToFill")]
            EC_NoImmediateQtyToFill,

            [EnumMember(Value = "EC_PerCancelRequest")]
            EC_PerCancelRequest,

            [EnumMember(Value = "EC_MarketOrderCannotBePostOnly")]
            EC_MarketOrderCannotBePostOnly,

            [EnumMember(Value = "EC_PostOnlyWillTakeLiquidity")]
            EC_PostOnlyWillTakeLiquidity,

            [EnumMember(Value = "EC_CancelReplaceOrder")]
            EC_CancelReplaceOrder,

            [EnumMember(Value = "EC_InvalidSymbolStatus")]
            EC_InvalidSymbolStatus,

            [EnumMember(Value = "EC_CancelForNoFullFill")]
            EC_CancelForNoFullFill
        }

        public enum TimeInForce
        {
            /// <summary>
            /// Good Till Cancel
            /// </summary>
            [EnumMember(Value = "GTC")]
            GTC,

            /// <summary>
            /// Immediate Or Cancel
            /// </summary>
            [EnumMember(Value = "IOC")]
            IOC,

            /// <summary>
            /// Fill Or Kill
            /// </summary>
            [EnumMember(Value = "FOK")]
            FOK,

            /// <summary>
            /// PostOnly
            /// </summary>
            [EnumMember(Value = "PostOnly")]
            PostOnly
        }

        public enum OrderType
        {
            [EnumMember(Value = "Market")]
            Market,

            [EnumMember(Value = "Limit")]
            Limit,

            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN
        }

        public enum StopOrderType
        {
            [EnumMember(Value = "TakeProfit")]
            TakeProfit,

            [EnumMember(Value = "StopLoss")]
            StopLoss,

            [EnumMember(Value = "TrailingStop")]
            TrailingStop,

            [EnumMember(Value = "Stop")]
            Stop,

            [EnumMember(Value = "PartialTakeProfit")]
            PartialTakeProfit,

            [EnumMember(Value = "PartialStopLoss")]
            PartialStopLoss,

            /// <summary>
            /// spot TP/SL order
            /// </summary>
            [EnumMember(Value = "tpslOrder")]
            tpslOrder,

            /// <summary>
            /// spot Oco order
            /// </summary>
            [EnumMember(Value = "OcoOrder")]
            OcoOrder,

            /// <summary>
            /// On web or app can set MMR to close position
            /// </summary>
            [EnumMember(Value = "MmRateClose")]
            MmRateClose,

            /// <summary>
            /// Spot bidirectional tpsl order
            /// </summary>
            [EnumMember(Value = "BidirectionalTpslOrder")]
            BidirectionalTpslOrder
        }

        public enum TriggerBy
        {
            [EnumMember(Value = "LastPrice")]
            LastPrice,

            [EnumMember(Value = "IndexPrice")]
            IndexPrice,

            [EnumMember(Value = "MarkPrice")]
            MarkPrice
        }

        public enum SmpType
        {
            [EnumMember(Value = "None")]
            None,

            [EnumMember(Value = "CancelMaker")]
            CancelMaker,

            [EnumMember(Value = "CancelTaker")]
            CancelTaker,

            [EnumMember(Value = "CancelBoth")]
            CancelBoth
        }

        public enum Status
        {
            [EnumMember(Value = "PreLaunch")]
            PreLaunch,

            [EnumMember(Value = "Trading")]
            Trading,

            [EnumMember(Value = "Settling")]
            Settling, // The unique status for USDC Perpetual 8-hour settlement

            [EnumMember(Value = "Delivering")]
            Delivering,

            [EnumMember(Value = "Closed")]
            Closed
        }

        public enum ContractType
        {
            [EnumMember(Value = "InversePerpetual")]
            InversePerpetual,

            [EnumMember(Value = "LinearPerpetual")]
            LinearPerpetual,

            [EnumMember(Value = "LinearFutures")]
            LinearFutures, // USDC Futures

            [EnumMember(Value = "InverseFutures")]
            InverseFutures
        }

        public enum CopyTrading
        {
            [EnumMember(Value = "none")]
            None, // Regardless of normal account or UTA account, this trading pair does not support copy trading

            [EnumMember(Value = "both")]
            Both, // For both normal account and UTA account, this trading pair supports copy trading

            [EnumMember(Value = "utaOnly")]
            UtaOnly, // Only for UTA account, this trading pair supports copy trading

            [EnumMember(Value = "normalOnly")]
            NormalOnly // Only for normal account, this trading pair supports copy trading
        }

        public enum MarginTrading
        {
            [EnumMember(Value = "none")]
            None, // Regardless of normal account or UTA account, this trading pair does not support margin trading

            [EnumMember(Value = "both")]
            Both, // For both normal account and UTA account, this trading pair supports margin trading

            [EnumMember(Value = "utaOnly")]
            UtaOnly, // Only for UTA account, this trading pair supports margin trading

            [EnumMember(Value = "normalSpotOnly")]
            NormalSpotOnly // Only for normal account, this trading pair supports margin trading
        }

        public enum Interval
        {
            [EnumMember(Value = "1")]
            Minute1 = 1,

            [EnumMember(Value = "3")]
            Minute3,

            [EnumMember(Value = "5")]
            Minute5,

            [EnumMember(Value = "15")]
            Minute15,

            [EnumMember(Value = "30")]
            Minute30,

            [EnumMember(Value = "60")]
            Minute60,

            [EnumMember(Value = "120")]
            Minute120,

            [EnumMember(Value = "240")]
            Minute240,

            [EnumMember(Value = "360")]
            Minute360,

            [EnumMember(Value = "720")]
            Minute720,

            [EnumMember(Value = "D")]
            Day,

            [EnumMember(Value = "W")]
            Week,

            [EnumMember(Value = "M")]
            Month
        }

        public enum AccountType
        {
            [EnumMember(Value = "CONTRACT")]
            CONTRACT, // Inverse Derivatives Account, Derivatives Account

            [EnumMember(Value = "UNIFIED")]
            UNIFIED, // Unified Trading Account

            [EnumMember(Value = "FUND")]
            FUND, // Funding Account

            [EnumMember(Value = "SPOT")]
            SPOT, // Spot Account

            [EnumMember(Value = "OPTION")]
            OPTION // USDC Derivatives
        }

        public enum Side
        {
            [EnumMember(Value = "Buy")]
            Buy,

            [EnumMember(Value = "Sell")]
            Sell
        }
    }
}