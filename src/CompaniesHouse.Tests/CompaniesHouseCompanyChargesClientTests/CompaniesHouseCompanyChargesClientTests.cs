using System;
using System.Linq;
using System.Net.Http;
using CompaniesHouse.Tests.CompaniesHouseCompanyFilingHistoryClientTests;
using CompaniesHouse.Tests.ResourceBuilders;
using CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource;
using CompaniesHouse.Tests.ResourceBuilders.CompanyFilingHistoryResource;
using CompaniesHouse.UriBuilders;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using CompanyCharges = CompaniesHouse.Response.CompanyCharges.CompanyCharges;

namespace CompaniesHouse.Tests.CompaniesHouseCompanyChargesClientTests
{
    [TestFixture]
    public class CompaniesHouseCompanyChargesClientTests
    {
        private CompaniesHouseCompanyChargesClient _client;

        private CompaniesHouseClientResponse<Response.CompanyCharges.CompanyCharges> _result;
        private ResourceBuilders.CompanyChargesResource.CompanyCharges _companyCharges;

        [TestCaseSource(nameof(TestCases))]
        public void GivenACompaniesHouseCompanyProfileClient_WhenGettingACompanyProfile(CompaniesHouseCompanyChargesClientTestCase testCase)
        {
            _companyCharges = new CompanyChargesBuilder().Build(testCase);
            var resource = new CompanyChargesResourceBuilder(_companyCharges)
                                .Create();

            var uri = new Uri("https://wibble.com/search/companies");

            HttpMessageHandler handler = new StubHttpMessageHandler(uri, resource);

            var uriBuilder = new Mock<ICompanyChargesUriBuilder>();
            uriBuilder.Setup(x => x.Build(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<int>()))
                .Returns(uri);

            var uriItemBuilder = new Mock<IChargeItemUriBuilder>();
            uriItemBuilder.Setup(x => x.Build(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(uri);


            _client = new CompaniesHouseCompanyChargesClient(new HttpClient(handler), uriBuilder.Object, uriItemBuilder.Object);

            _result = _client.GetCompanyChargesAsync("abc", 0, 25).Result;

            _result.Data.ShouldBeEquivalentTo(_companyCharges);
        }


        public static CompaniesHouseCompanyChargesClientTestCase[] TestCases()
        {
            return new CompaniesHouseCompanyChargesClientTestCase[0];
            //var allFilingCategories = EnumerationMappings.PossibleFilingCategories.Keys
            //    .Select(x => new CompaniesHouseCompanyChargesClientTestCase
            //    {
            //        ChargeNumber = x,
            //        ChargeCode= x,
            //        MoreThanFourPersonsEntitled = x,


            //    });

            //var allFilingSubcategories = EnumerationMappings.PossibleFilingSubcategories.Keys
            //    .Select(x => new CompaniesHouseCompanyFilingHistoryClientTestCase
            //    {
            //        Category = EnumerationMappings.PossibleFilingCategories.Keys.First(),
            //        Subcategory = x,
            //        HistoryStatus = EnumerationMappings.PossibleFilingHistoryStatus.Keys.First(),
            //        ResolutionCategory = EnumerationMappings.PossibleResolutionCategories.Keys.First()
            //    });

            //var allFilingHistoryStatus = EnumerationMappings.PossibleFilingHistoryStatus.Keys
            //    .Select(x => new CompaniesHouseCompanyFilingHistoryClientTestCase
            //    {
            //        Category = EnumerationMappings.PossibleFilingCategories.Keys.First(),
            //        Subcategory = EnumerationMappings.PossibleFilingSubcategories.Keys.First(),
            //        HistoryStatus = x,
            //        ResolutionCategory = EnumerationMappings.PossibleResolutionCategories.Keys.First()
            //    });

            //var allFilingResolutionCategories = EnumerationMappings.PossibleResolutionCategories.Keys
            //    .Select(x => new CompaniesHouseCompanyFilingHistoryClientTestCase
            //    {
            //        Category = EnumerationMappings.PossibleFilingCategories.Keys.First(),
            //        Subcategory = EnumerationMappings.PossibleFilingSubcategories.Keys.First(),
            //        HistoryStatus = EnumerationMappings.PossibleFilingHistoryStatus.Keys.First(),
            //        ResolutionCategory = x
            //    });

            //return allFilingCategories
            //        .Concat(allFilingSubcategories)
            //        .Concat(allFilingHistoryStatus)
            //        .Concat(allFilingResolutionCategories)
            //        .ToArray();
        }

    }
}
