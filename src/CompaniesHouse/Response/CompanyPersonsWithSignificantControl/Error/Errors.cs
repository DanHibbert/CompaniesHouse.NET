using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Error
{
    public class Errors
    {
        [JsonProperty("errors")]
        public List<Error> PSCErrors { get; set; }
    }
}