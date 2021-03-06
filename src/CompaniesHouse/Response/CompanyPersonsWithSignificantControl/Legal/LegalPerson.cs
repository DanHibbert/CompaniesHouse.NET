using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Legal
{
    public class LegalPerson
    {
        [JsonProperty("address")]
        public Address Address { get; set; }
        [JsonProperty("ceased_on")]
        public DateTime? CeasedOn { get; set; }
        [JsonProperty("etag")]
        public string Etag { get; set; }
        [JsonProperty("identification")]
        public Identification Identification { get; set; }
        [JsonProperty("kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public LegalPersonType Kind { get; set; }
        [JsonProperty("links")]
        public Links Links { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("natures_of_control")]
        public List<string> NaturesOfControl { get; set; }
        [JsonProperty("notified_on")]
        public DateTime? NotifiedOn { get; set; }
    }
}