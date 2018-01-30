using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Response.CompanyCharges
{
    public class SecuredDetails
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SecuredDetailsType Type { get; set; }
    }
}