using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Corporate;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Legal;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Statements;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.SuperSecure;

namespace CompaniesHouse
{
    public interface ICompaniesHousePersonsWithSignificantControlClient
    {
        Task<CompaniesHouseClientResponse<CompanyPersonsWithSignificantControl>> GetPersonsWithSignificanControlAsync(string companyNumber, int startIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<PersonWithSignificantControlItem>> GetPersonsWithSignificanControlIndividualAsync(string companyNumber, string personWithSignificantControlId, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<StatementList>> GetPersonsWithSignificanControlStatementsAsync(string companyNumber, int startIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<StatementItem>> GetPersonsWithSignificanControlStatementItemAsync(string companyNumber, string statementId, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<SuperSecurePerson>> GetPersonsWithSignificanControlSuperSecurePersonAsync(string companyNumber, string superSecureId, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<CorporateEntity>> GetPersonsWithSignificanControlCorporateEntitiesAsync(string companyNumber, string personWithSignificantControlId, CancellationToken cancellationToken = default(CancellationToken));
        Task<CompaniesHouseClientResponse<LegalPerson>> GetPersonsWithSignificanControlLegalPersonAsync(string companyNumber, string personWithSignificantControlId, CancellationToken cancellationToken = default(CancellationToken));
    }
}