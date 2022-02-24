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
    public class OrdersController : ControllerBase
    {
        private readonly IOrder<int, Order, string> _repo;
        public OrdersController(IOrder<int, Order, string> repo)
        {
            _repo = repo;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var orders = await _repo.GetAll();
            if (orders != null)
            {
                return Ok(orders);
            }
            return BadRequest("No orders found");
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var order = await _repo.Get(id);
            if (order != null)
            {
                return Ok(order);
            }
            return BadRequest("No such order exist");
        }
        [HttpGet("user/{username}")]
        public async Task<ActionResult> GetOrderByUsername(string username)
        {
            var orders = await _repo.GetOrdersByUsername(username);
            if (orders != null)
            {
                return Ok(orders);
            }
            return BadRequest("No such orders exist");
        }

        // POST api/<OrdersController>
        [HttpPost]
        public async Task<ActionResult> Post(Order order)
        {
            order = await _repo.Add(order);
            if (order != null)
            {
                return Ok(order);
            }
            return BadRequest("Unable to add order");
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Order order)
        {
            order = await _repo.Update(order);
            if (order != null)
            {
                return Ok(order);
            }
            return BadRequest("Unable to update order");
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var order = await _repo.Delete(id);
            if (order != null)
            {
                return Ok(order);
            }
            return BadRequest("Unable to delete order");
        }
    }
}
