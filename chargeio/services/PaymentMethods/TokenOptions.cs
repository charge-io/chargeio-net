﻿using System;
using Newtonsoft.Json;

namespace ChargeIO.Services.PaymentMethods
{
    [Serializable]
    public class TokenOptions
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string CardNumber { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("exp_month")]
        public int CardExpirationMonth { get; set; }

        [JsonProperty("exp_year")]
        public int CardExpirationYear { get; set; }

        [JsonProperty("cvv")]
        public string CardCvv { get; set; }

        [JsonProperty("routing_number")]
        public string BankRoutingNumber { get; set; }

        [JsonProperty("account_number")]
        public string BankAccountNumber { get; set; }

        [JsonProperty("account_type")]
        public string BankAccountType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}