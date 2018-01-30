using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource
{
    public class PersonWithSignificantControlItem
    {
        [JsonProperty("natures_of_control")]
        public IEnumerable<string> NaturesOfControl { get; set; }
        [JsonProperty("notified_on")]
        public string NotifiedOn { get; set; }
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
        [JsonProperty("etag")]
        public string Etag { get; set; }
        [JsonProperty("address")]
        public Address Address { get; set; }
        [JsonProperty("links")]
        public Links Links { get; set; }
        [JsonProperty("name_elements")]
        public NameElements NameElements { get; set; }
    }
}