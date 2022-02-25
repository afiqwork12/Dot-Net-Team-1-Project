using CarouselForBooksApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Services
{
    public class UserEFRepo : IUser<string, User>
    {
        private readonly HttpClient _httpClient;
        public UserEFRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<User> Add(User t)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(t), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:50451/api/users", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var user = JsonConvert.DeserializeObject<User>(responseText);
                        return user;
                    }
                }
            }
            return null;
        }
        public async Task<User> Get(string k)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/users/" + k))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var user = JsonConvert.DeserializeObject<User>(responseText);
                        return user;
                    }
                }
            }
            return null;
        }
        public async Task<User> Login(User user)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:50451/api/users/Login/", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var myuser = JsonConvert.DeserializeObject<User>(responseText);
                        return myuser;
                    }
                }
            }
            return null;
        }

        public async Task<User> Update(User t)
        {
            using (var _httpClient1 = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(t), Encoding.UTF8, "application/json");
                using (var response = await _httpClient1.PutAsync("http://localhost:50451/api/users/" , content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var user = JsonConvert.DeserializeObject<User>(responseText);
                        return user;
                    }
                }
            }
            return null;
        }
    }
}
