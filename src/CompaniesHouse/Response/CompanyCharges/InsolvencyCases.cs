using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyCharges
{
    public class InsolvencyCases
    {
        [JsonProperty("case_number")]
        public string CaseNumber { get; set; }
        [JsonProperty("links")]
        public CaseLinks Links { get; set; }
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}