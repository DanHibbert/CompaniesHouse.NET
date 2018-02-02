using System.Linq;
using CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControl;
using Ploeh.AutoFixture;

namespace CompaniesHouse.Tests.CompaniesHousePersonsWithSignificantControlTests
{
    public class CompaniesHousePersonsWithSignificantControlBuilder
    {
        public CompanyPersonsWithSignificantControl Build()
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<PersonWithSignificantControlItem>(x => x.CeasedOn));
            fixture.Customizations.Add(new UniversalDateSpecimenBuilder<PersonWithSignificantControlItem>(x => x.NotifiedOn));

            var pscList = fixture.Build<PersonWithSignificantControlItem>().CreateMany().ToList();

            //var officers = EnumerationMappings.PossibleOfficerRoles.Keys.Select(x => fixture.Build<PersonWithSignificantControlItem>()
            //   .With(y => y., x)
            //   .Create()).ToArray();

            //var officerSummary = fixture.Build<Officers>().With(x => x.Items, officers).Create();

            var result = fixture.Build<CompanyPersonsWithSignificantControl>()
                .With(x => x.Items, pscList)
                .Create();

            return result;
        }
    }
}
