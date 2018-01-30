using System;
using System.Net.Http;
using CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource;
using Moq;
using NUnit.Framework;

namespace CompaniesHouse.Tests.CompaniesHousePersonsWithSignificantControlTests
{
    [TestFixture]
    public class PersonsWithSignificantControlTestsClientTests
    {
        private CompaniesHousePersonsWithSignificantControlClient _client;

        private CompaniesHouseClientResponse<CompanyPersonsWithSignificantControl> _result;
        private CompanyPersonsWithSignificantControl _peopleWithSignificantControl;

        [Test]
        public void GivenACompaniesHouseCompanyProfileClient_WhenGettingACompanyProfile()
        {
            _people = new PersonsWithSignificantControlBuilder().Build();
            var resource = new CompanyPersonsWithSignificantControlResourceBuilder(_peopleWithSignificantControl).Create();

            var uri = new Uri("https://wibble.com/search/companies");

            HttpMessageHandler handler = new StubHttpMessageHandler(uri, resource);

            var uriBuilder = new Mock<IPersonsWithSignificantControlUriBuilder>();
            uriBuilder.Setup(x => x.Build(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()))
                .Returns(uri);

            _client = new CompaniesHousePersonsWithSignificantControlClient(new HttpClient(handler), uriBuilder.Object);

            _result = _client.GetOfficersAsync("abc", 0, 25).Result;

            _result.Data.ShouldBeEquivalentTo(_people);
        }
    }
}
