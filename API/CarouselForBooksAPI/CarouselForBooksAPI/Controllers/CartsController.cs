using CarouselForBooksAPI.Models;
using CarouselForBooksAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartsController : ControllerBase
    {
        private readonly ICart<int, Cart, string> _repo;
        public CartsController(ICart<int, Cart, string> repo)
        {
            _repo = repo;
        }
        // GET: api/<CartsController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var carts = await _repo.GetAll();
            if (carts != null)
            {
                return Ok(carts);
            }
            return BadRequest("No Carts found");
        }

        // GET api/<CartsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var carts = await _repo.Get(id);
            if (carts != null)
            {
                return Ok(carts);
            }
            return BadRequest("No such Cart exist");
        }

        // GET api/<CartsController>/user/{username}
        [HttpGet("user/{username}")]
        public async Task<ActionResult> Get(string username)
        {
            var carts = await _repo.GetCartsByUsername(username);
            if (carts != null)
            {
                return Ok(carts);
            }
            return BadRequest("No such Cart exist");
        }

        // POST api/<CartsController>
        [HttpPost]
        public async Task<ActionResult> Post(Cart cart)
        {
            cart = await _repo.Add(cart);
            if (cart != null)
            {
                return Ok(cart);
            }
            return BadRequest("Unable to add cart");
        }

        // PUT api/<CartsController>
        [HttpPut]
        public async Task<ActionResult> Put(Cart cart)
        {
            cart = await _repo.Update(cart);
            if (cart != null)
            {
                return Ok(cart);
            }
            return BadRequest("Unable to update cart");
        }

        // DELETE api/<CartsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var cart = await _repo.Delete(id);
            if (cart != null)
            {
                return Ok(cart);
            }
            return BadRequest("Unable to delete cart");
        }
        // DELETE api/<CartsController>/5
        [HttpDelete("user/{username}")]
        public async Task<ActionResult> DeleteUserCarts(string username)
        {
            var cart = await _repo.DeleteUserCarts(username);
            if (cart != null)
            {
                return Ok(cart);
            }
            return BadRequest("Unable to delete user carts");
        }
    }
}
