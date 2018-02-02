using System.Linq;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControl
{
    public class CompanyPersonsWithSignificantControlResourceBuilder
    {
        private readonly CompanyPersonsWithSignificantControl _companyPersonsWithSignificantControl;

        public CompanyPersonsWithSignificantControlResourceBuilder(CompanyPersonsWithSignificantControl companyPersonsWithSignificantControl)
        {
            _companyPersonsWithSignificantControl = companyPersonsWithSignificantControl;
        }

        //public string Create()
        //{
        //    return $@"{{
        //               ""etag"" : ""{_companyPersonsWithSignificantControl.ETag}"",
        //               ""filing_history_status"" : ""{_companyPersonsWithSignificantControl.HistoryStatus}"",
        //               ""items"" : [
        //                   {string.Join(",", _companyPersonsWithSignificantControl.Items.Select(GetItemJsonBlock))}
        //               ],
        //               ""items_per_page"" : ""{_companyPersonsWithSignificantControl.ItemsPerPage}"",
        //               ""kind"" : ""{_companyFilingHistory.Kind}"",
        //               ""start_index"" : ""{_companyFilingHistory.StartIndex}"",
        //               ""total_count"" : ""{_companyFilingHistory.TotalCount}""
        //            }}";
        //}

        public string Create()
        {
            return $@"{{
   ""active_count"" : ""{_companyPersonsWithSignificantControl.ActiveCount}"",
   ""ceased_count"" : ""{_companyPersonsWithSignificantControl.CeasedCount}"",
   ""etag"" : ""{_companyPersonsWithSignificantControl.Etag}"",
   ""items"" : [
            {string.Join(",", _companyPersonsWithSignificantControl.Items.Select(GetItemJsonBlock))}
   ],
   ""items_per_page"" : ""integer"",
   ""kind"" : ""string"",
   ""links"" : {{
      ""persons_with_significant_control_statements_list"" : ""string"",
      ""self"" : ""string""
   }},
   ""start_index"" : ""integer"",
   ""total_results"" : ""integer""
}}";
        }

        private string GetItemJsonBlock(PersonWithSignificantControlItem item)
        {
            return $@"{{
         ""address"" : {{
            ""address_line_1"" : ""{item.Address.AddressLine1}"",
            ""address_line_2"" : ""{item.Address.AddressLine2}"",
            ""care_of"" : ""{item.Address.CareOf}"",
            ""country"" : ""{item.Address.Country}"",
            ""locality"" : ""{item.Address.Locality}"",
            ""po_box"" : ""{item.Address.PoBox}"",
            ""postal_code"" : ""{item.Address.PostalCode}"",
            ""premises"" : ""{item.Address.Premises}"",
            ""region"" : ""{item.Address.Region}""
         }},
         ""ceased_on"" : ""{item.CeasedOn}"",
         ""country_of_residence"" : ""{item.CountryOfResidence}"",
         ""date_of_birth"" : {{
            ""day"" : ""{item.DateOfBirth.Day}"",
            ""month"" : ""{item.DateOfBirth.Month}"",
            ""year"" : ""{item.DateOfBirth.Year}""
         }},
         ""etag"" : ""{item.Etag}"",
         ""links"" : {{
            ""self"" : ""{item.IndividualLinks.Self}"",
            ""statement"" : ""{item.IndividualLinks.Statement}""
         }},
         ""name"" : ""{item.Name}"",
         ""name_elements"" : {{
            ""forename"" : ""{item.NameElements.Forename}"",
            ""other_forenames"" : ""{item.NameElements.OtherForenames}"",
            ""surname"" : ""{item.NameElements.Surname}"",
            ""title"" : ""{item.NameElements.Title}""
         }},
         ""nationality"" : ""{item.Nationality}"",
         ""natures_of_control"" : [
            {string.Join(",", $@"""{item.NaturesOfControl}""")}
         ],
         ""notified_on"" : ""date""
      }}";
        }

    }
}
