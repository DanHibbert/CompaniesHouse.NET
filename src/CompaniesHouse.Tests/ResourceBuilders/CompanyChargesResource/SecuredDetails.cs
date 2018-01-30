using CompaniesHouse.Response.CompanyCharges;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class SecuredDetails
    {
         
        public string Description { get; set; }
         
         
        public SecuredDetailsType Type { get; set; }
    }
}