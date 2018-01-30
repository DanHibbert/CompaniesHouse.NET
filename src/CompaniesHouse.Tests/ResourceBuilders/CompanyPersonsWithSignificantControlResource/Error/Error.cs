using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource.Error
{
    public class Error
    {
        
        public string ErrorInfo { get; set; }
        
        public List<ErrorValues> ErrorValues { get; set; }
        
        public string Location { get; set; }
        
        public string LocationType { get; set; }
        
        public string Type { get; set; }
    }
}