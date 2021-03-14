using System;
using System.Collections.Generic;
using System.Text;

namespace the_100_api.Models
{
    /// <summary>
    /// The platform a group plays on
    /// </summary>
    public class PlatformMembership
    {
        /// <summary>
        /// Id for the platform membership entry
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id for the platform
        /// </summary>
        public int PlatformId { get; set; }
    }
}
