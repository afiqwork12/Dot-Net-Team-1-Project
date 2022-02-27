using CarouselForBooksAPI.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarouselForBooksAPI.Services
{
    public class OrderRepo : IOrder<int, Order, string>
    {
        private readonly HttpClient _httpClient;
        private readonly string apiLink;
        public OrderRepo(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            apiLink = configuration["OrderAPILink"];
        }
        public async Task<Order> Add(Order item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync(apiLink + "/api/orders/", content))
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
                using (var response = await _httpClient.DeleteAsync(apiLink + "/api/orders/" + key))
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

        public async Task<Order> Get(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync(apiLink + "/api/orders/" + key))
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
                using (var response = await _httpClient.GetAsync(apiLink + "/api/orders/"))
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
                using (var response = await _httpClient.GetAsync(apiLink + "/api/orders/user/" + username))
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
                using (var response = await _httpClient.PutAsync(apiLink + "/api/orders/" + item.Id, content))
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
    }
}
