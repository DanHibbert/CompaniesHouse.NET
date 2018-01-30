using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;
using CompaniesHouse.Response.Officers;

namespace CompaniesHouse
{
    public interface ICompaniesHousePersonsWithSignificantControlClient
    {
        Task<CompaniesHouseClientResponse<CompanyPersonsWithSignificantControl>> GetPersonsWithSignificanControlAsync(string companyNumber, int startIndex = 0, int pageSize = 25, CancellationToken cancellationToken = default(CancellationToken));
    }
}

