using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyCharges
{
    public class PersonsEntitled
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}