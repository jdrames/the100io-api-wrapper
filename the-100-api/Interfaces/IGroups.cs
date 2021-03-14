using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using the_100_api.Models;

namespace the_100_api.Interfaces
{
    public interface IGroups
    {
        /// <summary>
        /// Retrieves a group
        /// </summary>
        /// <param name="id">Id of group to retrieve</param>
        /// <returns></returns>
        Group GetById(int id);

        /// <summary>
        /// Retrieves a group
        /// </summary>
        /// <param name="id">Id of group to retrieve</param>
        /// <returns></returns>
        Task<Group> GetByIdAsync(int id);

        /// <summary>
        /// Retrieves group gaming sessions
        /// </summary>
        /// <param name="id">Id of group to retrieve sessions for</param>
        /// <param name="page">Page of results to retrieve. Pages starts at 1.</param>
        /// <returns></returns>
        IEnumerable<GamingSession> GetGamingSessions(int id, int page);

        /// <summary>
        /// Retrieves group gaming sessions
        /// </summary>
        /// <param name="id">Id of group to retrieve sessions for</param>
        /// <param name="page">Page of results to retrieve. Pages starts at 1.</param>
        /// <returns></returns>
        Task<IEnumerable<GamingSession>> GetGamingSessionsAsync(int id, int page);

        /// <summary>
        /// Retrieves group members
        /// </summary>
        /// <param name="id">Id of group to retrieve members for</param>
        /// <param name="page">Page of results to retrieve. Pages starts at 1.</param>
        /// <returns></returns>
        IEnumerable<User> GetUsers(int id, int page);

        /// <summary>
        /// Retrieves group members
        /// </summary>
        /// <param name="id">Id of group to retrieve members for</param>
        /// <param name="page">Page of results to retrieve. Pages starts at 1.</param>
        /// <returns></returns>
        Task<IEnumerable<User>> GetUsersAsync(int id, int page);

        /// <summary>
        /// Retrieves all group tags.
        /// <para>Not group specific</para>
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetAllTags();

        /// <summary>
        /// Retrieves all group tags.
        /// <para>Not group specific</para>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<string>> GetAllTagsAsync();

        /// <summary>
        /// Retrieves approved games for group
        /// </summary>
        /// <param name="id">Id of group to retrieve approved games for</param>
        /// <returns></returns>
        IEnumerable<ApprovedGame> GetApprovedGames(int id);

        /// <summary>
        /// Retrieves approved games for group
        /// </summary>
        /// <param name="id">Id of group to retrieve approved games for</param>
        /// <returns></returns>
        Task<IEnumerable<ApprovedGame>> GetApprovedGamesAsync(int id);

        /// <summary>
        /// Retrieves platform memberships for group
        /// </summary>
        /// <param name="id">Id of group to retrieve platform memberships for</param>
        /// <returns></returns>
        IEnumerable<PlatformMembership> GetPlatformMemberships(int id);

        /// <summary>
        /// Retrieves platform memberships for group
        /// </summary>
        /// <param name="id">Id of group to retrieve platform memberships for</param>
        /// <returns></returns>
        Task<IEnumerable<PlatformMembership>> GetPlatformMembershipsAsync(int id);

        /// <summary>
        /// Retrieves a groups feed items
        /// </summary>
        /// <param name="id">Id of group to retrieve feed items for</param>
        /// <returns></returns>
        IEnumerable<FeedItem> GetFeed(int id);

        /// <summary>
        /// Retrieves a groups feed items
        /// </summary>
        /// <param name="id">Id of group to retrieve feed items for</param>
        /// <returns></returns>
        Task<IEnumerable<FeedItem>> GetFeedAsync(int id);
    }
}
