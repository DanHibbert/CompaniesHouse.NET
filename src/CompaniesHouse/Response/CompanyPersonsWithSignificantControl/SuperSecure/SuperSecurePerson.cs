using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.SuperSecure
{
    public class SuperSecurePerson
    {
        [JsonProperty("ceased")]
        public bool? Ceased { get; set; }
        [JsonProperty("description")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SuperSecurePersonDescriptionType Description { get; set; }
        [JsonProperty("etag")]
        public string Etag { get; set; }
        [JsonProperty("kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SuperSecurePersonType Kind { get; set; }
        [JsonProperty("links")]
        public Links Links { get; set; }
    }
}