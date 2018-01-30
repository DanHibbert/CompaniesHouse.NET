using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Corporate
{
    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }
        [JsonProperty("statement")]
        public string Statement { get; set; }
    }
}