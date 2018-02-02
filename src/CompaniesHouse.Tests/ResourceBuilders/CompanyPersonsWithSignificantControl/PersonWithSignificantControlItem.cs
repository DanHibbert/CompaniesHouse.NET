using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControl
{
    public class PersonWithSignificantControlItem
    {
        //change        
        public IEnumerable<string> NaturesOfControl { get; set; }
        
        public DateTime NotifiedOn { get; set; }
        
        public DateOfBirth DateOfBirth { get; set; }
        
        public string Name { get; set; }
        
        public string Nationality { get; set; }
        
        public string Kind { get; set; }
        
        public string CountryOfResidence { get; set; }
        
        public DateTime CeasedOn { get; set; }
        
        public string Etag { get; set; }
        
        public Address Address { get; set; }
        
        public Links IndividualLinks { get; set; }
        
        public Name NameElements { get; set; }
    }
}