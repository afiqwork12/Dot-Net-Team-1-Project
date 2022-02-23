using CarouselForBooksAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarouselForBooksAPI.Services
{
    public class GenreRepo : IRepo<int, Genre>
    {
        private readonly HttpClient _httpClient;
        public GenreRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<Genre> Add(Genre item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("https://localhost:44332/api/Genre/", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Genre = JsonConvert.DeserializeObject<Genre>(responseText);
                        return Genre;
                    }
                }
            }
            return null;
        }

        public async Task<Genre> Delete(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("https://localhost:44332/api/Genre/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Genre = JsonConvert.DeserializeObject<Genre>(responseText);
                        return Genre;
                    }
                }
            }
            return null;
        }

        public async Task<Genre> Get(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("https://localhost:44332/api/Genre/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Genre = JsonConvert.DeserializeObject<Genre>(responseText);
                        return Genre;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<Genre>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("https://localhost:44332/api/Genre/"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Genres = JsonConvert.DeserializeObject<IEnumerable<Genre>>(responseText);
                        return Genres;
                    }
                }
            }
            return null;
        }

        public async Task<Genre> Update(Genre item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("https://localhost:44332/api/Genre/", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Genre = JsonConvert.DeserializeObject<Genre>(responseText);
                        return Genre;
                    }
                }
            }
            return null;
        }
    }
}
