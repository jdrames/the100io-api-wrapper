using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using the_100_api.Interfaces;
using the_100_api.Models;

namespace the_100_api.Endpoints
{
    /// <summary>
    /// The games endpoint for the100.io.
    /// </summary>
    public class Games : IGames
    {
        private readonly HttpClient _httpClient;

        public Games(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IEnumerable<Game> GetAll()
        {
            return GetAllAsync().GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<Game>> GetAllAsync()
        {
            return await The100API.SendGetRequest<IEnumerable<Game>>(_httpClient, "games");
        }
    }
}
