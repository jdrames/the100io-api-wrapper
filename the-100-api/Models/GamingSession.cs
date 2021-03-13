using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{
    /// <summary>
    /// Gaming sessions created by users.
    /// </summary>
    public class GamingSession
    {
        /// <summary>
        /// The Id of the gaming session.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The Id of the user who created the gaming session.
        /// </summary>
        [JsonPropertyName("creator_id")]
        public int CreatorId { get; set; }

        /// <summary>
        /// Id of the group the gaming session belongs to.
        /// <para>This field will be null for LFG sessions.</para>
        /// </summary>
        [JsonPropertyName("group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// A note added by the created for this gaming session.
        /// </summary>
        [JsonPropertyName("name")]
        public string Note { get; set; }

        /// <summary>
        /// The time the gaming session starts.
        /// </summary>
        [JsonPropertyName("start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The name of the game activity being played.
        /// </summary>
        [JsonPropertyName("category")]
        public string Activity { get; set; }

        /// <summary>
        /// The max party size for this gaming session.
        /// </summary>
        [JsonPropertyName("team_size")]
        public int TimeSize { get; set; }

        /// <summary>
        /// The platform the game will be played on.
        /// </summary>
        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// Whether a microphone is required.
        /// </summary>
        [JsonPropertyName("mic_required")]
        public bool MicRequired { get; set; }

        /// <summary>
        /// The Id of the <see cref="Models.Game">game</see> for this gaming session.        
        /// </summary>
        [JsonPropertyName("game_id")]
        public int GameId { get; set; }

        /// <summary>
        /// The number of non-reserve players signed up for this gaming session.
        /// </summary>
        [JsonPropertyName("primary_users_count")]
        public int PrimaryUsersCount { get; set; }

        /// <summary>
        /// Player level required the gaming session.
        /// </summary>
        [JsonPropertyName("light_level")]
        public int RequiredLevel { get; set; }

        /// <summary>
        /// Indicates if beginner players are welcome to join the gaming session.
        /// </summary>
        [JsonPropertyName("beginners_welcome")]
        public bool BeginnersWelcome { get; set; }

        /// <summary>
        /// Indicates if a sherpa is requested for the gaming session.
        /// </summary>
        [JsonPropertyName("sherpa_requested")]
        public bool SherpaRequested { get; set; }

        /// <summary>
        /// The gamertag for the creator of the gaming session.
        /// </summary>
        [JsonPropertyName("creator_gamertag")]
        public string CreatorGamertag { get; set; }

        /// <summary>
        /// The name of the game being played.
        /// </summary>
        [JsonPropertyName("game_name")]
        public string GameName { get; set; }

        /// <summary>
        /// The name of the group the came was created for.
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// Clan tag
        /// </summary>
        [JsonPropertyName("clan_tag")]
        public string ClanTag { get; set; }

        /// <summary>
        /// Text label indicating the players required light level for the game.
        /// </summary>
        [JsonPropertyName("display_light_level")]
        public string RequiredLevelLabel { get; set; }

        /// <summary>
        /// Text label indicating if a mic is required.
        /// </summary>
        [JsonPropertyName("display_mic_required")]
        public string MicRequiredLabel { get; set; }

        /// <summary>
        /// A text string representing the start date.
        /// <para>Eg: Mar-03</para>
        /// </summary>
        [JsonPropertyName("formatted_start_time")]
        public string FormattedStartTime { get; set; }

        /// <summary>
        /// If this gaming session has expired.
        /// </summary>
        [JsonPropertyName("is_over")]
        public bool IsOver { get; set; }

        /// <summary>
        /// Indicates if the max primary players have signed up for this gaming session.
        /// </summary>
        [JsonPropertyName("full")]
        public bool IsFull { get; set; }

        /// <summary>
        /// Indicates of there are any primary slots available for this gaming session.
        /// </summary>
        [JsonPropertyName("has_spots_open")]
        public bool HasSpotsOpen { get; set; }

        /// <summary>
        /// Url for the game image.
        /// </summary>
        [JsonPropertyName("game_avatar_url")]
        public string GameAvatarUrl { get; set; }

        /// <summary>
        /// Indicates if this gaming session was created by a new user.
        /// </summary>
        [JsonPropertyName("new_member")]
        public bool NewMember { get; set; }

        /// <summary>
        /// The computed name of the platform the game will be played on.
        /// </summary>
        [JsonPropertyName("computed_platform")]
        public string ComputedPlatform { get; set; }

        /// <summary>
        /// Computed image for the gaming session.
        /// </summary>
        [JsonPropertyName("computed_image")]
        public string ComputedImageUrl { get; set; }

        /// <summary>
        /// Indicates if there are players available to fill primary slots in the reserve list.
        /// </summary>
        [JsonPropertyName("waitlist_users_present")]
        public bool WaitlistUsersPresent { get; set; }

        /// <summary>
        /// The <see cref="GroupPartial"/> this game session is created for.
        /// </summary>
        [JsonPropertyName("group")]
        public GroupPartial Group { get; set; }

        /// <summary>
        /// Players that have signed up for the game.
        /// <para>Includes both primary and reserve players.</para>
        /// </summary>
        [JsonPropertyName("confirmed_sessions")]
        public IEnumerable<Player> Players { get; set; }
    }
}
