using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace the_100_api
{
    public class The100API : IDisposable
    {
        private readonly string _token;
        private readonly HttpClient _httpClient;
        public readonly Endpoints.GamingSessions GamingSessions;
        public readonly Endpoints.Games Games;
        public readonly Endpoints.Groups Groups;
        public readonly Endpoints.Users Users;

        public The100API(string the100Token)
        {
            _token = the100Token;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://www.the100.io/api/v2/");
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Token token\"{_token}\"");
            GamingSessions = new Endpoints.GamingSessions(_httpClient);
            Games = new Endpoints.Games(_httpClient);
            Groups = new Endpoints.Groups(_httpClient);
            Users = new Endpoints.Users(_httpClient);
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
    }
}
