using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IPersonsWithSignificantControlStatementItemUriBuilder
    {
        Uri Build(string companyNumber, string statementId);
    }
}