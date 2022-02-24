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
    public class CartRepo : ICart<int, Cart, string>
    {
        private readonly HttpClient _httpClient;
        private string _token;
        public CartRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<Cart> Add(Cart item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:50451/api/Carts/", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Cart = JsonConvert.DeserializeObject<Cart>(responseText);
                        return Cart;
                    }
                }
            }
            return null;
        }

        public async Task<Cart> Delete(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("http://localhost:50451/api/Carts/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Cart = JsonConvert.DeserializeObject<Cart>(responseText);
                        return Cart;
                    }
                }
            }
            return null;
        }
        public async Task<IEnumerable<Cart>> DeleteUserCarts(string username)
        {
            using (var _httpClient1 = new HttpClient())
            {
                _httpClient1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                using (var response = await _httpClient1.DeleteAsync("http://localhost:50451/api/Carts/user/" + username))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Carts = JsonConvert.DeserializeObject<IEnumerable<Cart>>(responseText);
                        return Carts;
                    }
                }
            }
            return null;
        }

        public async Task<Cart> GetT(int key)
        {
            using (var _httpClient1 = new HttpClient())
            {
                _httpClient1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                using (var response = await _httpClient1.GetAsync("http://localhost:50451/api/Carts/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Cart = JsonConvert.DeserializeObject<Cart>(responseText);
                        return Cart;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<Cart>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("https://localhost:50451/api/Carts/"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Carts = JsonConvert.DeserializeObject<IEnumerable<Cart>>(responseText);
                        return Carts;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<Cart>> GetCartsByUsername(string username)
        {
            using (var _httpClient1 = new HttpClient())
            {
                _httpClient1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                using (var response = await _httpClient1.GetAsync("http://localhost:50451/api/Carts/user/" + username))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Carts = JsonConvert.DeserializeObject<IEnumerable<Cart>>(responseText);
                        return Carts;
                    }
                }
            }
            return null;
        }

        public async Task<Cart> Update(Cart item)
        {
            using (var _httpClient1 = new HttpClient())
            {
                _httpClient1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient1.PutAsync("http://localhost:50451/api/Carts/", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Cart = JsonConvert.DeserializeObject<Cart>(responseText);
                        return Cart;
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
