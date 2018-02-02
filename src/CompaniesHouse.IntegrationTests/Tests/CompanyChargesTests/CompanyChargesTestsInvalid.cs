using System.Threading.Tasks;
using CompaniesHouse.IntegrationTests.Tests.CompanyChargesTests;
using CompaniesHouse.Response.CompanyCharges;
using CompaniesHouse.Response.CompanyFiling;
using NUnit.Framework;

namespace CompaniesHouse.IntegrationTests.Tests.CompanyChargesTests
{
    [TestFixture]
    public class CompanyChargesTestsInvalid : CompanyChargesTestBase
    {
        private const string InvalidCompanyNumber = "ABC00000";

        private CompaniesHouseClientResponse<CompanyCharges> _result;

        protected override async Task When()
        {
            await WhenRetrievingAnCompanyChargesForAnInvalidCompany().ConfigureAwait(false);
        }

        [Test]
        public void ThenTheDataIsNull()
        {
            Assert.That(_result.Data, Is.Null);
        }

        private async Task WhenRetrievingAnCompanyChargesForAnInvalidCompany()
        {
            _result = await _client.GetCompanyChargesAsync(InvalidCompanyNumber);
        }
    }
}
