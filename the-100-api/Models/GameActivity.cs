using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{
    /// <summary>
    /// An activity available for a specific game on the100.io
    /// </summary>
    public class GameActivity
    {
        /// <summary>
        /// The Id of the activity.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the game the activity belongs to.
        /// </summary>
        [JsonPropertyName("game_id")]
        public int GameId { get; set; }

        /// <summary>
        /// The name of the activity.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
