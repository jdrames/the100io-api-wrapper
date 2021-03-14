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
    /// Represents The100.io Endpoint https://www.the100.io/v2/gaming_sessions
    /// </summary>
    public class GamingSessions : IGamingSessions
    {
        private readonly HttpClient _httpClient;

        public GamingSessions(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IEnumerable<GamingSession> GetAll(int page)
        {
            return GetAllAsync(page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<GamingSession>> GetAllAsync(int page)
        {
            if (page < 1)
                page = 1;
            return await The100API.SendGetRequest<IEnumerable<GamingSession>>(_httpClient, $"gaming_sessions?page={page}");
        }

        public GamingSession GetById(int id)
        {
            return GetByIdAsync(id).GetAwaiter().GetResult();
        }

        public async Task<GamingSession> GetByIdAsync(int id)
        {
            return await The100API.SendGetRequest<GamingSession>(_httpClient, $"gaming_sessions/{id}");
        }
    }
}
