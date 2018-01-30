using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Statements
{
    public class ListLink
    {
        [JsonProperty("persons_with_significant_control_list")]
        public string PersonWithSignificantControl { get; set; }
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}