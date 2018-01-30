using System.Collections.Generic;
using CompaniesHouse.Response;
using CompaniesHouse.Response.CompanyFiling;

namespace CompaniesHouse.Tests.MapProviders
{
    public class ResolutionCategoriesMapProvider : IEnumDataMapProvider<ResolutionCategory>
    {
        public IReadOnlyDictionary<string, ResolutionCategory> Map => EnumerationMappings.PossibleResolutionCategories;
    }
}
