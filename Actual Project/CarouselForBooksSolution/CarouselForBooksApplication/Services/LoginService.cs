using CarouselForBooksApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Services
{
    public class LoginService
    {
        private readonly IRepo<int, User> _repo;
        public LoginService(IRepo<int, User> repo)
        {
            _repo = repo;
        }
        public User LoginCheck(User user)
        {
            var repouser = _repo.GetAll().SingleOrDefault(u => u.Username == user.Username);
            if (repouser != null)
            {
                if (repouser.Password == user.Password)
                {
                    repouser.Password = null;
                    return repouser;
                }
            }
            return null;
        }
    }
}
