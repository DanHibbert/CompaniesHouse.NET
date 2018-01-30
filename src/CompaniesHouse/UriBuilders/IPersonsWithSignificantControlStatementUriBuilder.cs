using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IPersonsWithSignificantControlStatementUriBuilder
    {
        Uri Build(string companyNumber, string statementId);
    }
}