using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace the_100_api.Models
{
    public class UrlElement
    {
        /// <summary>
        /// The url for this resourse.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
