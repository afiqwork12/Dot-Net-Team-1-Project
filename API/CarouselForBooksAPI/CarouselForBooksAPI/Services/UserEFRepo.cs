using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarouselForBooksAPI.Models;

namespace CarouselForBooksAPI.Services
{
    public class UserEFRepo : IRepo<string, User>
    {
        private readonly CFBDBContext _context;
        public UserEFRepo(CFBDBContext context)
        {
            _context = context;
        }
        public User Add(User t)
        {
            _context.Users.Add(t);
            if (SaveChanges())
            {
                return t;
            }
            return null;
        }

        public User Delete(string k)
        {
            var user = GetT(k);
            if (user != null)
            {
                _context.Users.Remove(user);
                if (SaveChanges())
                {
                    return user;
                }
            }
            return null;
        }

        public ICollection<User> GetAll()
        {
            var users = _context.Users.ToList();
            if (users.Count <= 0 || users == null)
            {
                return null;
            }
            else
            {
                return users;
            }
        }

        public User GetT(string k)
        {
            var user = _context.Users.SingleOrDefault(b => b.Username == k);
            if (user != null)
            {
                return user;
            }
            return null;
        }

        public User Update(User t)
        {
            _context.Users.Update(t);
            if (SaveChanges())
            {
                return t;
            }
            return null;
        }
        private bool SaveChanges()
        {
            if (_context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

    }
}
