using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Response.CompanyCharges
{
    public class Classification
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ClassificationType Type { get; set; }
    }
}