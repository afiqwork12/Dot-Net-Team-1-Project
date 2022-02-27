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
    public class OrderItemRepo : IOrderItem<int, OrderItem, int>
    {
        private readonly HttpClient _httpClient;
        private readonly string apiLink;
        public OrderItemRepo(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            apiLink = configuration["OrderAPILink"];
        }
        public async Task<OrderItem> Add(OrderItem item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync(apiLink + "/api/orderitems/", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var OrderItem = JsonConvert.DeserializeObject<OrderItem>(responseText);
                        return OrderItem;
                    }
                }
            }
            return null;
        }

        public async Task<OrderItem> Delete(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.DeleteAsync(apiLink + "/api/orderitems/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var OrderItem = JsonConvert.DeserializeObject<OrderItem>(responseText);
                        return OrderItem;
                    }
                }
            }
            return null;
        }

        public async Task<OrderItem> Get(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync(apiLink + "/api/orderitems/" + key))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var OrderItem = JsonConvert.DeserializeObject<OrderItem>(responseText);
                        return OrderItem;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<OrderItem>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync(apiLink + "/api/orderitems/"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var OrderItems = JsonConvert.DeserializeObject<IEnumerable<OrderItem>>(responseText);
                        return OrderItems;
                    }
                }
            }
            return null;
        }

        public async Task<IEnumerable<OrderItem>> GetOrderItemsByOrderId(int orderId)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync(apiLink + "/api/orderitems/orderid/" + orderId))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var OrderItems = JsonConvert.DeserializeObject<IEnumerable<OrderItem>>(responseText);
                        return OrderItems;
                    }
                }
            }
            return null;
        }

        public async Task<OrderItem> Update(OrderItem item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PutAsync(apiLink + "/api/orderitems/" + item.Id, content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var OrderItem = JsonConvert.DeserializeObject<OrderItem>(responseText);
                        return OrderItem;
                    }
                }
            }
            return null;
        }
    }
}
