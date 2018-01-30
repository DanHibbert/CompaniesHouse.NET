using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Response.CompanyPersonsWithSignificantControl;
using CompaniesHouse.UriBuilders;

namespace CompaniesHouse
{
    public class CompaniesHousePersonsWithSignificantControlClient : ICompaniesHousePersonsWithSignificantControlClient
    {
        private readonly HttpClient _httpClient;
        private readonly IPersonsWithSignificantControlUriBuilder _personsWithSignificanControlUriBuilder;

        public CompaniesHousePersonsWithSignificantControlClient(HttpClient httpClient, IPersonsWithSignificantControlUriBuilder personsWithSignificanControlUriBuilder)
        {
            _httpClient = httpClient;
            _personsWithSignificanControlUriBuilder = personsWithSignificanControlUriBuilder;
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
    }
}