using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyCharges
{
    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}