using System;

namespace CompaniesHouse.UriBuilders
{
    public class PersonsWithSignificantControlUriLegalPersonBuilder : IPersonsWithSignificantControlUriLegalPersonBuilder
    {
        public Uri Build(string companyNumber, string personWithSignificantControlId)
        {
            var path = $"company/{Uri.EscapeDataString(companyNumber)}/persons-with-significant-control/legal-person/{personWithSignificantControlId}";

            return new Uri(path, UriKind.Relative);
        }
    }
}