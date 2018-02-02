using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Statements
{
    public class StatementItem
    {
        [JsonProperty("ceased_on")]
        public DateTime? CeasedOn { get; set; }
        [JsonProperty("etag")]
        public string Etag { get; set; }
        [JsonProperty("kind")]
        public string Kind { get; set; }
        [JsonProperty("linked_psc_name")]
        public string LinkedPscName { get; set; }
        [JsonProperty("links")]
        public Link Links { get; set; }
        [JsonProperty("notified_on")]
        public DateTime? NotifiedOn { get; set; }
        [JsonProperty("restrictions_notice_withdrawal_reason")]
        public string RestrictionsNoticeWithdrawalReason { get; set; }
        [JsonProperty("statement")]
        [JsonConverter(typeof(StringEnumConverter))]
        public StatementType Statement { get; set; }
    }
}