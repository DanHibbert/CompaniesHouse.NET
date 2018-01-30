using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Statements
{
    public class StatementList
    {
        [JsonProperty("active_count")]
        public int? ActiveCount { get; set; }
        [JsonProperty("ceased_count")]
        public int? CeasedCount { get; set; }
        [JsonProperty("etag")]
        public string Etag { get; set; }
        [JsonProperty("items")]
        public List<StatementItem> Items { get; set; }
        [JsonProperty("items_per_page")]
        public string ItemsPerPage { get; set; }
        [JsonProperty("kind")]
        public string Kind { get; set; }
        [JsonProperty("links")]
        public ListLink Links { get; set; }
        [JsonProperty("start_index")]
        public string StartIndex { get; set; }
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
    }
}