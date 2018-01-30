using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IFilingHistoryItemUriBuilder
    {
        Uri Build(string companyNumber, string transactionId);
    }
}