﻿using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IPersonsWithSignificantControlUriBuilder
    {
        Uri Build(string companyNumber, int startIndex, int pageSize);
    }
}