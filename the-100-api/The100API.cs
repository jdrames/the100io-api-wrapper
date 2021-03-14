using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using the_100_api.Interfaces;

namespace the_100_api
{
    /// <summary>
    /// A wrapper for www.the100.io's API
    /// </summary>
    public class The100API : IDisposable
    {
        private readonly string _token;
        private readonly HttpClient _httpClient;
        public readonly IGamingSessions GamingSessions;
        public readonly IGames Games;
        public readonly IGroups Groups;
        public readonly IUsers Users;

        /// <summary>
        /// Creates a new instance with the wrapper.
        /// <para>If <see cref="TokenType"/> is group, the <see cref="Users"/> field will be of type <see cref="IUsers"/></para>
        /// <para>If <see cref="TokenType"/> is User, the <see cref="Users"/> field will be of type <see cref="IUserExtended"/></para>
        /// </summary>
        /// <param name="tokenType"></param>
        /// <param name="the100Token"></param>
        public The100API(TokenType tokenType, string the100Token)
        {
            _token = the100Token;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://www.the100.io/api/v2/");
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Token token\"{_token}\"");
            GamingSessions = new Endpoints.GamingSessions(_httpClient);
            Games = new Endpoints.Games(_httpClient);
            Groups = new Endpoints.Groups(_httpClient);
            if (tokenType == TokenType.Group)
                Users = new Endpoints.Users(_httpClient);
            else if (tokenType == TokenType.User)
                Users = new Endpoints.UsersExtended(_httpClient);
        }

        public void Dispose()
        {            
            _httpClient?.Dispose();
        }

        /// <summary>
        /// Generate a error message from a http response message.
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        internal static Exceptions.ApiException CreateApiErrorMessage(HttpResponseMessage response)
        {
            return new Exceptions.ApiException($"The api request failed.", response);
        }

        /// <summary>
        /// A helper to quickly deserialize API response messages.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        internal static async Task<T> Deserialize<T>(HttpResponseMessage response)
        {
            return JsonSerializer.Deserialize<T>(await response.Content.ReadAsStringAsync());
        }    

        internal static async Task<T> SendGetRequest<T>(HttpClient httpClient, string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            var response = await httpClient.SendAsync(request);
            if (!response.IsSuccessStatusCode)
                throw CreateApiErrorMessage(response);
            return await Deserialize<T>(response);
        }
    }
}
