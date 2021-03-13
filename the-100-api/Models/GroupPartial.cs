using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{   
    /// <summary>
    /// A partial view of <see cref="Models.Group"/>.
    /// </summary>
    public class GroupPartial
    {
        /// <summary>
        /// The Id of the group from the100.io.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the group.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The number of users in the group.
        /// </summary>
        [JsonPropertyName("user_count")]
        public int UserCount { get; set; }

        /// <summary>
        /// Short tagline for the group.
        /// </summary>
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// Groups header background image
        /// </summary>
        [JsonPropertyName("header_background_image_api")]
        public string HeaderBackroundImageUrl { get; set; }
    }
}
