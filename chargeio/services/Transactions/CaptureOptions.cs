﻿using System;
using ChargeIO.Models;
using Newtonsoft.Json;

namespace ChargeIO.Services.Transactions
{
    [Serializable]
    public class CaptureOptions
    {
        [JsonProperty("amount")]
        public int? AmountInCents { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("gratuity")]
        public int? GratuityInCents { get; set; }

        [JsonProperty("signature")]
        public TransactionSignature Signature { get; set; }

        [JsonProperty("capture_time")]
        public string CaptureTime { get; set; }
    }
}
