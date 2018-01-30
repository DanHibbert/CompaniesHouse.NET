using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource
{
    public class CompanyPersonsWithSignificantControl
    {
        [JsonProperty("items")]
        public List<PersonWithSignificantControlItem> Items { get; set; }
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
        [JsonProperty("start_index")]
        public int StartIndex { get; set; }
        [JsonProperty("links")]
        public Links Links { get; set; }
        [JsonProperty("active_count")]
        public int ActiveCount { get; set; }
        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }
        [JsonProperty("ceased_count")]
        public int CeasedCount { get; set; }
    }
}