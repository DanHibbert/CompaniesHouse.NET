using System.Linq;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource.SuperSecure
{
    public class SuperSecurePersonResourceBuilder
    {
        private readonly SuperSecurePerson _superSecurePerson;

        public SuperSecurePersonResourceBuilder(SuperSecurePerson superSecurePerson)
        {
            _superSecurePerson = superSecurePerson;
        }

        public string Create()
        {
            return $@"{{
   ""ceased"" : ""{_superSecurePerson.Ceased}"",
   ""description"" : ""{_superSecurePerson.Description}"",
   ""etag"" : ""{_superSecurePerson.Etag}"",
   ""kind"" : ""{_superSecurePerson.Kind}"",
   ""links"" : {{
      ""self"" : ""{_superSecurePerson.Links.Self}""
   }}
}}";
        }



    }
}
