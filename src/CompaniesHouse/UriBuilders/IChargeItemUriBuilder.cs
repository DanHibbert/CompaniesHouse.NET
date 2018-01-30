using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IChargeItemUriBuilder
    {
        Uri Build(string companyNumber, string chargeId);
    }
}