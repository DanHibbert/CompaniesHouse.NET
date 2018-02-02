using System.Runtime.Serialization;

namespace CompaniesHouse.Response.CompanyCharges
{
    public enum ParticularsType
    {
        [EnumMember(Value = "")]
        None = 0,
        [EnumMember(Value = "short-particulars")]
        ShortParticulars,
        [EnumMember(Value = "charged-property-description")]
        ChargedPropertyDescription,
        [EnumMember(Value = "charged-property-or-undertaking-description")]
        ChargedPropertyOrUndertakingDescription,
        [EnumMember(Value = "brief-description")]
        BriefDescription
    }
}