using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompaniesHouse.Response.CompanyCharges;
using NUnit.Framework;

namespace CompaniesHouse.IntegrationTests.Tests.CompanyChargesTests
{
    [TestFixtureSource(nameof(TestCases))]
    public class CompanyChargesTestsValid : CompanyChargesTestBase
    {
        private readonly string _companyNumber;
        private List<ChargeItem> _results;

        public CompanyChargesTestsValid(string companyNumber)
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
            _results = new List<ChargeItem>();

            CompaniesHouseClientResponse<CompanyCharges> result;
            do
            {
                result = await _client.GetCompanyChargesAsync(_companyNumber, page++ * size, size);
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
