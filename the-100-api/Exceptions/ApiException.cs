using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace the_100_api.Exceptions
{
    /// <summary>
    /// Represents an exception when attempting to access the100.io API.
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Http Status Code returned with request
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// Http Status Message returned with request
        /// </summary>
        public string StatusMessage { get; set; }

        public ApiException(string message, HttpResponseMessage response) : base(message)
        {
            StatusCode = response.StatusCode.ToString();
            StatusMessage = response.ReasonPhrase;
        }
    }
}
