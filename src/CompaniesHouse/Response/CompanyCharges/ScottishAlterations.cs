using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyCharges
{
    public class ScottishAlterations
    {
        [JsonProperty("has_alterations_to_order")]
        public string HasAlterationsToOrder { get; set; }
        [JsonProperty("has_alterations_to_prohibitions")]
        public string HasAlterationsToProhibitions { get; set; }
        [JsonProperty("has_restricting_provisions")]
        public string HasRestrictingProvisions { get; set; }
    }
}