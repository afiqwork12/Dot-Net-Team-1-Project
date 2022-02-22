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
    public class UsersController : ControllerBase
    {
        private readonly IRepo<string, User> _repo;
        public UsersController(IRepo<string, User> repo)
        {
            _repo = repo;
        }
        [HttpPost("LoginCheck/{username}")]
        public ActionResult<User> LoginCheck(User user)
        {
            var repouser = _repo.GetT(user.Username);
            if (repouser != null)
            {
                if (repouser.Password == user.Password)
                {
                    repouser.Password = null;
                    return Ok(repouser);
                }
            }
            return NotFound();
        }
        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            var users = _repo.GetAll();
            if (users != null)
            {
                return Ok(users);
            }
            return BadRequest("No Books found");
        }

        // GET api/<UsersController>/5
        [HttpGet("{username}")]
        public ActionResult<User> Get(string username)
        {
            var user = _repo.GetT(username);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<User> Post(User user)
        {
            var myuser = _repo.Add(user);
            if (myuser != null)
            {
                return Created("Created", myuser);
            }
            return BadRequest("Unable to create user");
        }

        // PUT api/<UsersController>/5
        [HttpPut("{username}")]
        public ActionResult<User> Put(User user)
        {
            user = _repo.Update(user);
            if (user != null)
            {
                return Created("Updated", user);
            }
            return NotFound();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{username}")]
        public ActionResult<User> Delete(string username)
        {
            var user = _repo.Delete(username);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }
    }
}
