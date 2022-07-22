using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using USDASearchApp.API.Interfaces.USDAAPI;

namespace USDASearchApp.API.USDAApi
{
    internal class HttpClientWrapper : IHttpClientWrapper
    {
        private readonly HttpClient _httpClient;
        private readonly string _accessToken;

        public HttpClientWrapper(HttpClient httpclient)
        {
            _httpClient = httpclient;
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
