using CarouselForBooksAPI.Models;
using CarouselForBooksAPI.Services;
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
    public class BookGenresController : ControllerBase
    {
        private readonly IRepo<int, BookGenre> _repo;
        public BookGenresController(IRepo<int, BookGenre> repo)
        {
            _repo = repo;
        }
        // GET: api/<BookGenresController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var bookGenres = await _repo.GetAll();
            if (bookGenres != null)
            {
                return Ok(bookGenres);
            }
            return BadRequest("No Book Genres found");
        }

        // GET api/<BookGenresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var bookGenre = await _repo.Get(id);
            if (bookGenre != null)
            {
                return Ok(bookGenre);
            }
            return BadRequest("No such Book Genre");
        }

        // POST api/<BookGenresController>
        [HttpPost]
        public async Task<ActionResult> Post(BookGenre bookGenre)
        {
            bookGenre = await _repo.Add(bookGenre);
            if (bookGenre != null)
            {
                return Ok(bookGenre);
            }
            return BadRequest("Unable to add book genre");
        }

        // PUT api/<BookGenresController>/5
        [HttpPut]
        public async Task<ActionResult> Put(BookGenre bookGenre)
        {
            bookGenre = await _repo.Update(bookGenre);
            if (bookGenre != null)
            {
                return Ok(bookGenre);
            }
            return BadRequest("Unable to update book genre");
        }

        // DELETE api/<BookGenresController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var bookGenre = await _repo.Delete(id);
            if (bookGenre != null)
            {
                return Ok(bookGenre);
            }
            return BadRequest("Unable to delete book genre");
        }
    }
}
