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
    public class OrderItemRepo : IOrderItem<int, OrderItem, int>
    {
        private readonly HttpClient _httpClient;
        private string _token;
        public OrderItemRepo()
        {
            _httpClient = new HttpClient();
        }
        public async Task<OrderItem> Add(OrderItem item)
        {
            using (var _httpClient1 = new HttpClient())
            {
                _httpClient1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using (var response = await _httpClient1.PostAsync("http://localhost:50451/api/orderitems/", content))
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
                using (var response = await _httpClient.DeleteAsync("http://localhost:50451/api/orderitems/" + key))
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

        public async Task<OrderItem> GetT(int key)
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/orderitems/" + key))
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
                using (var response = await _httpClient.GetAsync("http://localhost:50451/api/orderitems/"))
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
            using (var _httpClient1 = new HttpClient())
            {
                _httpClient1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _httpClient1.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                using (var response = await _httpClient1.GetAsync("http://localhost:50451/api/orderitems/orderid/" + orderId))
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
                using (var response = await _httpClient.PutAsync("http://localhost:50451/api/orderitems/" + item.Id, content))
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

        public void GetToken(string token)
        {
            _token = token;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        }
    }
}
