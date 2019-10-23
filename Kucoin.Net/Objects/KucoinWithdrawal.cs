﻿using CryptoExchange.Net.Converters;
using Kucoin.Net.Converts;
using Newtonsoft.Json;
using System;

namespace Kucoin.Net.Objects
{
    /// <summary>
    /// Withdrawal info
    /// </summary>
    public class KucoinWithdrawal
    {
        /// <summary>
        /// The id of the withdrawal
        /// </summary>
        public string Id { get; set; } = "";
        /// <summary>
        /// The address the withdrawal is to
        /// </summary>
        public string Address { get; set; } = "";
        /// <summary>
        /// The memo for the withdrawal
        /// </summary>
        public string Memo { get; set; } = "";
        /// <summary>
        /// The currency of the withdrawal
        /// </summary>
        public string Currency { get; set; } = "";
        /// <summary>
        /// The quantity of the withdrawal
        /// </summary>
        [JsonProperty("amount")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// The fee of the withdrawal
        /// </summary>
        public decimal Fee { get; set; }
        /// <summary>
        /// The wallet transaction id
        /// </summary>
        [JsonProperty("walletTxId")]
        public string WalletTransactionId { get; set; } = "";
        /// <summary>
        /// Whether it is an internal withdrawal
        /// </summary>
        public bool IsInner { get; set; }
        /// <summary>
        /// Status of the converter
        /// </summary>
        [JsonConverter(typeof(WithdrawalStatusConverter))]
        public KucoinWithdrawalStatus Status { get; set; }
        /// <summary>
        /// The time the withdrawal was created
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// The time the withdrawal was last updated
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime UpdatedAt { get; set; }
    }
}
