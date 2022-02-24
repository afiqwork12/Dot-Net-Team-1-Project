using CarouselForBooksApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Headers;

namespace CarouselForBooksApplication.Services
{
    public class BookEFRepo : IBook<int, Book, string>
    {
        private readonly HttpClient _httpClient;
        private string _token;
        public BookEFRepo()
        {
            _httpClient = new HttpClient();
        }
        public void GetToken(string token)
        {
            _token = token;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
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
            using (var _httpClient1 = new HttpClient())
            {
                _httpClient1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                using (var response = await _httpClient1.GetAsync("http://localhost:50451/api/Books/" + k))
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
                using (var response = await _httpClient.PutAsync("http://localhost:50451/api/Books", content))
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
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/Books/Search/" + query))
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

        public async Task<IEnumerable<Book>> Filter(string query)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/Books/Filter/" + query))
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
    }
}
