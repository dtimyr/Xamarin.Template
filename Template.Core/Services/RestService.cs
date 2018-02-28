using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Template.Core.Interfaces;

namespace Template.Core.Services
{
    public class RestService : IRestService
    {
        private readonly HttpClient _httpClient;
        
        private readonly TimeSpan _timeout = TimeSpan.FromSeconds(5);
        private readonly TimeSpan _longTimeout = TimeSpan.FromSeconds(30);
        
        
        public RestService()
        {
            _httpClient = new HttpClient();
        }

        
        public async Task<string> Get(string url, string content, CancellationToken cancellationToken)
        {
            _httpClient.Timeout = _timeout;

            using (var request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                request.Content = new StringContent(content, Encoding.UTF8, "application/json");

                var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead,
                    cancellationToken);

                return await response.Content.ReadAsStringAsync();
            }
        }
        
        public async Task<string> Post(string url, CancellationToken cancellationToken)
        {
            _httpClient.Timeout = _longTimeout;

            using (var request = new HttpRequestMessage(HttpMethod.Get, url))
            {
                var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseContentRead,
                    cancellationToken);

                return await response.Content.ReadAsStringAsync();
            }
        }

    }
}