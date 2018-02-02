using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Error
{
    public class Error
    {
        [JsonProperty("error")]
        public string ErrorInfo { get; set; }
        [JsonProperty("error_values")]
        public Dictionary<string, string> ErrorValues { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        [JsonProperty("location_type")]
        public string LocationType { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}