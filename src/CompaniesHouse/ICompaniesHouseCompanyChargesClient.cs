using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Response.CompanyCharges;

namespace CompaniesHouse
{
    public interface ICompaniesHouseCompanyChargesClient
    {
        Task<CompaniesHouseClientResponse<CompanyCharges>> GetCompanyChargesAsync(string companyNumber, int startIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken));

        Task<CompaniesHouseClientResponse<ChargeItem>> GetChargeItemAsync(string companyNumber, string chargeId, CancellationToken cancellationToken = default(CancellationToken));

    }
}