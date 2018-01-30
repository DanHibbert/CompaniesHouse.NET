using System;

namespace CompaniesHouse.UriBuilders
{
    public class PersonsWithSignificantControlUriCorporateEntitiesBuilder : IPersonsWithSignificantControlUriCorporateEntitiesBuilder
    {
        public Uri Build(string companyNumber, string personWithSignificantControlId)
        {
            var path = $"company/{Uri.EscapeDataString(companyNumber)}/persons-with-significant-control/corporate-entity/{personWithSignificantControlId}";

            return new Uri(path, UriKind.Relative);
        }
    }
}