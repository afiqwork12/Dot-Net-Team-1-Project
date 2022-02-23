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
    public class BookGenreRepo : IRepo<int, BookGenre>
    {
        private readonly HttpClient _httpClient;
        public BookGenreRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<BookGenre> Add(BookGenre item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("https://localhost:44332/api/bookgenre/", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var BookGenre = JsonConvert.DeserializeObject<BookGenre>(responseText);
                        return BookGenre;
                    }
                }
            }
            return null;
        }

        public async Task<BookGenre> Delete(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("https://localhost:44332/api/bookgenre/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var BookGenre = JsonConvert.DeserializeObject<BookGenre>(responseText);
                        return BookGenre;
                    }
                }
            }
            return null;
        }

        public async Task<BookGenre> Get(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("https://localhost:44332/api/bookgenre/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var BookGenre = JsonConvert.DeserializeObject<BookGenre>(responseText);
                        return BookGenre;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<BookGenre>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("https://localhost:44332/api/bookgenre/"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var BookGenres = JsonConvert.DeserializeObject<IEnumerable<BookGenre>>(responseText);
                        return BookGenres;
                    }
                }
            }
            return null;
        }

        public async Task<BookGenre> Update(BookGenre item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("https://localhost:44332/api/bookgenre/", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var BookGenre = JsonConvert.DeserializeObject<BookGenre>(responseText);
                        return BookGenre;
                    }
                }
            }
            return null;
        }
    }
}
