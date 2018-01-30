using System.Linq;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;
using CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource.SuperSecure;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource.Legal
{
    public class LegalPersonResourceBuilder
    {
        private readonly LegalPerson _legalPerson;

        public LegalPersonResourceBuilder(LegalPerson legalPerson)
        {
            _legalPerson = legalPerson;
        }

        public string Create()
        {
            return $@"{{
   ""address"" : {{
      ""address_line_1"" : ""{_legalPerson.Address.AddressLine1}"",
      ""address_line_2"" : ""{_legalPerson.Address.AddressLine1}"",
      ""care_of"" : ""{_legalPerson.Address.CareOf}"",
      ""country"" : ""{_legalPerson.Address.Country}"",
      ""locality"" : ""{_legalPerson.Address.Locality}"",
      ""po_box"" : ""{_legalPerson.Address.PoBox}"",
      ""postal_code"" : ""{_legalPerson.Address.PostalCode}"",
      ""premises"" : ""{_legalPerson.Address.Premises}"",
      ""region"" : ""{_legalPerson.Address.Region}""
   }},
   ""ceased_on"" : ""{_legalPerson.CeasedOn}"",
   ""etag"" : ""{_legalPerson.Etag}"",
   ""identification"" : {{
      ""legal_authority"" : ""{_legalPerson.Identification.LegalAuthority}"",
      ""legal_form"" : ""{_legalPerson.Identification.LegalForm}""
   }},
   ""kind"" : ""{_legalPerson.Kind}"",  
   ""links"" : {{
      ""self"" : ""{_legalPerson.Links.Self}"",
      ""statement"" : ""{_legalPerson.Links.Statement}""
   }},
   ""name"" : ""{_legalPerson.Name}"",
   ""natures_of_control"" : [
            {string.Join(",", _legalPerson.NaturesOfControl.Select(e=> e.ToString()))}
   ],
   ""notified_on"" : ""date""
}}";
        }




    }
}
