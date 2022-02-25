using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CarouselForBooksAPI.Models;
using Newtonsoft.Json;

namespace CarouselForBooksAPI.Services
{
    public class BookRepo : IBook<int, Book, string>
    {
        private readonly HttpClient _httpClient;
        public BookRepo()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Book> Add(Book item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("https://localhost:44332/api/book/", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var book = JsonConvert.DeserializeObject<Book>(responseText);
                        return book;
                    }
                }
            }
            return null;
        }

        public async Task<Book> Delete(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("https://localhost:44332/api/book/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var book = JsonConvert.DeserializeObject<Book>(responseText);
                        return book;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<Book>> Filter(string query)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("https://localhost:44332/api/book/filter/" + query))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var books = JsonConvert.DeserializeObject<IEnumerable<Book>>(responseText);
                        return books;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("https://localhost:44332/api/book/"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var books = JsonConvert.DeserializeObject<IEnumerable<Book>>(responseText);
                        return books;
                    }
                }
            }
            return null;
        }

        public async Task<Book> GetT(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("https://localhost:44332/api/book/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var book = JsonConvert.DeserializeObject<Book>(responseText);
                        return book;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<Book>> Search(string query)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("https://localhost:44332/api/book/search/" + query))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var books = JsonConvert.DeserializeObject<IEnumerable<Book>>(responseText);
                        return books;
                    }
                }
            }
            return null;
        }

        public async Task<Book> Update(Book item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("https://localhost:44332/api/book/", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var book = JsonConvert.DeserializeObject<Book>(responseText);
                        return book;
                    }
                }
            }
            return null;
        }
    }
}
