using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using the_100_api.Models;

namespace the_100_api.Interfaces
{
    /// <summary>
    /// Endpoint primarily used by mobile app.
    /// </summary>
    public interface IUsers
    {
        /// <summary>
        /// Retrieves all user tags.
        /// <para>Not specific to user</para>
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetAllTags();

        /// <summary>
        /// Retrieves all user tags.
        /// <para>Not specific to user</para>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<string>> GetAllTagsAsync();

        /// <summary>
        /// Retrieves a user
        /// </summary>
        /// <param name="id">Id of user to retrieve</param>
        /// <returns></returns>
        User GetById(int id);

        /// <summary>
        /// Retrieves a user
        /// </summary>
        /// <param name="id">Id of user to retrieve</param>
        /// <returns></returns>
        Task<User> GetByIdAsync(int id);
        
        /// <summary>
        /// Retrieves avatar urls
        /// </summary>
        /// <param name="gamerTags">A comma separated list of gamertags</param>
        /// <returns></returns>
        object GetAvatarUrls(string gamerTags);

        Task<object> GetAvatarsUrlsAsync(string gamerTags);
    }

    /// <summary>
    /// Endpoint primarily used by mobile app.    
    /// </summary>
    public interface IUserExtended : IUsers
    {
        /// <summary>
        /// Retrieves user gaming sessions.
        /// </summary>
        /// <param name="id">Id of currently authenticated user.</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1.</param>
        /// <returns></returns>
        IEnumerable<GamingSession> GetGamingSessions(int id, int page);

        /// <summary>
        /// Retrieves user gaming sessions.
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        Task<IEnumerable<GamingSession>> GetGamingSessionsAsync(int id, int page);

        /// <summary>
        /// Retrieves users upcoming groups gaming sessions
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        IEnumerable<GamingSession> GetGroupGamingSessions(int id, int page);

        /// <summary>
        /// Retrieves users upcoming groups gaming sessions
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        Task<IEnumerable<GamingSession>> GetGroupGamingSessionsAsync(int id, int page);

        /// <summary>
        /// Retrieves users recently completed gaming sessions
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        IEnumerable<GamingSession> GetRecentGamingSessions(int id, int page);

        /// <summary>
        /// Retrieves users recently completed gaming sessions
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        Task<IEnumerable<GamingSession>> GetRecentGamingSessionsAsync(int id, int page);

        /// <summary>
        /// Retrieves users notifications
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        IEnumerable<Notification> GetNotifications(int id, int page);

        /// <summary>
        /// Retrieves users notifications
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        Task<IEnumerable<Notification>> GetNotificationsAsync(int id, int page);

        /// <summary>
        /// Retrieve users friends
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        IEnumerable<User> GetFriends(int id, int page);

        /// <summary>
        /// Retrieve users friends
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        Task<IEnumerable<User>> GetFriendsAsync(int id, int page);

        /// <summary>
        /// Retrieves users pending friends
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        IEnumerable<User> GetPendingFriends(int id, int page);

        /// <summary>
        /// Retrieves users pending friends
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        Task<IEnumerable<User>> GetPendingFriendsAsync(int id, int page);

        /// <summary>
        /// Retrieves members from all users groups
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        IEnumerable<User> GetGroupMembers(int id, int page);

        /// <summary>
        /// Retrieves members from all users groups
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        Task<IEnumerable<User>> GetGroupMembersAsync(int id, int page);

        /// <summary>
        /// Retrieves all user's blocked users
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        IEnumerable<User> GetBlockedUsers(int id, int page);

        /// <summary>
        /// Retrieves all user's blocked users
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        Task<IEnumerable<User>> GetBlockedUsersAsync(int id, int page);

        /// <summary>
        /// Retrieves users feed items
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        IEnumerable<FeedItem> GetFeed(int id, int page);

        /// <summary>
        /// Retrieves users feed items
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <param name="page">Page of results to retrieve. Pages start at 1</param>
        /// <returns></returns>
        Task<IEnumerable<FeedItem>> GetFeedAsync(int id, int page);

        /// <summary>
        /// Retrieves users approved games
        /// <para>Games they play and want notifications for</para>
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <returns></returns>
        IEnumerable<ApprovedGame> GetApprovedGames(int id);

        /// <summary>
        /// Retrieves users approved games
        /// <para>Games they play and want notifications for</para>
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <returns></returns>
        Task<IEnumerable<ApprovedGame>> GetApprovedGamesAsync(int id);

        /// <summary>
        /// Retrieves gamertags of all user's friends and group members
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <returns></returns>
        IEnumerable<Gamertag> GetGamertags(int id);

        /// <summary>
        /// Retrieves gamertags of all user's friends and group members
        /// </summary>
        /// <param name="id">Id of currently authenticated user</param>
        /// <returns></returns>
        Task<IEnumerable<Gamertag>> GetGamertagsAsync(int id);
    }
}
