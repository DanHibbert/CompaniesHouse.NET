using System;
namespace CompaniesHouse.UriBuilders
{

    public interface IPersonsWithSignificantControlStatementsUriBuilder
    {
        Uri Build(string companyNumber);
    }
}