using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControl.Error
{
    public class Error
    {
        
        public string ErrorInfo { get; set; }
        
        public Dictionary<string, string> ErrorValues { get; set; }
        
        public string Location { get; set; }
        
        public string LocationType { get; set; }
        
        public string Type { get; set; }
    }
}