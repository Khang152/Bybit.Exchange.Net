﻿using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Models.V5.Market
{
    public class GetKlineRequest
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <remarks>
        /// | Product type:
        /// </remarks>
        /// <para>
        /// spot, linear, inverse
        /// </para>
        /// </summary>
        public Category? category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>interval</c></value>
        /// <para>
        /// Kline interval. 1, 3, 5, 15, 30, 60, 120, 240, 360, 720, D, M, W
        /// </para>
        /// </summary>
        public Interval? interval { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>start</c></value>
        /// <para>
        /// The start timestamp (ms)
        /// </para>
        /// </summary>
        public double? start { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>end</c></value>
        /// <para>
        /// The end timestamp (ms)
        /// </para>
        /// </summary>
        public double? end { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>limit</c></value>
        /// <para>
        /// Limit for data size per page. [1, 1000]. Default: 200
        /// </para>
        /// </summary>
        public int? limit { get; set; } = default!;
    }

    public class GetKlineResponse
    {
        /// <summary>
        /// <value>Property <c>category</c></value>
        /// <para>
        /// Product type
        /// </para>
        /// </summary>
        public Category? Category { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>symbol</c></value>
        /// <para>
        /// Symbol name
        /// </para>
        /// </summary>
        public string Symbol { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>list</c></value>
        /// <para>
        /// An array of individual candles [startTime, openPrice, highPrice, lowPrice, closePrice, volume, turnover]
        /// </para>
        /// </summary>
        public string[][] List { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>list items</c></value>
        /// <para>
        /// An array of individual candles [startTime, openPrice, highPrice, lowPrice, closePrice, volume, turnover]
        /// </para>
        /// </summary>
        public List<GetKlineItem> ListItems { get; set; } = default!;
    }

    public class GetKlineItem
    {
        /// <summary>
        /// <value>Property <c>StartTime</c></value>
        /// <para>
        /// Start Time
        /// </para>
        /// </summary>
        public string StartTime { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>OpenPrice</c></value>
        /// <para>
        /// Open Price
        /// </para>
        /// </summary>
        public string OpenPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>HighPrice</c></value>
        /// <para>
        /// High Price
        /// </para>
        /// </summary>
        public string HighPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>LowPrice</c></value>
        /// <para>
        /// Low Price
        /// </para>
        /// </summary>
        public string LowPrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>ClosePrice</c></value>
        /// <para>
        /// Close Price
        /// </para>
        /// </summary>
        public string ClosePrice { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>Volume</c></value>
        /// <para>
        /// Volume
        /// </para>
        /// </summary>
        public string Volume { get; set; } = default!;

        /// <summary>
        /// <value>Property <c>TurnOver</c></value>
        /// <para>
        /// Turn Over
        /// </para>
        /// </summary>
        public string TurnOver { get; set; } = default!;
    }
}