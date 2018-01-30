using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl
{
    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}