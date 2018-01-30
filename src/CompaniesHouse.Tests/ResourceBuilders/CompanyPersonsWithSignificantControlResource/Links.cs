using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource
{
    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}