using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using the_100_api.Models;

namespace the_100_api.Endpoints
{
    /// <summary>
    /// The games endpoint for the100.io.
    /// </summary>
    public class Games
    {
        private readonly HttpClient _httpClient;

        public Games(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Gets games and their associated game activities currently supported on the100.io.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Game> GetGames()
        {
            return GetGamesAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets games and their associated game activities currently supported on the100.io.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Game>> GetGamesAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "games");
            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<Game>>(response);
        }
    }
}
