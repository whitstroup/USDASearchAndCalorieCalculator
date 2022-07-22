using System;
using System.Net.Http;
using System.Threading.Tasks;
using USDASearchApp.API.Interfaces;

namespace USDASearchApp.API
{
    public class HttpClientWrapper : IHttpClientWrapper, IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly string _accessToken;

        public HttpClientWrapper(IHttpClientFactory clientFactory)
        {
            _httpClient = clientFactory.CreateClient();
        }
        public void Dispose()
        {
            //resources from the HttpClient are tracked and managed by the HttpClientFactory.
        }

        public async Task<string> GetAsync(string url)
        {

            using (var request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                // request.Headers.Authorization = new AuthenticationHeaderValue("api_key", );

                var response = await _httpClient.SendAsync(request);

                string apiResponse = await response.Content.ReadAsStringAsync();

                return apiResponse;
            }
        }

        public async Task<string> PostAsync(string url)
        {
            throw new NotImplementedException();
        }
    }
}
