using System;

namespace CompaniesHouse.UriBuilders
{
    public class PersonsWithSignificantControlIndividualUriBuilder : IPersonsWithSignificantControlIndividualUriBuilder
    {
        public Uri Build(string companyNumber, string personWithSignificantControlId)
        {
            var path = $"company/{Uri.EscapeDataString(companyNumber)}/persons-with-significant-control/individual/{personWithSignificantControlId}";

            return new Uri(path, UriKind.Relative);
        }
    }
}