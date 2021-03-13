using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{
    /// <summary>
    /// A user on the100.io.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The users gamertag used on the100.io.
        /// </summary>
        [JsonPropertyName("gamertag")]
        public string Gamertag { get; set; }

        /// <summary>
        /// The users Destiny level.
        /// </summary>
        [JsonPropertyName("level")]
        public int Level { get; set; }

        /// <summary>
        /// Indicates if this is a the100.io supporter.
        /// </summary>
        [JsonPropertyName("supporter")]
        public bool Supporter { get; set; }

        /// <summary>
        /// The number of karma points the user has received from other the100.io users.
        /// </summary>
        [JsonPropertyName("karmas_count")]
        public int Karma { get; set; }

        /// <summary>
        /// The light level of the users Destiny character.
        /// </summary>
        [JsonPropertyName("light_level")]
        public int LightLevel { get; set; }

        /// <summary>
        /// The users Playstation Network id.
        /// </summary>
        [JsonPropertyName("psn_id")]
        public string PsnId { get; set; }

        /// <summary>
        /// The users Xbox Live id.
        /// </summary>
        [JsonPropertyName("xbox_live_id")]
        public string XboxLiveId { get; set; }

        /// <summary>
        /// The users Windows Live id.
        /// </summary>
        [JsonPropertyName("xbox_windows_id")]
        public string XboxWindowsId { get; set; }

        /// <summary>
        /// The users Steam id.
        /// </summary>
        [JsonPropertyName("steam_id")]
        public string SteamId { get; set; }

        /// <summary>
        /// The users BattleNet id.
        /// </summary>
        [JsonPropertyName("battle_net_id")]
        public string BattleNetId { get; set; }

        /// <summary>
        /// The users Uplay id.
        /// </summary>
        [JsonPropertyName("uplay_id")]
        public string UplayId { get; set; }

        /// <summary>
        /// The users Bungie.net Id
        /// </summary>
        [JsonPropertyName("bungie_id")]
        public string BungieId { get; set; }

        /// <summary>
        /// The users EA id.
        /// </summary>
        [JsonPropertyName("ea_id")]
        public string EaId { get; set; }

        /// <summary>
        /// The users Epic id.
        /// </summary>
        [JsonPropertyName("epic_id")]
        public string EpicId { get; set; }

        /// <summary>
        /// The users Bethesda id.
        /// </summary>
        [JsonPropertyName("bethesda_id")]
        public string BethesdaId { get; set; }

        /// <summary>
        /// The users Stadia id.
        /// </summary>
        [JsonPropertyName("stadia_id")]
        public string StadiaId { get; set; }

        /// <summary>
        /// The users Riot Games id.
        /// </summary>
        [JsonPropertyName("riot_id")]
        public string RiotId { get; set; }

        /// <summary>
        /// A formatted string indicating if the user is ok with profanity in chat.
        /// </summary>
        [JsonPropertyName("profanity_ok_formatted")]
        public string ProfanityOk { get; set; }

        /// <summary>
        /// Url of the users computed avatar image.
        /// </summary>
        [JsonPropertyName("computed_avatar_api")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Url of the users computed chat avatar image.
        /// </summary>
        [JsonPropertyName("computed_avatar_chat")]
        public string ChatAvatarUrl { get; set; }

        /// <summary>
        /// Indicates if the users has the100.io developers badge.
        /// </summary>
        [JsonPropertyName("developer_badge")]
        public bool HasDeveloperBadge { get; set; }

        /// <summary>
        /// The users age.
        /// </summary>
        [JsonPropertyName("display_age")]
        public string DisplayAge { get; set; }

        /// <summary>
        /// The users sherpa level on the100.io.
        /// </summary>
        [JsonPropertyName("display_sherpa_status")]
        public int SherpaLevel { get; set; }
    }
}
