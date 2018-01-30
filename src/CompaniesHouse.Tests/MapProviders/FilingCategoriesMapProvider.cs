using System.Collections.Generic;
using CompaniesHouse.Response;
using CompaniesHouse.Response.CompanyFiling;

namespace CompaniesHouse.Tests.MapProviders
{
    public class FilingCategoriesMapProvider : IEnumDataMapProvider<FilingCategory>
    {
        public IReadOnlyDictionary<string, FilingCategory> Map => EnumerationMappings.PossibleFilingCategories;
    }
}
