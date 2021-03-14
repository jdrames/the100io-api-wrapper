using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using the_100_api.Models;

namespace the_100_api.Interfaces
{
    public interface IGamingSessions
    {
        /// <summary>
        /// Retrieves all upcoming gaming sessions
        /// </summary>
        /// <param name="page">Page of results to retrieve. Pages starts at 1.</param>
        /// <returns></returns>
        IEnumerable<GamingSession> GetAll(int page);

        /// <summary>
        /// Retrieves all upcoming gaming sessions
        /// </summary>
        /// <param name="page">Page of results to retrieve. Pages starts at 1.</param>
        /// <returns></returns>
        Task<IEnumerable<GamingSession>> GetAllAsync(int page);

        /// <summary>
        /// Retrieves a gaming session
        /// </summary>
        /// <param name="id">Id of gaming session to retrieve</param>        
        /// <returns></returns>
        GamingSession GetById(int id);

        /// <summary>
        /// Retrieves a gaming session
        /// </summary>
        /// <param name="id">Id of gaming session to retrieve</param>        
        /// <returns></returns>
        Task<GamingSession> GetByIdAsync(int id);
    }
}
