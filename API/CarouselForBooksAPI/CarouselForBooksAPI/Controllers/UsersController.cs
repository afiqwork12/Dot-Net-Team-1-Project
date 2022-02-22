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
    public class UsersController : ControllerBase
    {
        private readonly IManageUser<string, UserDTO> _repo;
        public UsersController(IManageUser<string, UserDTO> repo)
        {
            _repo = repo;
        }
        [HttpPost("Login")]
        public async Task<ActionResult> Login(UserDTO user)
        {
            var repouser = await _repo.Login(user);
            if (repouser != null)
            {
                return Ok(repouser);
            }
            return NotFound();
        }

        // GET api/<UsersController>/5
        [HttpGet("{username}")]
        public async Task<ActionResult> Get(string username)
        {
            var user = await _repo.Get(username);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        // POST api/<UsersController>
        [HttpPost]
        public async Task<ActionResult> Post(UserDTO user)
        {
            if (user.Password == user.ConfirmPassword)
            {
                var myuser = await _repo.Add(user);
                if (myuser != null)
                {
                    return Created("Created", myuser);
                }
                return BadRequest("Unable to create user");
            }
            return BadRequest("Password missmatch");
        }

        // PUT api/<UsersController>/5
        [HttpPut]
        public async Task<ActionResult> Put(UserDTO user)
        {
            user = await _repo.Update(user);
            if (user != null)
            {
                return Created("Updated", user);
            }
            return NotFound();
        }
    }
}
