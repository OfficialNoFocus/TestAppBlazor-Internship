using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestAppBlazor.Clients
{
    public class RestClient
    {
        private Uri _apiUrl;
        public RestClient()
        {
//#if DEBUG
            _apiUrl = new Uri("https://incidentenmelder-test-fa.azurewebsites.net");
//#else
//_apiUrl = new Uri("http://localhost:7071");
//#endif
        }

        public RestClient(string apiUrl)
        {
            _apiUrl = new Uri(apiUrl);
        }

        private HttpClient GetClient()
        {
            HttpClient c = new HttpClient();
            c.BaseAddress = _apiUrl;

            return c;
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            HttpClient c = GetClient();

            var response = await c.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public async Task<T> DeleteAsync<T>(string endpoint)
        {
            HttpClient c = GetClient();

            var response = await c.DeleteAsync(endpoint);
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public async Task<T> PostAsync<T>(string endpoint, HttpContent httpContent)
        {
            HttpClient c = GetClient();

            var response = await c.PostAsync(endpoint, httpContent);
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        public async Task<T> PutAsync<T>(string endpoint, HttpContent httpContent)
        {
            HttpClient c = GetClient();

            var response = await c.PutAsync(endpoint, httpContent);
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content);
        }

        //public async Task DeleteAsync(string endpoint)
        //{
        //    HttpClient c = GetClient();

        //    var response = await c.DeleteAsync(endpoint);
        //    response.EnsureSuccessStatusCode();
        //}


    }
}
