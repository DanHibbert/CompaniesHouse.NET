using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl
{
    public class DateOfBirth
    {
        [JsonProperty("day")]
        public int Day { get; set; }
        [JsonProperty("month")]
        public int Month { get; set; }
        [JsonProperty("year")]
        public int Year { get; set; }
    }
}