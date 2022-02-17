using CarouselForBooksApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace CarouselForBooksApplication.Services
{
    public class BookEFRepo : IRepo<int, Book>
    {
        private readonly HttpClient _httpClient;
        public BookEFRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<Book> Add(Book t)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(t), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:50451/api/Books", content))
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

        public async Task<Book> Delete(int k)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("http://localhost:50451/api/Books/" + k))
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

        public async Task<IEnumerable<Book>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/Books"))
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

        public async Task<Book> GetT(int k)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/Books/" + k))
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

        public async Task<Book> Update(Book t)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(t), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("http://localhost:50451/api/Books" + t.Id, content))
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
