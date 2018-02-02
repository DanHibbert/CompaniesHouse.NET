using System;
using System.Linq;
using System.Net.Http;
using CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource;
using CompaniesHouse.UriBuilders;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace CompaniesHouse.Tests.CompaniesHouseCompanyChargesClientTests
{
    [TestFixture]
    public class CompaniesHouseCompanyChargesClientTests
    {
        private CompaniesHouseCompanyChargesClient _client;

        private CompaniesHouseClientResponse<Response.CompanyCharges.CompanyCharges> _result;
        private CompanyCharges _companyCharges;

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

            _result.Data.ShouldBeEquivalentTo(_companyCharges, options => options.ComparingEnumsByName());
        }


        public static CompaniesHouseCompanyChargesClientTestCase[] TestCases()
        {
            var allAssetsCeasedReleasedTypes = EnumerationMappings.PossibleAssetsCeasedReleasedType.Keys
                .Select(x => new CompaniesHouseCompanyChargesClientTestCase
                {
                    Status = EnumerationMappings.PossibleStatusType.Keys.First(),
                    Filing = EnumerationMappings.PossibleFilingType.Keys.First(),
                    Classification = EnumerationMappings.PossibleClassificationType.Keys.First(),
                    Particulars = EnumerationMappings.PossibleParticularsType.Keys.First(),
                    SecuredDetails = EnumerationMappings.PossibleSecuredDetailsType.Keys.First(),
                    AssetsCeasedReleased = x
                });


            var allStatusTypes = EnumerationMappings.PossibleStatusType.Keys
              .Select(x => new CompaniesHouseCompanyChargesClientTestCase
              {
                  Status = x,
                  Filing = EnumerationMappings.PossibleFilingType.Keys.First(),
                  Classification = EnumerationMappings.PossibleClassificationType.Keys.First(),
                  Particulars = EnumerationMappings.PossibleParticularsType.Keys.First(),
                  SecuredDetails = EnumerationMappings.PossibleSecuredDetailsType.Keys.First(),
                  AssetsCeasedReleased = EnumerationMappings.PossibleAssetsCeasedReleasedType.Keys.First()
              });
            var allFilingTypes = EnumerationMappings.PossibleFilingType.Keys
            .Select(x => new CompaniesHouseCompanyChargesClientTestCase
            {
                Status = EnumerationMappings.PossibleStatusType.Keys.First(),
                Filing = x,
                Classification = EnumerationMappings.PossibleClassificationType.Keys.First(),
                Particulars = EnumerationMappings.PossibleParticularsType.Keys.First(),
                SecuredDetails = EnumerationMappings.PossibleSecuredDetailsType.Keys.First(),
                AssetsCeasedReleased = EnumerationMappings.PossibleAssetsCeasedReleasedType.Keys.First()
            });

            var allClassificationTypes = EnumerationMappings.PossibleClassificationType.Keys
          .Select(x => new CompaniesHouseCompanyChargesClientTestCase
          {
              Status = EnumerationMappings.PossibleStatusType.Keys.First(),
              Filing = x,
              Classification = x,
              Particulars = EnumerationMappings.PossibleParticularsType.Keys.First(),
              SecuredDetails = EnumerationMappings.PossibleSecuredDetailsType.Keys.First(),
              AssetsCeasedReleased = EnumerationMappings.PossibleAssetsCeasedReleasedType.Keys.First()
          });
            var allParticulars = EnumerationMappings.PossibleParticularsType.Keys
         .Select(x => new CompaniesHouseCompanyChargesClientTestCase
         {
             Status = EnumerationMappings.PossibleStatusType.Keys.First(),
             Filing = EnumerationMappings.PossibleFilingType.Keys.First(),
             Classification = EnumerationMappings.PossibleClassificationType.Keys.First(),
             Particulars = x,
             SecuredDetails = EnumerationMappings.PossibleSecuredDetailsType.Keys.First(),
             AssetsCeasedReleased = EnumerationMappings.PossibleAssetsCeasedReleasedType.Keys.First()
         });

            var allSecuredDetailsTypes = EnumerationMappings.PossibleSecuredDetailsType.Keys
       .Select(x => new CompaniesHouseCompanyChargesClientTestCase
       {
           Status = EnumerationMappings.PossibleStatusType.Keys.First(),
           Filing = EnumerationMappings.PossibleFilingType.Keys.First(),
           Classification = EnumerationMappings.PossibleClassificationType.Keys.First(),
           Particulars = EnumerationMappings.PossibleParticularsType.Keys.First(),
           SecuredDetails = x,
           AssetsCeasedReleased = EnumerationMappings.PossibleAssetsCeasedReleasedType.Keys.First()
       });

            var allTestCases = allAssetsCeasedReleasedTypes
                    .Concat(allStatusTypes)
                    .Concat(allFilingTypes)
                    .Concat(allClassificationTypes)
                    .Concat(allParticulars)
                    .Concat(allSecuredDetailsTypes)
                    .ToArray();

            return allTestCases.Take(1).ToArray(); 
        }

    }
}
