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
    public class GenresController : ControllerBase
    {
        private readonly IRepo<int, Genre> _repo;
        public GenresController(IRepo<int, Genre> repo)
        {
            _repo = repo;
        }
        // GET: api/<GenresController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var genres = await _repo.GetAll();
            if (genres != null)
            {
                return Ok(genres);
            }
            return BadRequest("No Genres found");
        }

        // GET api/<GenresController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var genre = await _repo.Get(id);
            if (genre != null)
            {
                return Ok(genre);
            }
            return BadRequest("No such Genre");
        }

        // POST api/<GenresController>
        [HttpPost]
        public async Task<ActionResult> Post(Genre genre)
        {
            genre = await _repo.Add(genre);
            if (genre != null)
            {
                return Ok(genre);
            }
            return BadRequest("Unable to add genre");
        }

        // PUT api/<GenresController>/5
        [HttpPut]
        public async Task<ActionResult> Put(Genre genre)
        {
            genre = await _repo.Update(genre);
            if (genre != null)
            {
                return Ok(genre);
            }
            return BadRequest("Unable to update genre");
        }

        // DELETE api/<GenresController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var genre = await _repo.Delete(id);
            if (genre != null)
            {
                return Ok(genre);
            }
            return BadRequest("Unable to delete genre");
        }
    }
}
