using System.ComponentModel;
using System.Runtime.Serialization;

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

            /// <summary>
            /// Futures conditional order
            /// </summary>
            [EnumMember(Value = "CreateByStopOrder")]
            CreateByStopOrder,

            /// <summary>
            /// Futures take profit order
            /// </summary>
            [EnumMember(Value = "CreateByTakeProfit")]
            CreateByTakeProfit,

            /// <summary>
            /// Futures partial take profit order
            /// </summary>
            [EnumMember(Value = "CreateByPartialTakeProfit")]
            CreateByPartialTakeProfit,

            /// <summary>
            /// Futures stop loss order
            /// </summary>
            [EnumMember(Value = "CreateByStopLoss")]
            CreateByStopLoss,

            /// <summary>
            /// Futures partial stop loss order
            /// </summary>
            [EnumMember(Value = "CreateByPartialStopLoss")]
            CreateByPartialStopLoss,

            /// <summary>
            ///  Futures trailing stop order
            /// </summary>
            [EnumMember(Value = "CreateByTrailingStop")]
            CreateByTrailingStop,

            /// <summary>
            /// Laddered liquidation to reduce the required maintenance margin
            /// </summary>
            [EnumMember(Value = "CreateByLiq")]
            CreateByLiq,

            /// <summary>
            /// If the position is still subject to liquidation (i.e., does not meet the required maintenance margin level), the position shall be taken over by the liquidation engine and closed at the bankruptcy price.
            /// </summary>
            [EnumMember(Value = "CreateByTakeOver_PassThrough")]
            CreateByTakeOver_PassThrough,

            /// <summary>
            /// Auto-Deleveraging(ADL)
            /// </summary>
            [EnumMember(Value = "CreateByAdl_PassThrough")]
            CreateByAdl_PassThrough,

            /// <summary>
            /// Order placed via Paradigm
            /// </summary>
            [EnumMember(Value = "CreateByBlock_PassThrough")]
            CreateByBlock_PassThrough,

            /// <summary>
            /// Order created by move position
            /// </summary>
            [EnumMember(Value = "CreateByBlockTradeMovePosition_PassThrough")]
            CreateByBlockTradeMovePosition_PassThrough,

            /// <summary>
            /// The close order placed via web or app position area - web/app
            /// </summary>
            [EnumMember(Value = "CreateByClosing")]
            CreateByClosing,

            /// <summary>
            /// Order created via grid bot - web/app
            /// </summary>
            [EnumMember(Value = "CreateByFGridBot")]
            CreateByFGridBot,

            /// <summary>
            /// Order closed via grid bot - web/app
            /// </summary>
            [EnumMember(Value = "CloseByFGridBot")]
            CloseByFGridBot,

            /// <summary>
            /// Order created by TWAP - web/app
            /// </summary>
            [EnumMember(Value = "CreateByTWAP")]
            CreateByTWAP,

            /// <summary>
            ///  Order created by TV webhook - web/app
            /// </summary>
            [EnumMember(Value = "CreateByTVSignal")]
            CreateByTVSignal,

            /// <summary>
            /// Order created by Mm rate close function - web/app
            /// </summary>
            [EnumMember(Value = "CreateByMmRateClose")]
            CreateByMmRateClose,

            /// <summary>
            /// Order created by Martingale bot - web/app
            /// </summary>
            [EnumMember(Value = "CreateByMartingaleBot")]
            CreateByMartingaleBot,

            /// <summary>
            /// Order closed by Martingale bot - web/app
            /// </summary>
            [EnumMember(Value = "CloseByMartingaleBot")]
            CloseByMartingaleBot,

            /// <summary>
            /// Order created by Ice berg strategy - web/app
            /// </summary>
            [EnumMember(Value = "CreateByIceBerg")]
            CreateByIceBerg,

            /// <summary>
            /// Order created by arbitrage - web/app
            /// </summary>
            [EnumMember(Value = "CreateByArbitrage")]
            CreateByArbitrage
        }

        public enum CancelType
        {
            [EnumMember(Value = "UNKNOWN")]
            Unknown,

            [EnumMember(Value = "CancelByUser")]
            CancelByUser,

            /// <summary>
            /// cancelled by reduceOnly
            /// </summary>
            [EnumMember(Value = "CancelByReduceOnly")]
            CancelByReduceOnly,

            [EnumMember(Value = "CancelByPrepareLiq")]
            CancelByPrepareLiq,

            /// <summary>
            /// cancelled in order to attempt liquidation prevention by freeing up margin
            /// </summary>
            [EnumMember(Value = "CancelAllBeforeLiq")]
            CancelAllBeforeLiq,

            [EnumMember(Value = "CancelByPrepareAdl")]
            CancelByPrepareAdl,

            /// <summary>
            /// cancelled due to ADL
            /// </summary>
            [EnumMember(Value = "CancelAllBeforeAdl")]
            CancelAllBeforeAdl,

            [EnumMember(Value = "CancelByAdmin")]
            CancelByAdmin,

            /// <summary>
            /// TP/SL order cancelled successfully
            /// </summary>
            [EnumMember(Value = "CancelByTpSlTsClear")]
            CancelByTpSlTsClear,

            /// <summary>
            /// cancel TP/SL when the position was closed by another order
            /// </summary>
            [EnumMember(Value = "CancelByPzSideCh")]
            CancelByPzSideCh,

            /// <summary>
            /// cancelled by SMP
            /// </summary>
            [EnumMember(Value = "CancelBySmp")]
            CancelBySmp,

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

        public enum OrderFilter
        {
            /// <summary>
            /// Order
            /// </summary>
            [EnumMember(Value = "Order")]
            Order,

            /// <summary>
            /// Spot TP/SL order, the assets are occupied even before the order is triggered
            /// </summary>
            [EnumMember(Value = "tpslOrder")]
            TpSlOrder,

            /// <summary>
            /// Spot conditional order, the assets will not be occupied until the price of the underlying asset reaches the trigger price, and the required assets will be occupied after the Conditional order is triggered
            /// </summary>
            [EnumMember(Value = "StopOrder")]
            StopOrder
        }

        public enum TpSlMode
        {
            /// <summary>
            /// Entire position for TP/SL. Then, tpOrderType or slOrderType must be Market
            /// </summary>
            [EnumMember(Value = "Full")]
            Full,

            /// <summary>
            /// Partial position tp/sl. Limit TP/SL order are supported. Note: When create limit tp/sl, tpslMode is required and it must be Partial
            /// </summary>
            [EnumMember(Value = "Partial")]
            Partial
        }

        public enum OrderType
        {
            [EnumMember(Value = "Market")]
            Market,

            [EnumMember(Value = "Limit")]
            Limit,

            [EnumMember(Value = "UNKNOWN")]
            Unknown
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

            /// <summary>
            /// The unique status for USDC Perpetual 8-hour settlement
            /// </summary>
            [EnumMember(Value = "Settling")]
            Settling,

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

            /// <summary>
            ///  USDC Futures
            /// </summary>
            [EnumMember(Value = "LinearFutures")]
            LinearFutures,

            [EnumMember(Value = "InverseFutures")]
            InverseFutures
        }

        public enum CopyTrading
        {
            /// <summary>
            /// Regardless of normal account or UTA account, this trading pair does not support copy trading
            /// </summary>
            [EnumMember(Value = "none")]
            None,

            /// <summary>
            /// For both normal account and UTA account, this trading pair supports copy trading
            /// </summary>
            [EnumMember(Value = "both")]
            Both,

            /// <summary>
            /// Only for UTA account, this trading pair supports copy trading
            /// </summary>
            [EnumMember(Value = "utaOnly")]
            UtaOnly,

            /// <summary>
            /// Only for normal account, this trading pair supports copy trading
            /// </summary>
            [EnumMember(Value = "normalOnly")]
            NormalOnly
        }

        public enum MarginTrading
        {
            /// <summary>
            /// Regardless of normal account or UTA account, this trading pair does not support margin trading
            /// </summary>
            [EnumMember(Value = "none")]
            None,

            /// <summary>
            /// For both normal account and UTA account, this trading pair supports margin trading
            /// </summary>
            [EnumMember(Value = "both")]
            Both,

            /// <summary>
            /// Only for UTA account, this trading pair supports margin trading
            /// </summary>
            [EnumMember(Value = "utaOnly")]
            UtaOnly,

            /// <summary>
            /// Only for normal account, this trading pair supports margin trading
            /// </summary>
            [EnumMember(Value = "normalSpotOnly")]
            NormalSpotOnly
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
            /// <summary>
            /// Inverse Derivatives Account, Derivatives Account
            /// </summary>
            [EnumMember(Value = "CONTRACT")]
            CONTRACT,

            /// <summary>
            /// Unified Trading Account
            /// </summary>
            [EnumMember(Value = "UNIFIED")]
            UNIFIED,

            /// <summary>
            /// Funding Account
            /// </summary>
            [EnumMember(Value = "FUND")]
            FUND,

            /// <summary>
            /// Spot Account
            /// </summary>
            [EnumMember(Value = "SPOT")]
            SPOT,

            /// <summary>
            /// USDC Derivatives
            /// </summary>
            [EnumMember(Value = "OPTION")]
            OPTION
        }

        public enum Side
        {
            [EnumMember(Value = "Buy")]
            Buy,

            [EnumMember(Value = "Sell")]
            Sell
        }

        public enum ExecType
        {
            /// <summary>
            /// Trade
            /// </summary>
            [EnumMember(Value = "Trade")]
            Trade,

            /// <summary>
            /// Auto-Deleveraging
            /// </summary>
            [EnumMember(Value = "AdlTrade")]
            AutoDeleveraging,

            /// <summary>
            /// Funding fee
            /// </summary>
            [EnumMember(Value = "Funding")]
            Funding,

            /// <summary>
            /// Liquidation
            /// </summary>
            [EnumMember(Value = "BustTrade")]
            Liquidation,

            /// <summary>
            /// USDC futures delivery
            /// </summary>
            [EnumMember(Value = "Delivery")]
            Delivery,

            /// <summary>
            /// BlockTrade
            /// </summary>
            [EnumMember(Value = "BlockTrade")]
            BlockTrade,

            /// <summary>
            /// MovePosition
            /// </summary>
            [EnumMember(Value = "MovePosition")]
            MovePosition,

            /// <summary>
            /// May be returned by a classic account. Cannot query by this type
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            Unknown
        }

        public enum IntervalTime
        {
            /// <summary>
            /// 5 minutes interval
            /// </summary>
            [EnumMember(Value = "5min")]
            Minute5,

            /// <summary>
            /// 15 minutes interval
            /// </summary>
            [EnumMember(Value = "15min")]
            Minute15,

            /// <summary>
            /// 30 minutes interval
            /// </summary>
            [EnumMember(Value = "30min")]
            Minute30,

            /// <summary>
            /// 1 hour interval
            /// </summary>
            [EnumMember(Value = "1h")]
            OneHour,

            /// <summary>
            /// 4 hours interval
            /// </summary>
            [EnumMember(Value = "4h")]
            Hour4,

            /// <summary>
            /// 1 day interval
            /// </summary>
            [EnumMember(Value = "1d")]
            OneDay
        }

        public enum DataRecordingPeriod
        {
            /// <summary>
            /// 5 minutes interval
            /// </summary>
            [EnumMember(Value = "5min")]
            Minute5,

            /// <summary>
            /// 15 minutes interval
            /// </summary>
            [EnumMember(Value = "15min")]
            Minute15,

            /// <summary>
            /// 30 minutes interval
            /// </summary>
            [EnumMember(Value = "30min")]
            Minute30,

            /// <summary>
            /// 1 hour interval
            /// </summary>
            [EnumMember(Value = "1h")]
            OneHour,

            /// <summary>
            /// 4 hours interval
            /// </summary>
            [EnumMember(Value = "4h")]
            Hour4,

            /// <summary>
            /// 4 day interval
            /// </summary>
            [EnumMember(Value = "4d")]
            Day4
        }

        public enum UnifiedMarginStatus
        {
            /// <summary>
            /// Regular account
            /// </summary>
            RegularAccount = 1,

            /// <summary>
            /// Please ignore
            /// </summary>
            Ignore = 2,

            /// <summary>
            /// Unified trade account, it can trade linear perpetual, options and spot
            /// </summary>
            UnifiedTradeAccount = 3,

            /// <summary>
            /// UTA Pro, the pro version of Unified trade account
            /// </summary>
            UTAPro = 4
        }
    }
}