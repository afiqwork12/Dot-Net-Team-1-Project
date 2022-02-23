using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarouselForBooksAPI.Models;
using CarouselForBooksAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarouselForBooksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IRepo<int, Book> _repo;
        public BooksController(IRepo<int, Book> repo)
        {
            _repo = repo;
        }
        // GET: api/<BooksController>
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            var books = _repo.GetAll();
            if (books != null)
            {
                return Ok(books);
            }
            return BadRequest("No Books found");
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var book = _repo.GetT(id);
            if (book != null)
            {
                return Ok(book);
            }
            return NotFound();
        }

        // POST api/<BooksController>
        [HttpPost]
        public ActionResult<Book> Post(Book book)
        {
            var mybook = _repo.Add(book);
            if (mybook != null)
            {
                return Created("Created", mybook);
            }
            return BadRequest("Unable to create book");
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public ActionResult<Book> Put(int id, Book book)
        {
            book = _repo.Update(book);
            if (book != null)
            {
                return Created("Updated", book);
            }
            return NotFound();
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public ActionResult<Book> Delete(int id)
        {
            var book = _repo.Delete(id);
            if (book != null)
            {
                return Ok(book);
            }
            return NotFound();
        }
    }
}
