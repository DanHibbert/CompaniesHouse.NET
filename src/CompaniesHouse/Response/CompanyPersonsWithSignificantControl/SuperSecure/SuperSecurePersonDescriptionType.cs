﻿using System.Runtime.Serialization;

namespace CompaniesHouse.Response.CompanyPersonsWithSignificantControl.SuperSecure
{
    public enum SuperSecurePersonDescriptionType
    {
        [EnumMember(Value = "")]
        None = 0,
        [EnumMember(Value = "super-secure-person-with-significant-control")]
        SuperSecurePersonWithSignificantControl,
    }
}