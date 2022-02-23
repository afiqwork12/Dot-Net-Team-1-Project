﻿using CarouselForBooksApplication.Models;
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
    public class BookGenreRepo : IRepo<int, BookGenre>
    {
        private readonly HttpClient _httpClient;
        private string _token;
        public BookGenreRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<BookGenre> Add(BookGenre item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("https://localhost:50451/api/bookgenres/", content))
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
                using (var response = await _httpClient.DeleteAsync("https://localhost:50451/api/bookgenres/" + key))
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

        public async Task<BookGenre> GetT(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("https://localhost:50451/api/bookgenres/" + key))
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
                using (var response = await _httpClient.GetAsync("https://localhost:50451/api/bookgenres/"))
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
                using (var response = await _httpClient.PutAsync("https://localhost:50451/api/bookgenres/", content))
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

        public void GetToken(string token)
        {
            _token = token;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        }
    }
}
