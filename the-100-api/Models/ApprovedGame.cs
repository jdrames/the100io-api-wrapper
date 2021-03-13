using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{
    /// <summary>
    /// A game that is approved by a group
    /// </summary>
    public class ApprovedGame
    {
        /// <summary>
        /// A unique Id for this entry.
        /// <para>Internal use only.</para>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Id for the <see cref="Models.Game">game</see> that is approved.
        /// </summary>
        [JsonPropertyName("game_id")]
        public int GameId { get; set; }
    }
}
