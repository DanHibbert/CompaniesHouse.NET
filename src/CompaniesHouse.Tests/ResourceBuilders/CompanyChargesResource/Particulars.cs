using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class Particulars
    {
         
        public string ChargorActingAsBareTrustee { get; set; }
         
        public string ContainsFixedCharge { get; set; }
         
        public string ContainsFloatingCharge { get; set; }
         
        public string ContainsNegativePledge { get; set; }
         
        public string Description { get; set; }
         
        public string FloatingChargeCoversAll { get; set; }
         
         
        public string Type { get; set; }
    }
}