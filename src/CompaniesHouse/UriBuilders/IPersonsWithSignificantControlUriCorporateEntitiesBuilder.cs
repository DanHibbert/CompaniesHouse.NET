using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IPersonsWithSignificantControlUriCorporateEntitiesBuilder
    {
        Uri Build(string companyNumber, string personWithSignificantControlId);
    }
}