using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource.Corporate
{
    public class CorporateEntity
    {
        
        public Address Address { get; set; }
        
        public DateTime? CeasedOn { get; set; }
        
        public string Etag { get; set; }
        
        public Identification Identification { get; set; }
        
        public string Kind { get; set; }
        
        public Links Links { get; set; }
        
        public string Name { get; set; }
        
        public List<string> NaturesOfControl { get; set; }
        
        public DateTime? NotifiedOn { get; set; }
    }
}