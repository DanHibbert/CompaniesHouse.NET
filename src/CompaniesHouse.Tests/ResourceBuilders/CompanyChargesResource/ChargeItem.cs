using System;
using System.Collections.Generic;
using CompaniesHouse.Response.CompanyCharges;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource
{
    public class ChargeItem
    {
         
        public DateTime AcquiredOn { get; set; }
         
         
        public string AssetsCeasedReleasedType { get; set; }
         
        public string ChargeCode { get; set; }
         
        public string ChargeNumber { get; set; }
         
        public Classification Classification { get; set; }
         
        public DateTime CoveringInstrumentDate { get; set; }
         
        public DateTime CreatedOn { get; set; }
         
        public DateTime DeliveredOn { get; set; }
         
        public string Etag { get; set; }
         
        public string Id { get; set; }
         
        public List<InsolvencyCases> InsolvencyCases { get; set; }
         
        public Links Links { get; set; }
         
        public string MoreThanFourPersonsEntitled { get; set; }
         
        public Particulars Particulars { get; set; }
         
        public List<PersonsEntitled> PersonsEntitled { get; set; }
         
        public DateTime ResolvedOn { get; set; }
         
        public DateTime SatisfiedOn { get; set; }
         
        public ScottishAlterations ScottishAlterations { get; set; }
         
        public SecuredDetails SecuredDetails { get; set; }
         
         
        public string StatusType { get; set; }
         
        public List<Transaction> Transactions { get; set; }
    }
}