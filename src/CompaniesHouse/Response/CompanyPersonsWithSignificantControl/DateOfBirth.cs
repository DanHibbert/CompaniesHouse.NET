using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl
{
    public class DateOfBirth
    {
        [JsonProperty("year")]
        public int Year { get; set; }
        [JsonProperty("month")]
        public int Month { get; set; }
    }
}