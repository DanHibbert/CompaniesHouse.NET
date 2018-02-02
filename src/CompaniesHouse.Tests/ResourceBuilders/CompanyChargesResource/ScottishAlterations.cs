using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class ScottishAlterations
    {
         
        public bool HasAlterationsToOrder { get; set; }
         
        public bool HasAlterationsToProhibitions { get; set; }
         
        public bool HasRestrictingProvisions { get; set; }
    }
}