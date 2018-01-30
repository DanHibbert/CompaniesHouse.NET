using System.Collections.Generic;
using CompaniesHouse.Response;
using CompaniesHouse.Response.CompanyFiling;

namespace CompaniesHouse.Tests.MapProviders
{
    public class FilingSubcategoriesMapProvider : IEnumDataMapProvider<FilingSubcategory>
    {
        public IReadOnlyDictionary<string, FilingSubcategory> Map => EnumerationMappings.PossibleFilingSubcategories;
    }
}
