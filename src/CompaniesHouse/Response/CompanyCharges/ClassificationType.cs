using System.Runtime.Serialization;

namespace CompaniesHouse.Response.CompanyCharges
{
    public enum ClassificationType
    {
        [EnumMember(Value = "")]
        None = 0,
        [EnumMember(Value = "charge-description")]
        ChargeDescription,
        [EnumMember(Value = "nature-of-charge")]
        NatureOfCharge,


    }
}