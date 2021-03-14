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
    /// Represents The100.io Endpoint https://www.the100.io/v2/groups
    /// </summary>
    public class Groups : IGroups
    {
        private readonly HttpClient _httpClient;
        
        public Groups(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IEnumerable<string> GetAllTags()
        {
            return GetAllTagsAsync().GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<string>> GetAllTagsAsync()
        {
            return await The100API.SendGetRequest<IEnumerable<string>>(_httpClient, "groups");
        }

        public IEnumerable<ApprovedGame> GetApprovedGames(int id)
        {
            return GetApprovedGamesAsync(id).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<ApprovedGame>> GetApprovedGamesAsync(int id)
        {
            return await The100API.SendGetRequest<IEnumerable<ApprovedGame>>(_httpClient, $"groups/{id}/approved_games");
        }

        public Group GetById(int id)
        {
            return GetByIdAsync(id).GetAwaiter().GetResult();
        }

        public async Task<Group> GetByIdAsync(int id)
        {
            return await The100API.SendGetRequest<Group>(_httpClient, $"groups/{id}");
        }

        public IEnumerable<FeedItem> GetFeed(int id)
        {
            return GetFeedAsync(id).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<FeedItem>> GetFeedAsync(int id)
        {
            return await The100API.SendGetRequest<IEnumerable<FeedItem>>(_httpClient, $"groups/{id}/feed");
        }

        public IEnumerable<GamingSession> GetGamingSessions(int id, int page)
        {
            return GetGamingSessionsAsync(id, page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<GamingSession>> GetGamingSessionsAsync(int id, int page = 1)
        {
            if (page < 1)
                page = 1;

            return await The100API.SendGetRequest<IEnumerable<GamingSession>>(_httpClient, $"groups/{id}/gaming_sessions?page={page}");
        }

        public IEnumerable<PlatformMembership> GetPlatformMemberships(int id)
        {
            return GetPlatformMembershipsAsync(id).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<PlatformMembership>> GetPlatformMembershipsAsync(int id)
        {
            return await The100API.SendGetRequest<IEnumerable<PlatformMembership>>(_httpClient, $"groups/{id}/platform_memberships");
        }

        public IEnumerable<User> GetUsers(int id, int page)
        {
            return GetUsersAsync(id, page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<User>> GetUsersAsync(int id, int page)
        {
            if (page < 1)
                page = 1;
            return await The100API.SendGetRequest<IEnumerable<User>>(_httpClient, $"groups/{id}/users?page={page}");
        }
    }
}
