using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IPersonsWithSignificantControlSuperSecurePersonUriBuilder
    {
        Uri Build(string companyNumber, string superSecureId);
    }
}