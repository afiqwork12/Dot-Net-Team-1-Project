using CarouselForBooksAPI.Models;
using CarouselForBooksAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarouselForBooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderItemsController : ControllerBase
    {
        private readonly IOrderItem<int, OrderItem, int> _repo;
        public OrderItemsController(IOrderItem<int, OrderItem, int> repo)
        {
            _repo = repo;
        }
        // GET: api/<OrderItemsController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var orderitems = await _repo.GetAll();
            if (orderitems != null)
            {
                return Ok(orderitems);
            }
            return BadRequest("No order items found");
        }

        // GET api/<OrderItemsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var orderitem = await _repo.Get(id);
            if (orderitem != null)
            {
                return Ok(orderitem);
            }
            return BadRequest("No such order item exist");
        }
        [HttpGet("orderId/{orderId}")]
        public async Task<ActionResult> GetOrderItemsByOrderId(int orderId)
        {
            var orderitems = await _repo.GetOrderItemsByOrderId(orderId);
            if (orderitems != null)
            {
                return Ok(orderitems);
            }
            return BadRequest("No such order items exist");
        }

        // POST api/<OrderItemsController>
        [HttpPost]
        public async Task<ActionResult> Post(OrderItem orderItem)
        {
            orderItem = await _repo.Add(orderItem);
            if (orderItem != null)
            {
                return Ok(orderItem);
            }
            return BadRequest("Unable to add order item");
        }

        // PUT api/<OrderItemsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(OrderItem orderItem)
        {
            orderItem = await _repo.Update(orderItem);
            if (orderItem != null)
            {
                return Ok(orderItem);
            }
            return BadRequest("Unable to update order item");
        }

        // DELETE api/<OrderItemsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var orderItem = await _repo.Delete(id);
            if (orderItem != null)
            {
                return Ok(orderItem);
            }
            return BadRequest("Unable to delete order item");
        }
    }
}
