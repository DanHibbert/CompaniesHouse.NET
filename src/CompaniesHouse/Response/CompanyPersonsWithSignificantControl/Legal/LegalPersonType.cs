using System.Runtime.Serialization;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Legal
{
    public enum LegalPersonType
    {
        [EnumMember(Value = "")]
        None = 0,
        [EnumMember(Value = "legal-person-with-significant-control")]
        LegalPersonWithSignificantControl,
    }
}