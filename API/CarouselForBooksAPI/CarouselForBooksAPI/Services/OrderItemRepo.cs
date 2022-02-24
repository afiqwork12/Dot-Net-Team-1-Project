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
    public class OrderItemRepo : IOrderItem<int, OrderItem, int>
    {
        private readonly HttpClient _httpClient;
        public OrderItemRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<OrderItem> Add(OrderItem item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient.PostAsync("http://localhost:36621/api/orderitems/", content))
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
                using (var response = await _httpClient.DeleteAsync("http://localhost:36621/api/orderitems/" + key))
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
                using (var response = await _httpClient.GetAsync("http://localhost:36621/api/orderitems/" + key))
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
                using (var response = await _httpClient.GetAsync("http://localhost:36621/api/orderitems/"))
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
                using (var response = await _httpClient.GetAsync("http://localhost:36621/api/orderitems/orderid/" + orderId))
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
                using (var response = await _httpClient.PutAsync("http://localhost:36621/api/orderitems/" + item.Id, content))
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
