using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Response.CompanyCharges
{
    public class ChargeItem
    {
        [JsonProperty("acquired_on")]
        public DateTime? AcquiredOn { get; set; }
        [JsonProperty("assets_ceased_released")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AssetsCeasedReleasedType AssetsCeasedReleased { get; set; }
        [JsonProperty("charge_code")]
        public string ChargeCode { get; set; }
        [JsonProperty("charge_number")]
        public string ChargeNumber { get; set; }
        [JsonProperty("classification")]
        public Classification Classification { get; set; }
        [JsonProperty("covering_instrument_date")]
        public DateTime? CoveringInstrumentDate { get; set; }
        [JsonProperty("created_on")]
        public DateTime? CreatedOn { get; set; }
        [JsonProperty("delivered_on")]
        public DateTime? DeliveredOn { get; set; }
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
        public DateTime? ResolvedOn { get; set; }
        [JsonProperty("satisfied_on")]
        public DateTime? SatisfiedOn { get; set; }
        [JsonProperty("scottish_alterations")]
        public ScottishAlterations ScottishAlterations { get; set; }
        [JsonProperty("secured_details")]
        public SecuredDetails SecuredDetails { get; set; }
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public StatusType Status { get; set; }
        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }
    }
}