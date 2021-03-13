using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{
    /// <summary>
    /// A player that has signed up for a gaming session.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Id of the player spot.
        /// <para>This is NOT the user Id of the player.</para>
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Id of the100 <see cref="Models.User">user</see> this player represents.
        /// </summary>
        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// Indicates if this player is signed up as a reserve for the gaming session.
        /// <para>Functionally identical to <see cref="IsReserve"/>.</para>
        /// </summary>
        [JsonPropertyName("reserve_spot")]
        public bool ReserveSpot { get; set; }

        /// <summary>
        /// Indicates if this player is gined up as a reserve for the gaming session.
        /// <para>Functionally identical to <see cref="ReserveSpot"/>.</para>
        /// </summary>
        [JsonPropertyName("is_reserve")]
        public bool IsReserve { get; set; }

        /// <summary>
        /// Indicates if this user is on the waitlist for a primary slot.
        /// <para>Functionally identical to <see cref="IsWaitlist"/>.</para>
        /// </summary>
        [JsonPropertyName("auto_promote")]
        public bool AutoPromote { get; set; }

        /// <summary>
        /// Indicates if this user is on the waitlist for a primary slot.
        /// <para>Functionally identical to <see cref="AutoPromote"/>.</para>
        /// </summary>
        [JsonPropertyName("is_waitlist")]
        public bool IsWaitlist { get; set; }

        /// <summary>
        /// The100 user this player represents.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; }
    }
}
