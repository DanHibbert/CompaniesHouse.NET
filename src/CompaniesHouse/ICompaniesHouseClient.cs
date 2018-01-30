﻿namespace CompaniesHouse
{
    public interface ICompaniesHouseClient :
        ICompaniesHouseSearchCompanyClient,
        ICompaniesHouseSearchOfficerClient,
        ICompaniesHouseSearchDisqualifiedOfficerClient,
        ICompaniesHouseSearchAllClient,
        ICompaniesHouseCompanyProfileClient,
        ICompaniesHouseCompanyFilingHistoryClient,
        ICompaniesHouseOfficersClient,
        ICompaniesHouseCompanyInsolvencyInformationClient,
        ICompaniesHouseCompanyChargesClient,
        ICompaniesHousePersonsWithSignificantControlClient
    {

    }
}