using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class InsolvencyCases
    {
         
        public string CaseNumber { get; set; }
         
        public CaseLinks Links { get; set; }
         
        public string TransactionId { get; set; }
    }
}