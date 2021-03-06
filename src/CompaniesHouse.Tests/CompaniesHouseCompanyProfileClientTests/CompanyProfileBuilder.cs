using System.Linq;
using CompaniesHouse.Response.CompanyProfile;
using Ploeh.AutoFixture;
using Accounts = CompaniesHouse.Tests.ResourceBuilders.Accounts;
using AnnualReturn = CompaniesHouse.Tests.ResourceBuilders.CompanyFilingHistoryResource.AnnualReturn;
using CompanyProfile = CompaniesHouse.Tests.ResourceBuilders.CompanyProfile;
using ConfirmationStatement = CompaniesHouse.Tests.ResourceBuilders.ConfirmationStatement;
using LastAccounts = CompaniesHouse.Tests.ResourceBuilders.LastAccounts;
using Officer = CompaniesHouse.Tests.ResourceBuilders.Officer;
using OfficerSummary = CompaniesHouse.Tests.ResourceBuilders.OfficerSummary;

namespace CompaniesHouse.Tests.CompaniesHouseCompanyProfileClientTests
{
    public class CompanyProfileBuilder
    {
        public ResourceBuilders.CompanyProfile Build(CompaniesHouseCompanyProfileClientTestCase testCase)
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ResourceBuilders.LastAccounts>(x => x.MadeUpTo));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ResourceBuilders.Accounts>(x => x.NextMadeUpTo));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ResourceBuilders.Accounts>(x => x.NextDue));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<AnnualReturn>(x => x.LastMadeUpTo));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<AnnualReturn>(x => x.NextDue));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<AnnualReturn>(x => x.NextMadeUpTo));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ResourceBuilders.CompanyProfile>(x => x.DateOfCreation));
            fixture.Customizations.Add(
                new UniversalDateSpecimenBuilder<ResourceBuilders.CompanyProfile>(x => x.DateOfDissolution));
            fixture.Customizations.Add(
                new UniversalDateSpecimenBuilder<ResourceBuilders.CompanyProfile>(x => x.LastFullMembersListDate));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ResourceBuilders.Officer>(x => x.AppointedOn));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ResourceBuilders.Officer>(x => x.ResignedOn));

            fixture.Customizations.Add(new UniversalNullableDateSpecimenBuilder<ResourceBuilders.ConfirmationStatement>(x => x.NextMadeUpTo));
            fixture.Customizations.Add(new UniversalNullableDateSpecimenBuilder<ResourceBuilders.ConfirmationStatement>(x => x.LastMadeUpTo));
            fixture.Customizations.Add(new UniversalNullableDateSpecimenBuilder<ResourceBuilders.ConfirmationStatement>(x => x.NextDue));

            var lastAccounts = fixture.Build<ResourceBuilders.LastAccounts>()
                .With(x => x.Type, testCase.LastAccountsType)
                .Create();

            var accounts = fixture.Build<ResourceBuilders.Accounts>()
                .With(x => x.LastAccounts, lastAccounts)
                .Create();

            var officers = EnumerationMappings.PossibleOfficerRoles.Keys.Select(x => fixture.Build<ResourceBuilders.Officer>()
                .With(y => y.OfficerRole, x)
                .Create()).ToArray();

            var officerSummary = fixture.Build<ResourceBuilders.OfficerSummary>().With(x => x.Officers, officers).Create();

            var companyProfile = fixture.Build<ResourceBuilders.CompanyProfile>()
                .With(x => x.Accounts, accounts)
                .With(x => x.CompanyStatus, testCase.CompanyStatus)
                .With(x => x.CompanyStatusDetail, testCase.CompanyStatusDetail)
                .With(x => x.Jurisdiction, testCase.Jurisdiction)
                .With(x => x.Type, testCase.Type)
                .With(x => x.OfficerSummary, officerSummary)
                .Create();

            return companyProfile;
        }
    }
}