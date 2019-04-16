using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ModTool.WebClient.Helpers
{
    public class HttpRequestHelper
    {
        private readonly HttpClient _httpClient;
        public HttpRequestHelper()
        {
            _httpClient = new HttpClient();
        }

        public async Task<T> Get<T>(string uri)
        {
            try
            {
                //TODO:update urls to web config keys
                uri = "https://localhost:5001/" + uri;
                var response = await _httpClient.GetAsync(uri);
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public async Task<T> Post<T, X>(string uri, X body)
        {
            try
            {
                uri = "https://localhost:5001/" + uri;
                var response = await _httpClient.PostAsync(uri, body, new JsonMediaTypeFormatter());
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public async Task PostNoReturn<T>(string uri, T body)
        {
            try
            {
                uri = "https://localhost:5001/" + uri;
                await _httpClient.PostAsync(uri, body, new JsonMediaTypeFormatter());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public async Task Delete(string uri)
        {
            try
            {
                uri = "http://localhost:57198/" + uri;
                await _httpClient.DeleteAsync(uri);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
