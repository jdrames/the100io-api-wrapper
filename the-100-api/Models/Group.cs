using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{
    /// <summary>
    /// Represents a group from the100.io.
    /// </summary>
    public class Group : GroupPartial
    {
        /// <summary>
        /// A sort note describing the group.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The latest news for the group.
        /// </summary>
        [JsonPropertyName("latest_news")]
        public string LatestNews { get; set; }

        /// <summary>
        /// The average age of players in the group.
        /// </summary>
        [JsonPropertyName("avg_age")]
        public int AverageAge { get; set; }

        /// <summary>
        /// The play style for the group.
        /// </summary>
        [JsonPropertyName("play_style")]
        public string PlayStyle { get; set; }

        /// <summary>
        /// Indicates if profanity is ok for this group.
        /// <see cref="NoProfanity"/>
        /// </summary>
        [ObsoleteAttribute("Use NoProfanity")]
        [JsonPropertyName("profanity_ok")]
        public object ProfanityOk { get; set; }

        /// <summary>
        /// The primary platform the group games on.
        /// </summary>
        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// A string indicating the groups timezone.
        /// <para>Eg: Eastern Time (US & Canada)</para>
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Indicates if a microphone are required for players in the group.
        /// </summary>
        [JsonPropertyName("headset")]
        public string Headset { get; set; }

        /// <summary>
        /// A string indicating the normal play times of the group.
        /// </summary>
        [JsonPropertyName("play_schedule")]
        public string PlaySchedule { get; set; }

        /// <summary>
        /// Indicates if the group is tagged or consists of mostly parents.
        /// </summary>
        [JsonPropertyName("parents")]
        public bool Parents { get; set; }

        /// <summary>
        /// Indicates if the group is tagged or consists of mostly college students.
        /// </summary>
        [JsonPropertyName("college_students")]
        public bool CollegeStudents { get; set; }

        /// <summary>
        /// Indicates if profanity is allowed in this group.
        /// </summary>
        [JsonPropertyName("no_profanity")]
        public bool NoProfanity { get; set; }

        /// <summary>
        /// Indicates if the group is tagged as PVP only.
        /// </summary>
        [JsonPropertyName("pvp_only")]
        public bool PvpOnly { get; set; }

        /// <summary>
        /// The country that group is based in.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The language the group uses to communicate.
        /// </summary>
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// The groups activity score.
        /// </summary>
        [JsonPropertyName("activity_score")]
        public int ActivityScore { get; set; }

        /// <summary>
        /// An html string of the groups latest news.
        /// </summary>
        [JsonPropertyName("latest_news_html")]
        public string LatestNewsHtml { get; set; }

        /// <summary>
        /// A header image for the group.
        /// </summary>
        [JsonPropertyName("header_image")]
        public HeaderImage HeaderImage { get; set; }

        /// <summary>
        /// A url for this groups Twitch channel.
        /// </summary>
        [JsonPropertyName("url_twitch")]
        public string TwitchUrl { get; set; }

        /// <summary>
        /// A url for this groups YouTube channel.
        /// </summary>
        [JsonPropertyName("url_youtube")]
        public string YoutubeUrl { get; set; }

        /// <summary>
        /// A url for this groups Twitter profile.
        /// </summary>
        [JsonPropertyName("url_twitter")]
        public string TwitterUrl { get; set; }

        /// <summary>
        /// A embed url for the group.
        /// </summary>
        [JsonPropertyName("embed_url")]
        public string EmbedUrl { get; set; }

        /// <summary>
        /// The background theme image for the group.
        /// </summary>
        [JsonPropertyName("background_theme")]
        public string BackgroundTheme { get; set; }

        /// <summary>
        /// The region of the world this group is located in.
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// This groups Discord server Id.
        /// </summary>
        [JsonPropertyName("discord_server_id")]
        public string DiscordServerId { get; set; }

        /// <summary>
        /// The groups clan tag on The100.io.
        /// </summary>
        [JsonPropertyName("clan_tag")]
        public string ClanTag { get; set; }

        /// <summary>
        /// A formatted string of the platforms this group games on.
        /// </summary>
        [JsonPropertyName("platform_formatted")]
        public string PlatformFormatted { get; set; }

        /// <summary>
        /// A formatted string of the groups description.
        /// </summary>
        [JsonPropertyName("formatted_description")]
        public string DescriptionFormatted { get; set; }

        /// <summary>
        /// A formatted string of the groups latest news.
        /// </summary>
        [JsonPropertyName("latest_news_simple_format")]
        public string LatestNewsSimpleFormat { get; set; }

        /// <summary>
        /// Url for the groups header background image.
        /// </summary>
        [JsonPropertyName("header_background_image_api")]
        public string HeaderBackgroundImage { get; set; }
    }
}
