using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{
    public class Notification
    {
        /// <summary>
        /// Id of the notification.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The user who triggered the notification.
        /// </summary>
        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Id of the group the notification belongs to.
        /// <para>This currently always returns null.</para>
        /// </summary>
        [JsonPropertyName("group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// Indicates what type of notification this is.
        /// </summary>
        [JsonPropertyName("notification_type")]
        public string NotificationType { get; set; }

        /// <summary>
        /// Internal use only
        /// </summary>
        [JsonPropertyName("notification_object_id")]
        public int NotificationObjectId { get; set; }

        /// <summary>
        /// The message body of the notification.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Indicates if the notification has been read.
        /// </summary>
        [JsonPropertyName("read")]
        public bool Read { get; set; }

        /// <summary>
        /// The partial url the notification targets.
        /// <para>Eg: /gaming_sessions/123521</para>
        /// </summary>
        [JsonPropertyName("target_url")]
        public string TargetUrl { get; set; }

        /// <summary>
        /// The date time the notification was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date time the notification was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The 100.io avatar Id.
        /// </summary>
        [JsonPropertyName("avatar_user_id")]
        public int AvatarUserId { get; set; }

        /// <summary>
        /// The url for the avatar or the user who triggered the notification.
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }        
    }
}
