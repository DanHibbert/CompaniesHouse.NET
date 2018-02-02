using System;
using System.Net.Http;
using CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControl;
using CompaniesHouse.UriBuilders;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using Real = CompaniesHouse.Response.CompanyPersonsWithSignificantControl;

namespace CompaniesHouse.Tests.CompaniesHousePersonsWithSignificantControlTests
{
    [TestFixture]
    public class CompaniesHousePersonsWithSignificantControlTestsClientTests
    {
        private CompaniesHousePersonsWithSignificantControlClient _client;

        private CompaniesHouseClientResponse<Real.CompanyPersonsWithSignificantControl> _result;
        private CompanyPersonsWithSignificantControl _peopleWithSignificantControl;

        [Test]
        public void GivenACompaniesHouseCompanyProfileClient_WhenGettingACompanyProfile()
        {
            _peopleWithSignificantControl = new CompaniesHousePersonsWithSignificantControlBuilder().Build();
            var resource = new CompanyPersonsWithSignificantControlResourceBuilder(_peopleWithSignificantControl).Create();

            var uri = new Uri("https://wibble.com/search/companies");

            HttpMessageHandler handler = new StubHttpMessageHandler(uri, resource);

            var uriBuilder = new Mock<IPersonsWithSignificantControlUriBuilder>();
            uriBuilder.Setup(x => x.Build(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()))
                .Returns(uri);

            var uriIndividualBuilder = new Mock<IPersonsWithSignificantControlIndividualUriBuilder>();
            uriIndividualBuilder.Setup(x => x.Build(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(uri);

            var uriStatementItemBuilder = new Mock<IPersonsWithSignificantControlStatementItemUriBuilder>();
            uriStatementItemBuilder.Setup(x => x.Build(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(uri);

            var uriStatementsBuilder = new Mock<IPersonsWithSignificantControlStatementsUriBuilder>();
            uriStatementsBuilder.Setup(x => x.Build(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()))
                .Returns(uri);

            var uriSuperSecureBuilder = new Mock<IPersonsWithSignificantControlSuperSecurePersonUriBuilder>();
            uriSuperSecureBuilder.Setup(x => x.Build(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(uri);
            var uriCorporateBuilder = new Mock<IPersonsWithSignificantControlUriCorporateEntitiesBuilder>();
            uriCorporateBuilder.Setup(x => x.Build(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(uri);

            var uriLegalPersonBuilder = new Mock<IPersonsWithSignificantControlUriLegalPersonBuilder>();
            uriLegalPersonBuilder.Setup(x => x.Build(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(uri);

            _client = new CompaniesHousePersonsWithSignificantControlClient(new HttpClient(handler), uriBuilder.Object, uriIndividualBuilder.Object, uriStatementsBuilder.Object, uriStatementItemBuilder.Object, uriSuperSecureBuilder.Object, uriCorporateBuilder.Object, uriLegalPersonBuilder.Object);

            _result = _client.GetPersonsWithSignificanControlAsync("abc", 0, 25).Result;

            _result.Data.ShouldBeEquivalentTo(_peopleWithSignificantControl);
        }
    }
}
