using System.Runtime.Serialization;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Legal
{
    public enum LegalPersonType
    {
        None = 0,
        [EnumMember(Value = "legal-person-with-significant-control")]
        LegalPersonWithSignificantControl,
    }
}