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
    /// Represents The100.io Endpoint https://www.the100.io/v2/gaming_sessions
    /// </summary>
    public class GamingSessions
    {
        private readonly HttpClient _httpClient;

        public GamingSessions(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        /// <summary>
        /// Gets gaming sessions.
        /// </summary>
        /// <param name="page">Page of gaming sessions to retrieve. Paging starts at 1.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public IEnumerable<GamingSession> GetGamingSessions(int page = 1)
        {
            if (page < 1)
                page = 1;
            return GetGamingSessionsAsync(page).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets gaming sessions.
        /// </summary>
        /// <param name="page">Page of gaming sessions to retrieve. Paging starts at 1.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<IEnumerable<GamingSession>> GetGamingSessionsAsync(int page = 1)
        {
            if (page < 1)
                page = 1;
            var request = new HttpRequestMessage(HttpMethod.Get, $"gaming_sessions?page={page}");
            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<GamingSession>>(response);
        }

        /// <summary>
        /// Get a gaming session by Id.
        /// </summary>
        /// <param name="sessionId">Id of gaming session to retrieve.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public GamingSession GetGamingSessionById(int sessionId)
        {
            return GetGamingSessionByIdAsync(sessionId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously get a gaming session by Id.
        /// </summary>
        /// <param name="sessionId">Id of gaming session to retrieve.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<GamingSession> GetGamingSessionByIdAsync(int sessionId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"gaming_sessions/{sessionId}");
            var response = await _httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<GamingSession>(response);
        }
    }
}
