using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource
{
    public class Name
    {
        
        public string Forename { get; set; }
        public string OtherForenames { get; set; }

        public string Title { get; set; }

        public string Surname { get; set; }
    }
}