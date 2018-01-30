using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyCharges
{
    public class Classification
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}