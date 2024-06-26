﻿using Newtonsoft.Json;
using Shift4.Converters;
using Shift4.Enums;
using System;
using System.Collections.Generic;

namespace Shift4.Response
{
    public class Payout : BaseResponse
    {
        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public String Currency { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("periodStart")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime PeriodStart { get; set; }

        [JsonProperty("periodEnd")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime PeriodEnd { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<String, String> Metadata { get; set; }
    }
}

