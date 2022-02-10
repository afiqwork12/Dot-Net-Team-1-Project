using CarouselForBooksApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Services
{
    public class UserEFRepo : IRepo<int, User>
    {
        private readonly CFBDBContext _context;
        public UserEFRepo(CFBDBContext context)
        {
            _context = context;
        }
        public bool Add(User t)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int k)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetT(int k)
        {
            throw new NotImplementedException();
        }

        public bool Update(User t)
        {
            throw new NotImplementedException();
        }
    }
}
