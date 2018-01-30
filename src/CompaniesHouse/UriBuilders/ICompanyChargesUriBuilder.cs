using System;

namespace CompaniesHouse.UriBuilders
{
    public interface ICompanyChargesUriBuilder
    {
        Uri Build(string companyNumber, int startIndex, int pageSize);
    }

    public class CompanyChargesUriBuilder : ICompanyChargesUriBuilder
    {
        public Uri Build(string companyNumber, int startIndex, int pageSize)
        {
            var path = $"company/{Uri.EscapeDataString(companyNumber)}/charges?items_per_page={pageSize}&start_index={startIndex}";

            return new Uri(path, UriKind.Relative);
        }
    }
}