using CompaniesHouse.Response.CompanyCharges;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class Classification
    {
         
        public string Description { get; set; }
         
         
        public ClassificationType Type { get; set; }
    }
}