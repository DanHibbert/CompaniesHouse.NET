using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyCharges
{
    public class Particulars
    {
        [JsonProperty("chargor_acting_as_bare_trustee")]
        public string ChargorActingAsBareTrustee { get; set; }
        [JsonProperty("contains_fixed_charge")]
        public string ContainsFixedCharge { get; set; }
        [JsonProperty("contains_floating_charge")]
        public string ContainsFloatingCharge { get; set; }
        [JsonProperty("contains_negative_pledge")]
        public string ContainsNegativePledge { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("floating_charge_covers_all")]
        public string FloatingChargeCoversAll { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}