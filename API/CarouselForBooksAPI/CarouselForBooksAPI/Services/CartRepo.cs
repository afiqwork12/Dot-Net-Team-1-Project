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
    public class CartRepo : ICart<int, Cart, string>
    {
        private readonly HttpClient _httpClient;
        public CartRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<Cart> Add(Cart item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:25258/api/Cart/", content))
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
                using (var response = await _httpClient.DeleteAsync("http://localhost:25258/api/Cart/" + key))
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
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("http://localhost:25258/api/Cart/user/" + username))
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

        public async Task<Cart> Get(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:25258/api/Cart/" + key))
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
                using (var response = await _httpClient.GetAsync("https://localhost:25258/api/Cart/"))
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
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:25258/api/Cart/user/" + username))
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
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("http://localhost:25258/api/Cart/" + item.CartId, content))
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
    }
}
