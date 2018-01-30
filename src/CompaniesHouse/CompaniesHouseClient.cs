using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Request;
using CompaniesHouse.Response.CompanyCharges;
using CompaniesHouse.Response.CompanyFiling;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Corporate;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Legal;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Statements;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.SuperSecure;
using CompaniesHouse.Response.CompanyProfile;
using CompaniesHouse.Response.Insolvency;
using CompaniesHouse.Response.Officers;
using CompaniesHouse.Response.Search.AllSearch;
using CompaniesHouse.Response.Search.CompanySearch;
using CompaniesHouse.Response.Search.DisqualifiedOfficersSearch;
using CompaniesHouse.Response.Search.OfficerSearch;
using CompaniesHouse.UriBuilders;

namespace CompaniesHouse
{
    public class CompaniesHouseClient : ICompaniesHouseClient, IDisposable
    {
        private readonly ICompaniesHouseSearchClient _companiesHouseSearchClient;
        private readonly ICompaniesHouseCompanyProfileClient _companiesHouseCompanyProfileClient;
        private readonly ICompaniesHouseCompanyFilingHistoryClient _companiesHouseCompanyFilingHistoryClient;
        private readonly ICompaniesHouseOfficersClient _companiesHouseOfficersClient;
        private readonly ICompaniesHouseCompanyInsolvencyInformationClient _companiesHouseCompanyInsolvencyInformationClient;
        private readonly HttpClient _httpClient;
        private CompaniesHousePersonsWithSignificantControlClient _companiesHousePersonsWithSignificantControlClient;
        private CompaniesHouseCompanyChargesClient _companiesHouseCompanyChargesClient;

        public CompaniesHouseClient(ICompaniesHouseSettings settings)
        {
            var httpClientFactory = new HttpClientFactory(settings);
            _httpClient = httpClientFactory.CreateHttpClient();

            _companiesHouseSearchClient = new CompaniesHouseSearchClient(_httpClient, new SearchUriBuilderFactory());
            _companiesHouseCompanyProfileClient = new CompaniesHouseCompanyProfileClient(_httpClient, new CompanyProfileUriBuilder());
            _companiesHouseCompanyFilingHistoryClient = new CompaniesHouseCompanyFilingHistoryClient(_httpClient, new CompanyFilingHistoryUriBuilder(), new FilingHistoryItemUriBuilder());
            _companiesHouseOfficersClient = new CompaniesHouseOfficersClient(_httpClient, new OfficersUriBuilder());
            _companiesHouseCompanyInsolvencyInformationClient = new CompaniesHouseCompanyInsolvencyInformationClient(_httpClient);
            _companiesHousePersonsWithSignificantControlClient = new CompaniesHousePersonsWithSignificantControlClient(_httpClient, 
                new PersonsWithSignificantControlUriBuilder(), new PersonsWithSignificantControlIndividualUriBuilder(),new PersonsWithSignificantControlStatementsUriBuilder(), new PersonsWithSignificantControlStatementItemUriBuilder(), new PersonsWithSignificantControlSuperSecurePersonUriBuilder(), new PersonsWithSignificantControlUriCorporateEntitiesBuilder(), new PersonsWithSignificantControlUriLegalPersonBuilder());
            _companiesHouseCompanyChargesClient = new CompaniesHouseCompanyChargesClient(_httpClient,new CompanyChargesUriBuilder(), new ChargeItemUriBuilder());
        }

