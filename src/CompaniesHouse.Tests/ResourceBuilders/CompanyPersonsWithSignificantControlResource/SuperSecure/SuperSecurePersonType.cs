using System.Runtime.Serialization;

namespace CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource.SuperSecure
{
    public enum SuperSecurePersonType
    {
        None = 0,
        [EnumMember(Value = "super-secure-person-with-significant-control")]
        SuperSecurePersonWithSignificantControl,
    }
}