using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource.Statements
{
    public class StatementList
    {
        
        public int? ActiveCount { get; set; }
        
        public int? CeasedCount { get; set; }
        
        public string Etag { get; set; }
        
        public List<StatementItem> Items { get; set; }
        
        public string ItemsPerPage { get; set; }
        
        public string Kind { get; set; }
        
        public ListLink Links { get; set; }
        
        public string StartIndex { get; set; }
        
        public int TotalResults { get; set; }
    }
}