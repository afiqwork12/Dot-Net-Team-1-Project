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

        public async Task<User> Delete(string k)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("http://localhost:50451/api/users/" + k))
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

        public async Task<IEnumerable<User>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/users"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var users = JsonConvert.DeserializeObject<IEnumerable<User>>(responseText);
                        return users;
                    }
                }
            }
            return null;
        }

        public async Task<User> GetT(string k)
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
        public async Task<User> LoginCheck(User user)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:50451/api/users/logincheck/" + user.Username, content))
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
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(t), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("http://localhost:50451/api/users/" + t.Username, content))
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
