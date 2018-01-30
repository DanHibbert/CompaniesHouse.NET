
    using System;
    using System.Collections.Generic;
    using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;
namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource
{

    public class PersonWithSignificantControlItem
    {
        
        
        public IEnumerable<NaturesOfControlType> NaturesOfControl { get; set; }
        
        public DateTime? NotifiedOn { get; set; }
        
        public DateOfBirth DateOfBirth { get; set; }
        
        public string Name { get; set; }
        
        public string Nationality { get; set; }
        
        public string Kind { get; set; }
        
        public string CountryOfResidence { get; set; }
        
        public DateTime? CeasedOn { get; set; }
        
        public string Etag { get; set; }
        
        public Address Address { get; set; }
        
        public Links IndividualLinks { get; set; }
        
        public Name NameElements { get; set; }
    }
}