﻿using System;

namespace CompaniesHouse.UriBuilders
{
    public class PersonsWithSignificantControlStatementItemUriBuilder : IPersonsWithSignificantControlStatementItemUriBuilder
    {
        public Uri Build(string companyNumber, string statementId)
        {
            var path = $"company/{Uri.EscapeDataString(companyNumber)}/persons-with-significant-control-statements/{statementId}";

            return new Uri(path, UriKind.Relative);
        }
    }
}