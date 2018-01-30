using System;

namespace CompaniesHouse.UriBuilders
{
    public class ChargeItemUriBuilder : IChargeItemUriBuilder
    {
        public Uri Build(string companyNumber, string chargeId)
        {
            var path = $"company/{Uri.EscapeDataString(companyNumber)}/charges/{chargeId}";

            return new Uri(path, UriKind.Relative);
        }
    }
}