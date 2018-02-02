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


            var insolvencyCases = fixture.Build<InsolvencyCases>()
               .CreateMany(2).ToList();

            var personsEntitled = fixture.Build<PersonsEntitled>()
               .CreateMany(2).ToList();

            var transactions = fixture.Build<Transaction>()
                .With(x => x.FilingType, testCase.Filing)
               .CreateMany(2).ToList();

            var securedDetails = fixture.Build<SecuredDetails>()
                .With(x => x.Type, testCase.SecuredDetails)
               .Create();

            var link = fixture.Build<Links>()
               .Create();


            var classification = fixture.Build<Classification>()
                .With(x => x.ClassificationType, testCase.Classification)
                .Create();

            var particular = fixture.Build<Particulars>()
              .With(x => x.Type, testCase.Particulars)
              .Create();

            var items = fixture.Build<ChargeItem>()
                .With(x => x.StatusType, testCase.Status)
                .With(x => x.AssetsCeasedReleasedType, testCase.AssetsCeasedReleased)
                .With(x => x.InsolvencyCases, insolvencyCases)
                .With(x => x.PersonsEntitled, personsEntitled)
                .With(x => x.Transactions, transactions)
                .With(x => x.Classification, classification)
                .With(x => x.SecuredDetails, securedDetails)
                .With(x => x.Particulars, particular)
                .With(x => x.Links, link)
                .CreateMany(2).ToList();

            var companyCharges = fixture.Build<CompanyCharges>()
                .With(x => x.Items, items)
                .With(x => x.PartSatisfiedCount,items.Count)
                .With(x => x.SatisfiedCount,items.Count)
                .With(x => x.TotalCount, items.Count)
                .With(x => x.UnfilteredCount, items.Count)
                .Create();

            return companyCharges;
        }
    }
}
