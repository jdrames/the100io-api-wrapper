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
    /// Represents The100.io Endpoint https://www.the100.io/v2/groups
    /// </summary>
    public class Groups
    {
        private readonly HttpClient _httpClient;
        
        public Groups(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Gets a group by Id.
        /// </summary>
        /// <param name="groupId">Id of group to retrieve.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public Group GetGroupById(int groupId)
        {
            return GetGroupByIdAsync(groupId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets a group by Id.
        /// </summary>
        /// <param name="groupId">Id of group to retrieve.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<Group> GetGroupByIdAsync(int groupId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"groups/{groupId}");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<Group>(response);
        }

        /// <summary>
        /// Gets a groups scheduled gaming sessions.
        /// </summary>
        /// <param name="groupId">Id of group to retrieve gaming sessions for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public IEnumerable<GamingSession> GetGamingSessions(int groupId)
        {
            return GetGamingSessionsAsync(groupId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets a groups scheduled gaming sessions.
        /// </summary>
        /// <param name="groupId">Id of group to retrieve gaming sessions for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<IEnumerable<GamingSession>> GetGamingSessionsAsync(int groupId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"groups/{groupId}/gaming_sessions");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<GamingSession>>(response);
        }

        /// <summary>
        /// Get the users for a group.
        /// </summary>
        /// <param name="groupId">Id of group to retrieve users for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public IEnumerable<User> GetUsers(int groupId)
        {
            return GetUsersAsync(groupId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously get the users for a group.
        /// </summary>
        /// <param name="groupId">Id of group to retrieve users for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<IEnumerable<User>> GetUsersAsync(int groupId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"groups/{groupId}/users");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<User>>(response);
        }

        /// <summary>
        /// Gets a list of all group tags available.
        /// <para>Not group specific.</para>
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public IEnumerable<string> GetAllTags()
        {
            return GetAllTagsAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets a list of all group tags available.
        /// <para>Not group specific.</para>
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<IEnumerable<string>> GetAllTagsAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"groups/all_tags");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<string>>(response);
        }

        /// <summary>
        /// Gets a list of approved games for a group.
        /// </summary>
        /// <param name="groupId">Id of group to retrieve approved games for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public IEnumerable<ApprovedGame> GetApprovedGames(int groupId)
        {
            return GetApprovedGamesAsync(groupId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets a list of approved games for a group.
        /// </summary>
        /// <param name="groupId">Id of group to retrieve approved games for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<IEnumerable<ApprovedGame>> GetApprovedGamesAsync(int groupId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"groups/{groupId}/approved_games");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<ApprovedGame>>(response);
        }

        /// <summary>
        /// Gets a list of the groups activity feed.
        /// </summary>
        /// <param name="groupId">Id of group to retrieve feed for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public IEnumerable<FeedItem> GetFeed(int groupId)
        {
            return GetFeedAsync(groupId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets a list of the groups activity feed.
        /// </summary>
        /// <param name="groupId">Id of group to retrieve feed for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<IEnumerable<FeedItem>> GetFeedAsync(int groupId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"groups/{groupId}/feed");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<FeedItem>>(response);
        }
    }
}
