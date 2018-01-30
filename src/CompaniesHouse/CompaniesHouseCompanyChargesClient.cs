using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Response.CompanyCharges;
using CompaniesHouse.UriBuilders;

namespace CompaniesHouse
{
    public class CompaniesHouseCompanyChargesClient : ICompaniesHouseCompanyChargesClient
    {
        private readonly HttpClient _httpClient;
        private readonly ICompanyChargesUriBuilder _companyChargesUriBuilder;
        private readonly IChargeItemUriBuilder _chargeItemUriBuilder;

        public CompaniesHouseCompanyChargesClient(HttpClient httpClient, ICompanyChargesUriBuilder companyChargesUriBuilder, IChargeItemUriBuilder chargeItemUriBuilder)
        {
            _httpClient = httpClient;
            _companyChargesUriBuilder = companyChargesUriBuilder;
            _chargeItemUriBuilder = chargeItemUriBuilder;
        }

        public async Task<CompaniesHouseClientResponse<CompanyCharges>> GetCompanyChargesAsync(string companyNumber, int startIndex, int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _companyChargesUriBuilder.Build(companyNumber, startIndex, pageSize);

            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            // Return a null profile on 404s, but raise exception for all other error codes
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                response.EnsureSuccessStatusCode();

            CompanyCharges result = response.IsSuccessStatusCode
                ? await response.Content.ReadAsJsonAsync<CompanyCharges>().ConfigureAwait(false)
                : null;

            return new CompaniesHouseClientResponse<CompanyCharges>(result);
        }

        public async Task<CompaniesHouseClientResponse<ChargeItem>> GetCompanyChargeItemAsync(string companyNumber, string chargeId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var requestUri = _chargeItemUriBuilder.Build(companyNumber, chargeId);

            var response = await _httpClient.GetAsync(requestUri, cancellationToken).ConfigureAwait(false);

            // Return a null profile on 404s, but raise exception for all other error codes
            if (response.StatusCode != System.Net.HttpStatusCode.NotFound)
                response.EnsureSuccessStatusCode();

            ChargeItem result = response.IsSuccessStatusCode
                ? await response.Content.ReadAsJsonAsync<ChargeItem>().ConfigureAwait(false)
                : null;

            return new CompaniesHouseClientResponse<ChargeItem>(result);
        }

    }
}