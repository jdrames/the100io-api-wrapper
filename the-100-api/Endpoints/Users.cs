using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using the_100_api.Interfaces;
using the_100_api.Models;

namespace the_100_api.Endpoints
{
    /// <summary>
    /// Represents The100.io Endpoint https://www.the100.io/v2/users
    /// </summary>
    public class Users : IUsers
    {
        private readonly HttpClient _httpClient;

        public Users(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IEnumerable<string> GetAllTags()
        {
            return GetAllTagsAsync().GetAwaiter().GetResult();
        }

        public async Task<IEnumerable<string>> GetAllTagsAsync()
        {
            return await The100API.SendGetRequest<IEnumerable<string>>(_httpClient, $"users/all_tags");
        }

        public async Task<object> GetAvatarsUrlsAsync(string gamerTags)
        {
            return await The100API.SendGetRequest<object>(_httpClient, $"users/avatar_urls?gamertags={gamerTags}");
        }

        public object GetAvatarUrls(string gamerTags)
        {
            return GetAvatarsUrlsAsync(gamerTags).GetAwaiter().GetResult();
        }

        public User GetById(int id)
        {
            return GetByIdAsync(id).GetAwaiter().GetResult();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await The100API.SendGetRequest<User>(_httpClient, $"users/{id}");
        }
    }
}
