using System.Runtime.Serialization;

namespace CompaniesHouse.Response.CompanyCharges
{
    public enum Status
    {
        None = 0,
        [EnumMember(Value = "outstanding")]
        Outstanding,
        [EnumMember(Value = "fully-satisfied")]
        FullySatisfied,
        [EnumMember(Value = "part-satisfied")]
        PartSatisfied,
        [EnumMember(Value = "satisfied")]
        Satisfied
    }
}