using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class CompanyCharges
    {
         
        public string Etag { get; set; }
         
        public List<ChargeItem> Items { get; set; }

         
        public int? PartSatisfiedCount { get; set; }
         
        public int? SatisfiedCount { get; set; }
         
        public string TotalCount { get; set; }

        //TODO check spelling
         
        public string UnfilteredCount { get; set; }
    }
}
