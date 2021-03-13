using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{
    /// <summary>
    /// A header image used for groups.
    /// </summary>
    public class HeaderImage
    {
        /// <summary>
        /// The url of a groups custom header image
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// The <see cref="Models.UrlElement">url element</see> used for web views.
        /// </summary>
        [JsonPropertyName("web")]
        public UrlElement Web { get; set; }

        /// <summary>
        /// The <see cref="Models.UrlElement">url element</see> used for mobile views.
        /// </summary>
        [JsonPropertyName("mobile")]
        public UrlElement Mobile { get; set; }
    }
}
