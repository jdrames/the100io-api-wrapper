using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using the_100_api.Models;

namespace the_100_api.Interfaces
{
    public interface IGames
    {
        /// <summary>
        /// Retrieves all games and their associated <see cref="Models.GameActivity">activities.</see>        
        /// </summary>
        /// <returns></returns>
        IEnumerable<Game> GetAll();

        /// <summary>
        /// Retrieves all games and their associated <see cref="Models.GameActivity">activities</see>
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Game>> GetAllAsync();
    }
}
