using System.Runtime.Serialization;

namespace CompaniesHouse.Response.CompanyCharges
{
    public enum SecuredDetailsType
    {
        [EnumMember(Value = "")]
        None = 0,
        [EnumMember(Value = "amount-secured")]
        AmountSecured,
        [EnumMember(Value = "obligations-secured")]
        ObligationsSecured,
    }
}