using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Corporate;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Legal;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.Statements;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl.SuperSecure;
using CompaniesHouse.UriBuilders;

namespace CompaniesHouse
{
    public class CompaniesHousePersonsWithSignificantControlClient : ICompaniesHousePersonsWithSignificantControlClient
    {
        private readonly HttpClient _httpClient;
        private readonly IPersonsWithSignificantControlUriBuilder _personsWithSignificanControlUriBuilder;
        private readonly IPersonsWithSignificantControlIndividualUriBuilder _personsWithSignificantControlIndividualUriBuilder;
        private readonly IPersonsWithSignificantControlStatementsUriBuilder _personsWithSignificantControlStatementsUriBuilder;
        private readonly IPersonsWithSignificantControlStatementItemUriBuilder _personsWithSignificantControlStatementItemUriBuilder;
        private readonly IPersonsWithSignificantControlSuperSecurePersonUriBuilder _personsWithSignificantControlSuperSecurePersonUriBuilder;
        private readonly IPersonsWithSignificantControlUriCorporateEntitiesBuilder _personsWithSignificantControlUriCorporateEntitiesBuilder;
        private readonly IPersonsWithSignificantControlUriLegalPersonBuilder _personsWithSignificantControlUriLegalPersonBuilder;

        public CompaniesHousePersonsWithSignificantControlClient(HttpClient httpClient, IPersonsWithSignificantControlUriBuilder personsWithSignificanControlUriBuilder,
           IPersonsWithSignificantControlIndividualUriBuilder personsWithSignificantControlIndividualUriBuilder,
           IPersonsWithSignificantControlStatementsUriBuilder personsWithSignificantControlStatementsUriBuilder,
           IPersonsWithSignificantControlStatementItemUriBuilder personsWithSignificantControlStatementItemUriBuilder,
           IPersonsWithSignificantControlSuperSecurePersonUriBuilder personsWithSignificantControlSuperSecureUriBuilder,
           IPersonsWithSignificantControlUriCorporateEntitiesBuilder personsWithSignificantControlUriCorporateEntitiesBuilder,
           IPersonsWithSignificantControlUriLegalPersonBuilder personsWithSignificantControlUriLegalPersonBuilder


           )
        {
            _httpClient = httpClient;
            _personsWithSignificanControlUriBuilder = personsWithSignificanControlUriBuilder;
            _personsWithSignificantControlIndividualUriBuilder = personsWithSignificantControlIndividualUriBuilder;
            _personsWithSignificantControlStatementsUriBuilder = personsWithSignificantControlStatementsUriBuilder;
            _personsWithSignificantControlStatementItemUriBuilder = personsWithSignificantControlStatementItemUriBuilder;
            _personsWithSignificantControlSuperSecurePersonUriBuilder = personsWithSignificantControlSuperSecureUriBuilder;
            _personsWithSignificantControlUriCorporateEntitiesBuilder = personsWithSignificantControlUriCorporateEntitiesBuilder;
            _personsWithSignificantControlUriLegalPersonBuilder = personsWithSignificantControlUriLegalPersonBuilder;
        }

        public async Task<CompaniesHouseClientResponse<CompanyPersonsWithSignificantControl>> GetPersonsWithSignificanControlAsync(string companyNumber, int startIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _personsWithSignificanControlUriBuilder.Build(companyNumber, startIndex, pageSize);

            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            // Return a null profile on 404s, but raise exception for all other error codes
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                response.EnsureSuccessStatusCode();

            var result = response.IsSuccessStatusCode
                ? await response.Content.ReadAsJsonAsync<CompanyPersonsWithSignificantControl>().ConfigureAwait(false)
                : null;

            return new CompaniesHouseClientResponse<CompanyPersonsWithSignificantControl>(result);
        }

        public async Task<CompaniesHouseClientResponse<PersonWithSignificantControlItem>> GetPersonsWithSignificanControlIndividualAsync(string companyNumber, string personWithSignificantControlId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _personsWithSignificantControlIndividualUriBuilder.Build(companyNumber, personWithSignificantControlId);

            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            // Return a null profile on 404s, but raise exception for all other error codes
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                response.EnsureSuccessStatusCode();

            var result = response.IsSuccessStatusCode
                ? await response.Content.ReadAsJsonAsync<PersonWithSignificantControlItem>().ConfigureAwait(false)
                : null;

            return new CompaniesHouseClientResponse<PersonWithSignificantControlItem>(result);
        }

        public async Task<CompaniesHouseClientResponse<StatementList>> GetPersonsWithSignificanControlStatementsAsync(string companyNumber, int startIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _personsWithSignificantControlStatementsUriBuilder.Build(companyNumber, startIndex,pageSize);

            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            // Return a null profile on 404s, but raise exception for all other error codes
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                response.EnsureSuccessStatusCode();

            var result = response.IsSuccessStatusCode
                ? await response.Content.ReadAsJsonAsync<StatementList>().ConfigureAwait(false)
                : null;

            return new CompaniesHouseClientResponse<StatementList>(result);
        }


        public async Task<CompaniesHouseClientResponse<StatementItem>> GetPersonsWithSignificanControlStatementItemAsync(string companyNumber, string statementId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _personsWithSignificantControlStatementItemUriBuilder.Build(companyNumber, statementId);

            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            // Return a null profile on 404s, but raise exception for all other error codes
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                response.EnsureSuccessStatusCode();

            var result = response.IsSuccessStatusCode
                ? await response.Content.ReadAsJsonAsync<StatementItem>().ConfigureAwait(false)
                : null;

            return new CompaniesHouseClientResponse<StatementItem>(result);
        }

        public async Task<CompaniesHouseClientResponse<SuperSecurePerson>> GetPersonsWithSignificanControlSuperSecurePersonAsync(string companyNumber, string superSecureId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _personsWithSignificantControlSuperSecurePersonUriBuilder.Build(companyNumber, superSecureId);

            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            // Return a null profile on 404s, but raise exception for all other error codes
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                response.EnsureSuccessStatusCode();

            var result = response.IsSuccessStatusCode
                ? await response.Content.ReadAsJsonAsync<SuperSecurePerson>().ConfigureAwait(false)
                : null;

            return new CompaniesHouseClientResponse<SuperSecurePerson>(result);
        }

        public async Task<CompaniesHouseClientResponse<CorporateEntity>> GetPersonsWithSignificanControlCorporateEntitiesAsync(string companyNumber, string personWithSignificantControlId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _personsWithSignificantControlUriCorporateEntitiesBuilder.Build(companyNumber, personWithSignificantControlId);

            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            // Return a null profile on 404s, but raise exception for all other error codes
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                response.EnsureSuccessStatusCode();

            var result = response.IsSuccessStatusCode
                ? await response.Content.ReadAsJsonAsync<CorporateEntity>().ConfigureAwait(false)
                : null;

            return new CompaniesHouseClientResponse<CorporateEntity>(result);
        }

        public async Task<CompaniesHouseClientResponse<LegalPerson>> GetPersonsWithSignificanControlLegalPersonAsync(string companyNumber, string personWithSignificantControlId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _personsWithSignificantControlUriLegalPersonBuilder.Build(companyNumber, personWithSignificantControlId);

            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            // Return a null profile on 404s, but raise exception for all other error codes
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                response.EnsureSuccessStatusCode();

            var result = response.IsSuccessStatusCode
                ? await response.Content.ReadAsJsonAsync<LegalPerson>().ConfigureAwait(false)
                : null;

            return new CompaniesHouseClientResponse<LegalPerson>(result);
        }

    }

    
}