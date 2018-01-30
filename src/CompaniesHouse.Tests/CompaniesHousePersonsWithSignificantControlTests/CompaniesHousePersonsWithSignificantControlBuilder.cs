using System.Linq;
using CompaniesHouse.Tests.ResourceBuilders;
using CompaniesHouse.Tests.ResourceBuilders.CompanyPersonsWithSignificantControlResource;
using Ploeh.AutoFixture;

namespace CompaniesHouse.Tests.CompaniesHousePersonsWithSignificantControlTests
{
    public class CompaniesHousePersonsWithSignificantControlBuilder
    {
        public CompaniesHousePersonsWithSignificantControlClient Build()
        {
            var fixture = new Fixture();
            //fixture.Customizations.Add(new UniversalDateSpecimenBuilder<PersonWithSignificantControlItem>(x => x.));
            //fixture.Customizations.Add(new UniversalDateSpecimenBuilder<PersonWithSignificantControlItem>(x => x.ResignedOn));

            var officers = EnumerationMappings.PossibleOfficerRoles.Keys.Select(x => fixture.Build<Officer>()
               .With(y => y.OfficerRole, x)
               .Create()).ToArray();

            var officerSummary = fixture.Build<Officers>().With(x => x.Items, officers).Create();

            var result = fixture.Build<Officers>()
                .With(x => x.Items, officerSummary.Items)
                .With(x => x.ActiveCount, officerSummary.ActiveCount)
                .With(x => x.ResignedCount, officerSummary.ResignedCount)
                .Create();

            return result;
        }
    }
}
