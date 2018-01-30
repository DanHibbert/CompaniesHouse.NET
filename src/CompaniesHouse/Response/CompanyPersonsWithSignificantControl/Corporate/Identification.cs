using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Corporate
{
    public class Identification
    {
        [JsonProperty("country_registered")]
        public string CountryRegistered { get; set; }
        [JsonProperty("legal_authority")]
        public string LegalAuthority { get; set; }
        [JsonProperty("legal_form")]
        public string LegalForm { get; set; }
        [JsonProperty("place_registered")]
        public string PlaceRegistered { get; set; }
        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }
    }
}