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
            _context.Users.Add(t);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int k)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetAll()
        {
            return _context.Users.ToList();
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
