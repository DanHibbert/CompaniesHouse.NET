using System.Runtime.Serialization;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Corporate
{
    public enum CorporateEntityType
    {
        [EnumMember(Value = "")]
        None = 0,
        [EnumMember(Value = "corporate-entity-person-with-significant-control")]
        CorporateEntityPersonPersonWithSignificantControl,
    }
}