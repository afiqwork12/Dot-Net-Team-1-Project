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
    public class OrderRepo : IOrder<int, Order, string>
    {
        private readonly HttpClient _httpClient;
        private string _token;
        public OrderRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<Order> Add(Order item)
        {
            using (var _httpClient1 = new HttpClient())
            {
                _httpClient1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient1.PostAsync("http://localhost:50451/api/orders/", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Order = JsonConvert.DeserializeObject<Order>(responseText);
                        return Order;
                    }
                }
            }
            return null;
        }

        public async Task<Order> Delete(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync("http://localhost:50451/api/orders/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Order = JsonConvert.DeserializeObject<Order>(responseText);
                        return Order;
                    }
                }
            }
            return null;
        }

        public async Task<Order> GetT(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/orders/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Order = JsonConvert.DeserializeObject<Order>(responseText);
                        return Order;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/orders/"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Orders = JsonConvert.DeserializeObject<IEnumerable<Order>>(responseText);
                        return Orders;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<Order>> GetOrdersByUsername(string username)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/orders/user/" + username))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Orders = JsonConvert.DeserializeObject<IEnumerable<Order>>(responseText);
                        return Orders;
                    }
                }
            }
            return null;
        }

        public async Task<Order> Update(Order item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync("http://localhost:50451/api/orders/" + item.Id, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var Order = JsonConvert.DeserializeObject<Order>(responseText);
                        return Order;
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
