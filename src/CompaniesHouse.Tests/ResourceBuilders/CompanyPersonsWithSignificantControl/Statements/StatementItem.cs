using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControl.Statements
{
    public class StatementItem
    {
        
        public DateTime CeasedOn { get; set; }
        
        public string Etag { get; set; }
        
        public string Kind { get; set; }
        
        public string LinkedPscName { get; set; }
        
        public Link Links { get; set; }
        
        public DateTime NotifiedOn { get; set; }
        
        public string RestrictionsNoticeWithdrawalReason { get; set; }
        
        
        public string Statement { get; set; }
    }
}