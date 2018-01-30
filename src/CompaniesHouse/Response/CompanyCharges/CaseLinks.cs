using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyCharges
{
    public class CaseLinks
    {
        [JsonProperty("case")]
        public string Case { get; set; }
    }
}