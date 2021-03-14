using System;
using System.Collections.Generic;
using System.Text;

namespace the_100_api.Models
{
    /// <summary>
    /// Gamertags used for chat
    /// </summary>
    public class Gamertag
    {
        /// <summary>
        /// Id of user
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// @ name of user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The users avatar url
        /// </summary>
        public string ComputedAvatarApi { get; set; }

        /// <summary>
        /// The users avatar url for chat
        /// </summary>
        public string ComputedAvatarChat { get; set; }
    }
}
