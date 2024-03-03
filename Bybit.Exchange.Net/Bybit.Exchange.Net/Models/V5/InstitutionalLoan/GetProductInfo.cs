namespace Bybit.Exchange.Net.Models.V5.InstitutionalLoan
{
    public class GetProductInfoRequest
    {
        /// <summary>
        /// <value>Property <c>productId</c></value>
        /// <para>
        /// Product Id. If not passed, then return all products info
        /// </para>
        /// </summary>
        public string productId { get; set; } = default!;
    }


    public class GetProductInfoResponse
    {
        /// <summary>
        /// <value>Property <c>marginProductInfo</c></value>
        /// <para>
        /// Object array containing product information.
        /// </para>
        /// </summary>
        public MarginProductInfo[] MarginProductInfo { get; set; } = default!;
    }

    /// <summary>
    /// Object representing margin product information.
    /// </summary>
    public class MarginProductInfo
    {
        /// <summary>
        /// <value>Property <c>productId</c></value>
        /// <para>
        /// Product Id.
        /// </para>
        /// </summary>
        public string ProductId { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>leverage</c></value>
        /// <para>
        /// The maximum leverage for this loan product.
        /// </para>
        /// </summary>
        public string Leverage { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>supportSpot</c></value>
        /// <para>
        /// Whether to support Spot. 0:false; 1:true.
        /// </para>
        /// </summary>
        public int? SupportSpot { get; set; }

        /// <summary>
        /// <value>Property <c>supportContract</c></value>
        /// <para>
        /// Whether to support USDT Perpetual. 0:false; 1:true.
        /// </para>
        /// </summary>
        public int? SupportContract { get; set; }

        /// <summary>
        /// <value>Property <c>supportMarginTrading</c></value>
        /// <para>
        /// Whether to support Spot margin trading. 0:false; 1:true.
        /// </para>
        /// </summary>
        public int? SupportMarginTrading { get; set; }

        /// <summary>
        /// <value>Property <c>deferredLiquidationLine</c></value>
        /// <para>
        /// Line for deferred liquidation.
        /// </para>
        /// </summary>
        public string DeferredLiquidationLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>deferredLiquidationTime</c></value>
        /// <para>
        /// Time for deferred liquidation.
        /// </para>
        /// </summary>
        public string DeferredLiquidationTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>withdrawLine</c></value>
        /// <para>
        /// Restrict line for withdrawal.
        /// </para>
        /// </summary>
        public string WithdrawLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>transferLine</c></value>
        /// <para>
        /// Restrict line for transfer.
        /// </para>
        /// </summary>
        public string TransferLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>spotBuyLine</c></value>
        /// <para>
        /// Restrict line for Spot buy.
        /// </para>
        /// </summary>
        public string SpotBuyLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>spotSellLine</c></value>
        /// <para>
        /// Restrict line for Spot trading.
        /// </para>
        /// </summary>
        public string SpotSellLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>contractOpenLine</c></value>
        /// <para>
        /// Restrict line for USDT Perpetual open position.
        /// </para>
        /// </summary>
        public string ContractOpenLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>liquidationLine</c></value>
        /// <para>
        /// Line for liquidation.
        /// </para>
        /// </summary>
        public string LiquidationLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>stopLiquidationLine</c></value>
        /// <para>
        /// Line for stop liquidation.
        /// </para>
        /// </summary>
        public string StopLiquidationLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>contractLeverage</c></value>
        /// <para>
        /// The allowed default leverage for USDT Perpetual.
        /// </para>
        /// </summary>
        public string ContractLeverage { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>transferRatio</c></value>
        /// <para>
        /// The transfer ratio for loan funds to transfer from Spot wallet to Contract wallet.
        /// </para>
        /// </summary>
        public string TransferRatio { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>spotSymbols</c></value>
        /// <para>
        /// The whitelist of spot trading pairs.
        /// </para>
        /// <para>
        /// If supportSpot="0", then it returns "[]". If empty array, then you can trade any symbols.
        /// If not empty, then you can only trade listed symbols.
        /// </para>
        /// </summary>
        public List<string> SpotSymbols { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>contractSymbols</c></value>
        /// <para>
        /// The whitelist of contract trading pairs.
        /// </para>
        /// <para>
        /// If supportContract="0", then it returns "[]". If empty array, then you can trade any symbols.
        /// If not empty, then you can only trade listed symbols.
        /// </para>
        /// </summary>
        public List<string>? ContractSymbols { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>supportUSDCContract</c></value>
        /// <para>
        /// Whether to support USDC contract. '0':false; '1':true.
        /// </para>
        /// </summary>
        public int? SupportUSDCContract { get; set; }

        /// <summary>
        /// <value>Property <c>supportUSDCOptions</c></value>
        /// <para>
        /// Whether to support Option. '0':false; '1':true.
        /// </para>
        /// </summary>
        public int? SupportUSDCOptions { get; set; }

        /// <summary>
        /// <value>Property <c>USDTPerpetualOpenLine</c></value>
        /// <para>
        /// Restrict line to open USDT Perpetual position.
        /// </para>
        /// </summary>
        public string USDTPerpetualOpenLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>USDCContractOpenLine</c></value>
        /// <para>
        /// Restrict line to open USDC Contract position.
        /// </para>
        /// </summary>
        public string USDCContractOpenLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>USDCOptionsOpenLine</c></value>
        /// <para>
        /// Restrict line to open Option position.
        /// </para>
        /// </summary>
        public string USDCOptionsOpenLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>USDTPerpetualCloseLine</c></value>
        /// <para>
        /// Restrict line to trade USDT Perpetual.
        /// </para>
        /// </summary>
        public string USDTPerpetualCloseLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>USDCContractCloseLine</c></value>
        /// <para>
        /// Restrict line to trade USDC Contract.
        /// </para>
        /// </summary>
        public string USDCContractCloseLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>USDCOptionsCloseLine</c></value>
        /// <para>
        /// Restrict line to trade Option.
        /// </para>
        /// </summary>
        public string USDCOptionsCloseLine { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>USDCContractSymbols</c></value>
        /// <para>
        /// The whitelist of USDC contract trading pairs.
        /// </para>
        /// <para>
        /// If supportContract="0", then it returns "[]".
        /// If no whitelist symbols, it is [], and you can trade any.
        /// If supportUSDCContract="0", it is [].
        /// </para>
        /// </summary>
        public List<string>? USDCContractSymbols { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>USDCOptionsSymbols</c></value>
        /// <para>
        /// The whitelist of Option symbols.
        /// </para>
        /// <para>
        /// If supportContract="0", then it returns "[]".
        /// If no whitelisted, it is [], and you can trade any.
        /// If supportUSDCOptions="0", it is [].
        /// </para>
        /// </summary>
        public List<string>? USDCOptionsSymbols { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>marginLeverage</c></value>
        /// <para>
        /// The allowable maximum leverage for Spot margin trading.
        /// If supportMarginTrading=0, then it returns "".
        /// </para>
        /// </summary>
        public string MarginLeverage { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>USDTPerpetualLeverage</c></value>
        /// <para>
        /// Array of objects representing USDT Perpetual leverage.
        /// If supportContract="0", it is [].
        /// If no whitelist USDT perp symbols, it returns all trading symbols and leverage by default.
        /// If there are whitelist symbols, it returns those whitelist data.
        /// </para>
        /// </summary>
        public List<ProductInfoLeverage>? USDTPerpetualLeverage { get; set; } = default!;


        /// <summary>
        /// <value>Property <c>USDCContractLeverage</c></value>
        /// <para>
        /// Array of objects representing USDC Contract Leverage.
        /// If supportContract="0", it is [].
        /// If no whitelist USDC contract symbols, it returns all trading symbols and leverage by default.
        /// If there are whitelist symbols, it returns those whitelist data.
        /// </para>
        /// </summary>
        public List<ProductInfoLeverage>? USDCContractLeverage { get; set; } = default!;
    }


    public class ProductInfoLeverage
    {
        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name.
        /// </para>
        /// </summary>
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>leverage</c></value>
        /// <para>
        /// Maximum leverage.
        /// </para>
        /// </summary>
        public string Leverage { get; set; } = default!;
    }
}
