﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class CompanyCharges
    {
        [JsonProperty("etag")]
        public string Etag { get; set; }
        [JsonProperty("items")]
        public List<ChargeItem> Items { get; set; }

        [JsonProperty("part_satisfied_count")]
        public string PartSatisfiedCount { get; set; }
        [JsonProperty("satisfied_count")]
        public string SatisfiedCount { get; set; }
        [JsonProperty("total_count")]
        public string TotalCount { get; set; }

        //TODO check spelling
        [JsonProperty("unfiletered_count")]
        public string UnfileteredCount { get; set; }
    }
}
