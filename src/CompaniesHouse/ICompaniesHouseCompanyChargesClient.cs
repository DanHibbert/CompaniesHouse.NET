using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Response.CompanyCharges;

namespace CompaniesHouse
{
    public interface ICompaniesHouseCompanyChargesClient
    {
        Task<CompaniesHouseClientResponse<CompanyCharges>> GetCompanyChargesAsync(string companyNumber, int startIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken));

        Task<CompaniesHouseClientResponse<ChargeItem>> GetCompanyChargeItemAsync(string companyNumber, string chargeId, CancellationToken cancellationToken = default(CancellationToken));

    }
}