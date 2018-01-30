using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class Transaction
    {
        [JsonProperty("delivered_on")]
        public string DeliveredOn { get; set; }
        [JsonProperty("filing_type")]
        public string FilingType { get; set; }
        [JsonProperty("insolvency_case_number")]
        public string InsolvencyCaseNumber { get; set; }
        [JsonProperty("links")]
        public TransactionLinks Links { get; set; }
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}