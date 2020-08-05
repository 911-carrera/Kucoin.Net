﻿using Kucoin.Net.Converts;
using Newtonsoft.Json;

namespace Kucoin.Net.Objects
{
    /// <summary>
    /// Transferable Account info
    /// </summary>
    public class KucoinTransferableAccount
    {
        /// <summary>
        /// The currency of the account
        /// </summary>
        public string Currency { get; set; } = "";
        /// <summary>
        /// The total balance of the account
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// The available balance of the account
        /// </summary>
        public decimal Available { get; set; }
        /// <summary>
        /// The amount of balance that's in hold
        /// </summary>
        public decimal Holds { get; set; }
        /// <summary>
        /// The amount of transferable balance
        /// </summary>
        public decimal Transferable { get; set; }
    }
}
