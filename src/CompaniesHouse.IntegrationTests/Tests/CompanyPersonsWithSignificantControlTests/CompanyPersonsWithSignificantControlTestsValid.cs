using System.Collections.Generic;
using System.Threading.Tasks;
using CompaniesHouse.Response.CompanyCharges;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;
using NUnit.Framework;

namespace CompaniesHouse.IntegrationTests.Tests.CompanyPersonsWithSignificantControlTests
{
    [TestFixtureSource(nameof(TestCases))]
    public class CompanyPersonsWithSignificantControlTestsValid : CompanyPersonsWithSignificantControlTestBase
    {
        private readonly string _companyNumber;
        private List<PersonWithSignificantControlItem> _results;

        public CompanyPersonsWithSignificantControlTestsValid(string companyNumber)
        {
            _companyNumber = companyNumber;
        }

        public static string[] TestCases()
        {
            return new[]
            {
                "03977902", // Google
                "00445790", // Tesco
            };
        }

        protected override async Task When()
        {
            var page = 0;
            var size = 100;
            _results = new List<PersonWithSignificantControlItem>();

            CompaniesHouseClientResponse<CompanyPersonsWithSignificantControl> result;
            do
            {
                result = await _client.GetPersonsWithSignificanControlAsync(_companyNumber, page++ * size, size);
                if (result.Data != null)
                    _results.AddRange(result.Data.Items);
            } while (result.Data != null);
        }

        [Test]
        public void ThenTheDataItemsAreNotEmpty()
        {
            Assert.That(_results, Is.Not.Empty);
        }
    }
}
