using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using the_100_api.Interfaces;
using the_100_api.Models;

namespace the_100_api.Endpoints
{
    public class UsersExtended : Users, IUsers, IUserExtended
    {
        private readonly HttpClient _httpClient;

        public UsersExtended(HttpClient httpClient): base(httpClient)
        {
            _httpClient = httpClient;
        }

        public IEnumerable<ApprovedGame> GetApprovedGames(int id)
        {
            return GetApprovedGamesAsync(id).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<ApprovedGame>> GetApprovedGamesAsync(int id)
        {
            return await The100API.SendGetRequest<IEnumerable<ApprovedGame>>(_httpClient, $"users/{id}/approved_games");
        }       

        public IEnumerable<User> GetBlockedUsers(int id, int page)
        {
            return GetBlockedUsersAsync(id, page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<User>> GetBlockedUsersAsync(int id, int page)
        {
            if (page < 1)
                page = 1;
            return await The100API.SendGetRequest<IEnumerable<User>>(_httpClient, $"users/{id}/blocked_users?page={page}");
        }

        public IEnumerable<FeedItem> GetFeed(int id, int page)
        {
            return GetFeedAsync(id, page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<FeedItem>> GetFeedAsync(int id, int page)
        {
            if (page < 1)
                page = 1;
            return await The100API.SendGetRequest<IEnumerable<FeedItem>>(_httpClient, $"users/{id}/feed?page={page}");
        }

        public IEnumerable<User> GetFriends(int id, int page)
        {
            return GetFriendsAsync(id, page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<User>> GetFriendsAsync(int id, int page)
        {
            if (page < 1)
                page = 1;
            return await The100API.SendGetRequest<IEnumerable<User>>(_httpClient, $"users/{id}/friends?page={page}");
        }

        public IEnumerable<Gamertag> GetGamertags(int id)
        {
            return GetGamertagsAsync(id).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<Gamertag>> GetGamertagsAsync(int id)
        {
            return await The100API.SendGetRequest<IEnumerable<Gamertag>>(_httpClient, $"users/{id}/gamertags");
        }

        public IEnumerable<GamingSession> GetGamingSessions(int id, int page)
        {
            return GetGamingSessionsAsync(id, page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<GamingSession>> GetGamingSessionsAsync(int id, int page)
        {
            if (page < 1)
                page = 1;
            return await The100API.SendGetRequest<IEnumerable<GamingSession>>(_httpClient, $"users/{id}/gaming_sessions?page={page}");
        }

        public IEnumerable<GamingSession> GetGroupGamingSessions(int id, int page)
        {
            return GetGroupGamingSessionsAsync(id, page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<GamingSession>> GetGroupGamingSessionsAsync(int id, int page)
        {
            if (page < 1)
                page = 1;
            return await The100API.SendGetRequest<IEnumerable<GamingSession>>(_httpClient, $"users/{id}/group_gaming_sessions?page={page}");
        }

        public IEnumerable<User> GetGroupMembers(int id, int page)
        {
            return GetGroupMembersAsync(id, page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<User>> GetGroupMembersAsync(int id, int page)
        {
            if (page < 1)
                page = 1;
            return await The100API.SendGetRequest<IEnumerable<User>>(_httpClient, $"users/{id}/group_members?page={page}");
        }

        public IEnumerable<Notification> GetNotifications(int id, int page)
        {
            return GetNotificationsAsync(id, page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<Notification>> GetNotificationsAsync(int id, int page)
        {
            if (page < 1)
                page = 1;
            return await The100API.SendGetRequest<IEnumerable<Notification>>(_httpClient, $"users/{id}/notifications?page={page}");
        }

        public IEnumerable<User> GetPendingFriends(int id, int page)
        {
            return GetPendingFriendsAsync(id, page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<User>> GetPendingFriendsAsync(int id, int page)
        {
            if (page < 1)
                page = 1;
            return await The100API.SendGetRequest<IEnumerable<User>>(_httpClient, $"users/{id}/pending_friends?page={page}");
        }

        public IEnumerable<GamingSession> GetRecentGamingSessions(int id, int page)
        {
            return GetRecentGamingSessionsAsync(id, page).GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<GamingSession>> GetRecentGamingSessionsAsync(int id, int page)
        {
            if (page < 1)
                page = 1;
            return await The100API.SendGetRequest<IEnumerable<GamingSession>>(_httpClient, $"users/{id}/recent_gaming_sessions?page={page}");
        }
    }
}
