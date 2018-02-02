using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Response.CompanyCharges
{
    public class Transaction
    {
        [JsonProperty("delivered_on")]
        public string DeliveredOn { get; set; }
        [JsonProperty("filing_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FilingType FilingType { get; set; }
        [JsonProperty("insolvency_case_number")]
        public string InsolvencyCaseNumber { get; set; }
        [JsonProperty("links")]
        public TransactionLinks Links { get; set; }
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}