        public Task<CompaniesHouseClientResponse<CompanySearch>> SearchCompanyAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _companiesHouseSearchClient.SearchAsync<CompanySearch>(request, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<OfficerSearch>> SearchOfficerAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _companiesHouseSearchClient.SearchAsync<OfficerSearch>(request, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<DisqualifiedOfficerSearch>> SearchDisqualifiedOfficerAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _companiesHouseSearchClient.SearchAsync<DisqualifiedOfficerSearch>(request, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<AllSearch>> SearchAllAsync(SearchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _companiesHouseSearchClient.SearchAsync<AllSearch>(request, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<CompanyProfile>> GetCompanyProfileAsync(string companyNumber, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _companiesHouseCompanyProfileClient.GetCompanyProfileAsync(companyNumber, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<CompanyFilingHistory>> GetCompanyFilingHistoryAsync(string companyNumber, int startIndex = 0, int pageSize = 25, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _companiesHouseCompanyFilingHistoryClient.GetCompanyFilingHistoryAsync(companyNumber, startIndex, pageSize, cancellationToken);
        }
        public Task<CompaniesHouseClientResponse<FilingHistoryItem>> GetCompanyFilingHistoryItemAsync(string companyNumber, string transactionId,
          CancellationToken cancellationToken = new CancellationToken())
        {
            return _companiesHouseCompanyFilingHistoryClient.GetCompanyFilingHistoryItemAsync(companyNumber, transactionId, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<Officers>> GetOfficersAsync(string companyNumber, int startIndex = 0, int pageSize = 25, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _companiesHouseOfficersClient.GetOfficersAsync(companyNumber, startIndex, pageSize, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<CompanyInsolvencyInformation>> GetCompanyInsolvencyInformationAsync(string companyNumber, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _companiesHouseCompanyInsolvencyInformationClient.GetCompanyInsolvencyInformationAsync(companyNumber, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<CompanyPersonsWithSignificantControl>> GetPersonsWithSignificanControlAsync(string companyNumber, int startIndex =0, int pageSize = 25,CancellationToken cancellationToken = new CancellationToken())
        {
            return _companiesHousePersonsWithSignificantControlClient.GetPersonsWithSignificanControlAsync(companyNumber, startIndex, pageSize, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<PersonWithSignificantControlItem>> GetPersonsWithSignificanControlIndividualAsync(string companyNumber, string personWithSignificantControlId,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return _companiesHousePersonsWithSignificantControlClient.GetPersonsWithSignificanControlIndividualAsync(companyNumber, personWithSignificantControlId, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<StatementList>> GetPersonsWithSignificanControlStatementsAsync(string companyNumber, int startIndex =0, int pageSize = 25,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return _companiesHousePersonsWithSignificantControlClient.GetPersonsWithSignificanControlStatementsAsync(companyNumber, startIndex, pageSize, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<StatementItem>> GetPersonsWithSignificanControlStatementItemAsync(string companyNumber, string statementId,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return _companiesHousePersonsWithSignificantControlClient.GetPersonsWithSignificanControlStatementItemAsync(companyNumber, statementId, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<SuperSecurePerson>> GetPersonsWithSignificanControlSuperSecurePersonAsync(string companyNumber, string superSecureId,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return _companiesHousePersonsWithSignificantControlClient.GetPersonsWithSignificanControlSuperSecurePersonAsync(companyNumber, superSecureId, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<CorporateEntity>> GetPersonsWithSignificanControlCorporateEntitiesAsync(string companyNumber, string personWithSignificantControlId,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return _companiesHousePersonsWithSignificantControlClient.GetPersonsWithSignificanControlCorporateEntitiesAsync(companyNumber, personWithSignificantControlId, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<LegalPerson>> GetPersonsWithSignificanControlLegalPersonAsync(string companyNumber, string personWithSignificantControlId,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return _companiesHousePersonsWithSignificantControlClient.GetPersonsWithSignificanControlLegalPersonAsync(companyNumber, personWithSignificantControlId, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<CompanyCharges>> GetCompanyChargesAsync(string companyNumber, int startIndex =0, int pageSize = 25,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return _companiesHouseCompanyChargesClient.GetCompanyChargesAsync(companyNumber, startIndex, pageSize, cancellationToken);
        }

        public Task<CompaniesHouseClientResponse<ChargeItem>> GetCompanyChargeItemAsync(string companyNumber, string chargeId,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return _companiesHouseCompanyChargesClient.GetCompanyChargeItemAsync(companyNumber, chargeId, cancellationToken);
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }

    }
}
