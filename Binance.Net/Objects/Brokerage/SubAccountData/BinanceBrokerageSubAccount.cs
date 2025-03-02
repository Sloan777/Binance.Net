﻿using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;

namespace Binance.Net.Objects.Brokerage.SubAccountData
{
    /// <summary>
    /// Sub Account
    /// </summary>
    public class BinanceBrokerageSubAccount : BinanceBrokerageSubAccountCommission
    {
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; } = string.Empty;
        
        /// <summary>
        /// Create Date
        /// </summary>
        [JsonProperty("createTime"), JsonConverter(typeof(TimestampConverter))]
        public DateTime CreateDate { get; set; }
    }
}