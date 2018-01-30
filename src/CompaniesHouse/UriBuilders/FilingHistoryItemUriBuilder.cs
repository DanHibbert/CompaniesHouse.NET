using System;

namespace CompaniesHouse.UriBuilders
{
    public class FilingHistoryItemUriBuilder : IFilingHistoryItemUriBuilder
    {
        public Uri Build(string companyNumber, string transactionId)
        {
            var path = $"company/{Uri.EscapeDataString(companyNumber)}/filing-history/{transactionId}";

            return new Uri(path, UriKind.Relative);
        }
    }
}