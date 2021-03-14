using System;
using System.Collections.Generic;
using System.Text;

namespace the_100_api
{
    /// <summary>
    /// The type of token being used to access the API.
    /// </summary>
    public enum TokenType
    {
        /// <summary>
        /// A token representing a group
        /// </summary>
        Group,

        /// <summary>
        /// A token representing a user
        /// </summary>
        User
    }
}
