using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarouselForBooksAPI.Models;
using CarouselForBooksAPI.Services;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarouselForBooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BooksController : ControllerBase
    {
        private readonly IBook<int, Book, string> _repo;
        public BooksController(IBook<int, Book, string> repo)
        {
            _repo = repo;
        }
        // GET: api/<BooksController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var books = await  _repo.GetAll();
            if (books != null)
            {
                return Ok(books);
            }
            return BadRequest("No Books found");
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var book = await _repo.GetT(id);
            if (book != null)
            {
                return Ok(book);
            }
            return NotFound();
        }

        [HttpGet("search/{query}")]
        public async Task<ActionResult> Search(string query)
        {
            var book = await _repo.Search(query);
            if (book != null)
            {
                return Ok(book);
            }
            return NotFound();
        }

        [HttpGet("filter/{query}")]
        public async Task<ActionResult> Filter(string query)
        {
            var book = await _repo.Filter(query);
            if (book != null)
            {
                return Ok(book);
            }
            return NotFound();
        }

        // POST api/<BooksController>
        [HttpPost]
        public async Task<ActionResult> Post(Book book)
        {
            var mybook = await _repo.Add(book);
            if (mybook != null)
            {
                return Created("Created", mybook);
            }
            return BadRequest("Unable to create book");
        }

        // PUT api/<BooksController>/5
        [HttpPut]
        public async Task<ActionResult> Put(Book book)
        {
            book = await _repo.Update(book);
            if (book != null)
            {
                return Created("Updated", book);
            }
            return NotFound();
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var book = await _repo.Delete(id);
            if (book != null)
            {
                return Ok(book);
            }
            return NotFound();
        }
    }
}
