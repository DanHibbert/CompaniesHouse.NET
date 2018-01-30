using System;

namespace CompaniesHouse.UriBuilders
{
    class PersonsWithSignificantControlSuperSecurePersonUriBuilder : IPersonsWithSignificantControlSuperSecurePersonUriBuilder
    {
        public Uri Build(string companyNumber, string superSecureId)
        {
            var path = $"company/{Uri.EscapeDataString(companyNumber)}/persons-with-significant-control/super-secure/{superSecureId}";

            return new Uri(path, UriKind.Relative);
        }
    }
}