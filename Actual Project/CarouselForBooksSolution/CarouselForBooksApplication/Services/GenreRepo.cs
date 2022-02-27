using CarouselForBooksApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Services
{
    public class GenreRepo : IRepo<int, Genre>
    {
        private readonly HttpClient _httpClient;
        private string _token;
        public GenreRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<Genre> Add(Genre item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:50451/api/genres/", content))
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
                using (var response = await _httpClient.DeleteAsync("http://localhost:50451/api/genres/" + key))
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

        public async Task<Genre> GetT(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/genres/" + key))
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
            using (var _httpClient1 = new HttpClient())
            {
                _httpClient1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                using (var response = await _httpClient1.GetAsync("http://localhost:50451/api/genres/"))
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
                using (var response = await _httpClient.PutAsync("http://localhost:50451/api/genres/", content))
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

        public void GetToken(string token)
        {
            _token = token;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        }
    }
}
