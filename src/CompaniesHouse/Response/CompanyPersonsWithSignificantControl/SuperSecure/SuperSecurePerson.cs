using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.SuperSecure
{
    public class SuperSecurePerson
    {
        [JsonProperty("ceased")]
        public bool? Ceased { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("etag")]
        public string Etag { get; set; }
        [JsonProperty("kind")]
        public string Kind { get; set; }
        [JsonProperty("links")]
        public Links Links { get; set; }
    }
}