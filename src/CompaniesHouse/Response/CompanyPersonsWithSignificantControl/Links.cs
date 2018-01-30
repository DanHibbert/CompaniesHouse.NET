using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl
{
    public class CompanyPersonsWithSignificantControlLinks
    {
        [JsonProperty("persons_with_significant_control_statements_list")]
        public string PersonWithSignificantControlStatementsList { get; set; }

        [JsonProperty("statement")]
        public string Statement { get; set; }
    }


    public class Links
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("statement")]
        public string Statement { get; set; }
    }


}