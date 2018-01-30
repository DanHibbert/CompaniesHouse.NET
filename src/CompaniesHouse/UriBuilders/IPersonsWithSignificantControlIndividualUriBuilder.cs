using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IPersonsWithSignificantControlIndividualUriBuilder
    {
        Uri Build(string companyNumber, string personWithSignificantControlId);
    }
}