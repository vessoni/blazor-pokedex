using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using Pokedex.Api.Responses;

namespace Pokedex.Api
{
    public class PokeApi
    {
        private readonly HttpClient _apiClient;

        public PokeApi()
        {
            _apiClient = new HttpClient
            {
                BaseAddress = new Uri(Endpoint.BaseUrl)
            };
        }

        public async Task<Pokemon> Get<TResult>(string endpoint) where TResult : class
        {
            var res = await _apiClient.GetAsync(endpoint);
            var body = await res.Content.ReadAsStringAsync();

           
            return JsonConvert.DeserializeObject<Pokemon>(body);

            
        }
    }
}