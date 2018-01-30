using System;

namespace CompaniesHouse.UriBuilders
{
    public class PersonsWithSignificantControlStatementsUriBuilder : IPersonsWithSignificantControlStatementsUriBuilder
    {
        public Uri Build(string companyNumber, int startIndex, int pageSize)
        {
            var path = $"company/{Uri.EscapeDataString(companyNumber)}/persons-with-significant-control-statements?items_per_page={pageSize}&start_index={startIndex}";
            return new Uri(path, UriKind.Relative);
        }
    }
}