using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl
{
    public class PersonWithSignificantControlItem
    {
        [JsonProperty("natures_of_control")]
        [JsonConverter(typeof(StringEnumConverter))]
        public IEnumerable<NaturesOfControlType> NaturesOfControl { get; set; }
        [JsonProperty("notified_on")]
        public DateTime? NotifiedOn { get; set; }
        [JsonProperty("date_of_birth")]
        public DateOfBirth DateOfBirth { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("nationality")]
        public string Nationality { get; set; }
        [JsonProperty("kind")]
        public string Kind { get; set; }
        [JsonProperty("country_of_residence")]
        public string CountryOfResidence { get; set; }
        [JsonProperty("ceased_on")]
        public DateTime? CeasedOn { get; set; }
        [JsonProperty("etag")]
        public string Etag { get; set; }
        [JsonProperty("address")]
        public Address Address { get; set; }
        [JsonProperty("links")]
        public Links IndividualLinks { get; set; }
        [JsonProperty("name_elements")]
        public Name NameElements { get; set; }
    }
}