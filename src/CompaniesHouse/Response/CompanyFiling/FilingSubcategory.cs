using System.Runtime.Serialization;

namespace CompaniesHouse.Response.CompanyFiling
{
    public enum FilingSubcategory
    {
        None = 0,

        [EnumMember(Value = "annual-return")]
        AnnualReturn,

        [EnumMember(Value = "resolution")]
        Resolution,

        [EnumMember(Value = "change")]
        Change,

        [EnumMember(Value = "create")]
        Create,

        [EnumMember(Value = "certificate")]
        Certificate,

        [EnumMember(Value = "appointments")]
        Appointments,

        [EnumMember(Value = "satisfy")]
        Satisfy,

        [EnumMember(Value = "termination")]
        Termination,

        [EnumMember(Value = "release-cease")]
        ReleaseCease,

        [EnumMember(Value = "voluntary")]
        Voluntary,

        [EnumMember(Value = "administration")]
        Administration
    }
}