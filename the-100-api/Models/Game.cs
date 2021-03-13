using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{
    /// <summary>
    /// Represents a videogame on the100.io.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// The Id of the game.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the game.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// List of activity names available for this game.
        /// <para>Deprecated: use <see cref="GameActivities"/></para>
        /// </summary>
        [JsonPropertyName("activities")]
        [ObsoleteAttribute("Deprecated. Use GameActivites instead.")]
        public IEnumerable<string> Activities { get; set; }

        /// <summary>
        /// Computed background image for the game.
        /// </summary>
        [JsonPropertyName("computed_background_image")]
        public string BackgroundImage { get; set; }

        /// <summary>
        /// Computed main image for the game.
        /// </summary>
        [JsonPropertyName("computed_main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// Computed thumbnail image.
        /// </summary>
        [JsonPropertyName("computed_thumb_image")]
        public string ThumbImage { get; set; }

        /// <summary>
        /// Computed header image.
        /// </summary>
        [JsonPropertyName("computed_header_image")]
        public string HeaderImage { get; set; }

        /// <summary>
        /// Computed icon image.
        /// </summary>
        [JsonPropertyName("computed_icon_image")]
        public string IconImage { get; set; }

        /// <summary>
        /// List of <see cref="Models.GameActivity">game activites</see> available for this game.
        /// </summary>
        [JsonPropertyName("game_activities")]
        public IEnumerable<GameActivity> GameActivities { get; set; }
    }
}
