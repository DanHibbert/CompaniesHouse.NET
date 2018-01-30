using System.Linq;
using CompaniesHouse.Tests.ResourceBuilders.CompanyChargesResource;
using Ploeh.AutoFixture;

namespace CompaniesHouse.Tests.CompaniesHouseCompanyChargesClientTests
{
    public class CompanyChargesBuilder
    {
        public CompanyCharges Build(CompaniesHouseCompanyChargesClientTestCase testCase)
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ChargeItem>(x => x.ResolvedOn));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ChargeItem>(x => x.SatisfiedOn));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ChargeItem>(x => x.AcquiredOn));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ChargeItem>(x => x.CoveringInstrumentDate));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ChargeItem>(x => x.CreatedOn));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<ChargeItem>(x => x.DeliveredOn));

            
            //fixture.Customizations.Add(new UniversalDateSpecimenBuilder<FilingHistoryItemAnnotation>(x => x.DateOfAnnotation));
            //fixture.Customizations.Add(new UniversalDateSpecimenBuilder<FilingHistoryItemAssociatedFiling>(x => x.Date));
            //fixture.Customizations.Add(new UniversalDateSpecimenBuilder<FilingHistoryItemResolution>(x => x.DateOfProcessing));

            var insolvencyCases = fixture.Build<InsolvencyCases>()
               .CreateMany().ToList();

            var personsEntitled = fixture.Build<PersonsEntitled>()
               .CreateMany().ToList();
            var transactions = fixture.Build<Transaction>()
               .CreateMany().ToList();

            //var resolutions = fixture.Build<FilingHistoryItemResolution>()
            //    .With(x => x.Category, testCase.ResolutionCategory)
            //    .With(x => x.Subcategory, testCase.Subcategory)
            //   .CreateMany().ToArray();

            var items = fixture.Build<ChargeItem>()
                .With(x => x.ChargeCode, testCase.ChargeCode)
                .With(x => x.ChargeNumber, testCase.ChargeNumber)
                .With(x => x.MoreThanFourPersonsEntitled, testCase.MoreThanFourPersonsEntitled)
                .With(x => x.InsolvencyCases, insolvencyCases)
                .With(x => x.PersonsEntitled, personsEntitled)
                .With(x => x.Transactions, transactions)
                .CreateMany().ToList();

            var filingHistory = fixture.Build<CompanyCharges>()
                //.With(x => x.HistoryStatus, testCase.HistoryStatus)
                .With(x => x.Items, items)
                .Create();

            return filingHistory;
        }
    }
}
