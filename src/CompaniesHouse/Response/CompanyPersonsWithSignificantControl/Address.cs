using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl
{
    public class Address
    {
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("premises")]
        public string Premises { get; set; }
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
        [JsonProperty("locality")]
        public string Locality { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("address_line_1")]
        public string AddressLine { get; set; }
    }
}