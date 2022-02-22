using BookAPI.Models;
using BookAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IRepo<int, Book, string> _repo;
        public BookController(IRepo<int, Book, string> repo)
        {
            _repo = repo;
        }
        // GET: api/<BookController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var books = await _repo.GetAll();
            if (books != null)
            {
                return Ok(books);
            }
            return BadRequest("No Books found");
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var book = await _repo.GetT(id);
            if (book != null)
            {
                return Ok(book);
            }
            return BadRequest("No such book exist");
        }

        [HttpGet("search/{query}")]
        public async Task<ActionResult> Search(string query)
        {
            var books = await _repo.Search(query);
            if (books != null)
            {
                return Ok(books);
            }
            return BadRequest("No such book exist");
        }

        [HttpGet("filter/{query}")]
        public async Task<ActionResult> Filter(string query)
        {
            var books = await _repo.Filter(query);
            if (books != null)
            {
                return Ok(books);
            }
            return BadRequest("No such book exist");
        }

        // POST api/<BookController>
        [HttpPost]
        public async Task<ActionResult> Post(Book book)
        {
            book = await _repo.Add(book);
            if (book != null)
            {
                return Ok(book);
            }
            return BadRequest("Unable to add book");
        }

        // PUT api/<BookController>/5
        [HttpPut]
        public async Task<ActionResult> Put(Book book)
        {
            book = await _repo.Update(book);
            if (book != null)
            {
                return Ok(book);
            }
            return BadRequest("Unable to update book");
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var book = await _repo.Delete(id);
            if (book != null)
            {
                return Ok(book);
            }
            return BadRequest("Unable to delete book");
        }
    }
}
