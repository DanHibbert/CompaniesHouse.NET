using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl
{
    public class NameElements
    {
        [JsonProperty("forename")]
        public string Forename { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("surname")]
        public string Surname { get; set; }
    }
}