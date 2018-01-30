using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class Transaction
    {
         
        public string DeliveredOn { get; set; }
         
        public string FilingType { get; set; }
         
        public string InsolvencyCaseNumber { get; set; }
         
        public TransactionLinks Links { get; set; }
         
        public string TransactionId { get; set; }
    }
}