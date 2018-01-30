using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Legal
{
    public class Identification
    {
        [JsonProperty("legal_authority")]
        public string LegalAuthority { get; set; }
        [JsonProperty("legal_form")]
        public string LegalForm { get; set; }
    }
}