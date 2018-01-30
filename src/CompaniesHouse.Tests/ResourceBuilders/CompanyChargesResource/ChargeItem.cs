using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class ChargeItem
    {
        [JsonProperty("acquired_on")]
        public string AcquiredOn { get; set; }
        [JsonProperty("assets_ceased_released")]
        public string AssetsCeasedReleased { get; set; }
        [JsonProperty("charge_code")]
        public string ChargeCode { get; set; }
        [JsonProperty("charge_number")]
        public string ChargeNumber { get; set; }
        [JsonProperty("classification")]
        public Classification Classification { get; set; }
        [JsonProperty("covering_instrument_date")]
        public string CoveringInstrumentDate { get; set; }
        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
        [JsonProperty("delivered_on")]
        public string DeliveredOn { get; set; }
        [JsonProperty("etag")]
        public string Etag { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("insolvency_cases")]
        public List<InsolvencyCases> InsolvencyCases { get; set; }
        [JsonProperty("links")]
        public Links Links { get; set; }
        [JsonProperty("more_than_four_persons_entitled")]
        public string MoreThanFourPersonsEntitled { get; set; }
        [JsonProperty("particulars")]
        public Particulars Particulars { get; set; }
        [JsonProperty("persons_entitled")]
        public List<PersonsEntitled> PersonsEntitled { get; set; }
        [JsonProperty("resolved_on")]
        public string ResolvedOn { get; set; }
        [JsonProperty("satisfied_on")]
        public string SatisfiedOn { get; set; }
        [JsonProperty("scottish_alterations")]
        public ScottishAlterations ScottishAlterations { get; set; }
        [JsonProperty("secured_details")]
        public SecuredDetails SecuredDetails { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }
    }
}