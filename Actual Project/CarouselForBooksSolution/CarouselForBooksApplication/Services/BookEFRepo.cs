using CarouselForBooksApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Services
{
    public class BookEFRepo : IRepo<int, Book>
    {
        private readonly CFBDBContext _context;
        public BookEFRepo(CFBDBContext context)
        {
            _context = context;
        }
        public bool Add(Book t)
        {
            _context.Books.Add(t);
            throw new NotImplementedException();
        }

        public bool Delete(int k)
        {
            _context.Books.Remove(GetT(k));
            return SaveChanges();
        }

        public ICollection<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public Book GetT(int k)
        {
            return _context.Books.SingleOrDefault(b => b.Id == k);
        }

        public bool Update(Book t)
        {
            _context.Books.Update(t);
            return SaveChanges();
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
