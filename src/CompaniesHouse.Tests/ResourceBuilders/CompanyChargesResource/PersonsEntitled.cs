using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class PersonsEntitled
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}