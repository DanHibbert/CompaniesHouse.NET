using System.Threading.Tasks;
using CompaniesHouse.Response.CompanyCharges;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;
using NUnit.Framework;

namespace CompaniesHouse.IntegrationTests.Tests.CompanyPersonsWithSignificantControlTests
{
    [TestFixture]
    public class CompanyPersonsWithSignificantControlTestsInvalid : CompanyPersonsWithSignificantControlTestBase
    {
        private const string InvalidCompanyNumber = "ABC00000";

        private CompaniesHouseClientResponse<CompanyPersonsWithSignificantControl> _result;

        protected override async Task When()
        {
            await WhenRetrievingAnCompanyPersonsWithSignificanControlForAnInvalidCompany().ConfigureAwait(false);
        }

        [Test]
        public void ThenTheDataIsNull()
        {
            Assert.That(_result.Data, Is.Null);
        }

        private async Task WhenRetrievingAnCompanyPersonsWithSignificanControlForAnInvalidCompany()
        {
            _result = await _client.GetPersonsWithSignificanControlAsync(InvalidCompanyNumber, 0, 25);
        }
    }
}
