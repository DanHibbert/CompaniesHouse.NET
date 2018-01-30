using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}