using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Statements
{
    public class Link
    {
        [JsonProperty("person_with_significant_control")]
        public string PersonWithSignificantControl { get; set; }
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}