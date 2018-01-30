using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource
{
    public class CompanyPersonsWithSignificantControl
    {
        
        public string Etag { get; set; }
        
        public List<PersonWithSignificantControlItem> Items { get; set; }
        
        public int TotalResults { get; set; }
        
        public int StartIndex { get; set; }
        
        public string Kind { get; set; }
        
        public CompanyPersonsWithSignificantControlLinks Links { get; set; }
        
        public int? ActiveCount { get; set; }
        
        public int ItemsPerPage { get; set; }
        
        public int? CeasedCount { get; set; }
    }
}