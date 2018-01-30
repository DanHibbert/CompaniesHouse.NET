using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource.SuperSecure
{
    public class SuperSecurePerson
    {
        
        public bool? Ceased { get; set; }
        
        public SuperSecurePersonDescriptionType Description { get; set; }
        
        public string Etag { get; set; }
        
        public SuperSecurePersonType Kind { get; set; }
        
        public Links Links { get; set; }
    }
}