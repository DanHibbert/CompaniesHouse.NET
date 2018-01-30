using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IPersonsWithSignificantControlUriLegalPersonBuilder
    {
        Uri Build(string companyNumber, string personWithSignificantControlId);
    }
}