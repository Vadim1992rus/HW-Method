using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Trainie
{
    public class MyHttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public MyHttpClient(string baseUrl)
        {
            _httpClient = new HttpClient();
            _baseUrl = baseUrl;
        }

        public async Task<string> GetAsync(string endpoint)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/{endpoint}");
            response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();
            return stringResponse;
        }

        public async Task<string> PostAsync(string endpoint, HttpContent content)
        {
            var response = await _httpClient.PostAsync($"{_baseUrl}/{endpoint}", content);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
