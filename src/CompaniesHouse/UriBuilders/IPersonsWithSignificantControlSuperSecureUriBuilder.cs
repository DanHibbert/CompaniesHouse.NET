using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IPersonsWithSignificantControlSuperSecureUriBuilder
    {
        Uri Build(string companyNumber, string superSecureId);
    }
}