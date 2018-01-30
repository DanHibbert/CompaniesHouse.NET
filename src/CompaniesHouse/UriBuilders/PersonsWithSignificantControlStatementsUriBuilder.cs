using System;

namespace CompaniesHouse.UriBuilders
{
    public class PersonsWithSignificantControlStatementsUriBuilder : IPersonsWithSignificantControlStatementsUriBuilder
    {
        public Uri Build(string companyNumber)
        {
            var path = $"company/{Uri.EscapeDataString(companyNumber)}/persons-with-significant-control-statements";

            return new Uri(path, UriKind.Relative);
        }
    }
}