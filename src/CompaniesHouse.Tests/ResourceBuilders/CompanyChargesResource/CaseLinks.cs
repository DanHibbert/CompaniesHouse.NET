using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class CaseLinks
    {
        [JsonProperty("case")]
        public string Case { get; set; }
    }
}