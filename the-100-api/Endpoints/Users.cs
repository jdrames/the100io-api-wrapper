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
    /// Represents The100.io Endpoint https://www.the100.io/v2/users
    /// </summary>
    public class Users
    {
        private readonly HttpClient _httpClient;

        public Users(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Gets a list of tags available for users.
        /// </summary>        
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public IEnumerable<string> GetAllTags()
        {
            return GetAllTagsAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets a list of tags available for users.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<IEnumerable<string>> GetAllTagsAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "users/all_tags");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<string>>(response);
        }

        /// <summary>
        /// Get a user from the100.
        /// </summary>
        /// <param name="userId">Id of the user to retrieve.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public User GetUserById(int userId)
        {
            return GetUserByIdAsync(userId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously get a user from the100.
        /// </summary>
        /// <param name="userId">Id of the user to retrieve.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<User> GetUserByIdAsync(int userId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"users/{userId}");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<User>(response);
        }

        /// <summary>
        /// Gets a list of the users public created gaming sessions. 
        /// <para>This only returns the currently authenticated users data no matter what userId is used.</para>
        /// </summary>
        /// <param name="userId">Id of user to retrieve gaming sessions for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public IEnumerable<GamingSession> GetGamingSessions(int userId)
        {
            return GetGamingSessionsAsync(userId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets a list of the users public created gaming sessions. 
        /// <para>This only returns the currently authenticated users data no matter what userId is used.</para>
        /// </summary>
        /// <param name="userId">Id of user to retrieve gaming sessions for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<IEnumerable<GamingSession>> GetGamingSessionsAsync(int userId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"users/{userId}/gaming_sessions");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<GamingSession>>(response);
        }

        /// <summary>
        /// Gets a list of gaming sessions from groups this user belongs to.
        /// <para>This only returns the currently authenticated users data no matter what userId is used.</para>
        /// </summary>
        /// <param name="userId">Id of user to retrieve group gaming sessions.</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public IEnumerable<GamingSession> GetGroupGamingSessions(int userId, int page = 1)
        {
            if (page < 1)
                page = 1;

            return GetGroupGamingSessionsAsync(userId, page).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets a list of gaming sessions from groups this user belongs to.
        /// <para>This only returns the currently authenticated users data no matter what userId is used.</para>
        /// </summary>
        /// <param name="userId">Id of user to retrieve group gaming sessions.</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<IEnumerable<GamingSession>> GetGroupGamingSessionsAsync(int userId, int page = 1)
        {
            if (page < 1)
                page = 1;

            var request = new HttpRequestMessage(HttpMethod.Get, $"users/{userId}/group_gaming_sessions?page={page}");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<GamingSession>>(response);
        }

        /// <summary>
        /// Gets a list of the users recently completed gaming sessions.
        /// <para>This only returns the currently authenticated users data no matter what userId is used.</para>
        /// </summary>
        /// <param name="userId">Id of user to retrieve recent gaming sessions for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public IEnumerable<GamingSession> GetRecentGamingSessions(int userId)
        {
            return GetRecentGamingSessionsAsync(userId).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets a list of the users recently completed gaming sessions.
        /// <para>This only returns the currently authenticated users notifications no matter what userId is used.</para>
        /// </summary>
        /// <param name="userId">Id of user to retrieve recent gaming sessions for.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<IEnumerable<GamingSession>> GetRecentGamingSessionsAsync(int userId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"users/{userId}/recent_gaming_sessions");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<GamingSession>>(response);
        }

        /// <summary>
        /// Gets the users notifications.
        /// <para>This only returns the currently authenticated users notifications no matter what userId is used.</para>
        /// </summary>
        /// <param name="userId">Id of user to retrieve notifications for.</param>
        /// <param name="page">Page of notifications to retrieve. Pages start at 1.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public IEnumerable<Notification> GetNotifications(int userId, int page = 1)
        {
            if (page < 1)
                page = 1;

            return GetNotificationsAsync(userId, page).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets the users notifications.
        /// <para>This only returns the currently authenticated users notifications no matter what userId is used.</para>
        /// </summary>
        /// <param name="userId">Id of user to retrieve notifications for.</param>
        /// <param name="page">Page of notifications to retrieve. Pages start at 1.</param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<IEnumerable<Notification>> GetNotificationsAsync(int userId, int page = 1)
        {
            if (page < 1)
                page = 1;

            var request = new HttpRequestMessage(HttpMethod.Get, $"users/{userId}/notifications?page={page}");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<IEnumerable<Notification>>(response);
        }

        /// <summary>
        /// Gets the avatar urls for provided gamertags.
        /// </summary>
        /// <param name="gamerTags">A comma seperated list of gamer tags</param>
        /// <para>Eg: TipsWarlock,GrandMasterSlayer</para>
        /// <returns>{
        /// <para>"TipsWarlock":"https://avatarUrl.jpg",</para> 
        /// <para>"GrandMasterSlayer":"https://avatarUrl.jpg"</para>
        /// }</returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public object GetAvatarUrls(string gamerTags)
        {
            return GetAvatarUrlsAsync(gamerTags).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously gets the avatar urls for provided gamertags.
        /// </summary>
        /// <param name="gamerTags">A comma seperated list of gamer tags</param>
        /// <para>Eg: TipsWarlock,GrandMasterSlayer</para>
        /// <returns>{
        /// <para>"TipsWarlock":"https://avatarUrl.jpg",</para> 
        /// <para>"GrandMasterSlayer":"https://avatarUrl.jpg"</para>
        /// }</returns>
        /// <exception cref="Exceptions.ApiException"></exception>
        public async Task<object> GetAvatarUrlsAsync(string gamerTags)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"users/avatar_urls?gamertags={gamerTags}");
            var response = await _httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw The100API.CreateApiErrorMessage(response);

            return await The100API.Deserialize<object>(response);            
        }
    }
}
