using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{
    /// <summary>
    /// A item showing up in a groups activity feed.
    /// </summary>
    public class FeedItem
    {
        /// <summary>
        /// Id for the feed item.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Id of the user. Not in use. Will always return null value.
        /// <para>Use <see cref="AuthorUserId"/> instead.</para>
        /// </summary>
        [JsonPropertyName("user_id")]
        [ObsoleteAttribute("Use AuthorUserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// Id of the group the feed item belongs to.
        /// </summary>
        [JsonPropertyName("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// The type of feed item being represented.
        /// </summary>
        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// Any additional data that is returned with this feed item.
        /// </summary>
        [JsonPropertyName("data")]
        public object Data { get; set; }

        /// <summary>
        /// Any users that are related to this feed item.
        /// </summary>
        [JsonPropertyName("related_users")]
        public object RelatedUsers { get; set; }

        /// <summary>
        /// The title of the feed item.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// The body text of the feed item.
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// The url the feed item is targeting.
        /// <para>Eg: /users/3775</para>
        /// <para>Eg: /gaming_sessions/12435</para>
        /// </summary>
        [JsonPropertyName("target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// The url used in the100.io app. You probably won't ever use this.
        /// <para>Internal use only.</para>
        /// </summary>
        [JsonPropertyName("target_url_app")]
        public string TargetAppUrl { get; set; }

        /// <summary>
        /// The user Id associated with the feed item.
        /// </summary>
        [JsonPropertyName("author_user_id")]
        public int AuthorUserId { get; set; }

        /// <summary>
        /// Url for the authors avatar.
        /// </summary>
        [JsonPropertyName("author_avatar_url")]
        public string AuthorAvatarUrl { get; set; }

        /// <summary>
        /// The authors gamertag.
        /// </summary>
        [JsonPropertyName("author_gamertag")]
        public string AuthorGamertag { get; set; }

        /// <summary>
        /// A date time representing when to display the feed item after.
        /// </summary>
        [JsonPropertyName("display_after")]
        public DateTime DisplayAfter { get; set; }

        /// <summary>
        /// The date time the feed item was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date time the feed item was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
