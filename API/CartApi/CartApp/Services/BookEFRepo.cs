using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarouselForBooksAPI.Models;

namespace CarouselForBooksAPI.Services
{
    public class BookEFRepo : IRepo<int, Book>
    {
        private readonly CFBDBContext _context;
        public BookEFRepo(CFBDBContext context)
        {
            _context = context;
        }
        public Book Add(Book t)
        {
            _context.Books.Add(t);
            if (SaveChanges())
            {
                return t;
            }
            return null;
        }

        public Book Delete(int k)
        {
            var book = GetT(k);
            if (book != null)
            {
                _context.Books.Remove(book);
                if (SaveChanges())
                {
                    return book;
                }
            }
            return null;
        }

        public ICollection<Book> GetAll()
        {
            var books = _context.Books.ToList();
            if (books.Count <= 0 || books == null)
            {
                return null;
            }
            else
            {
                return books;
            }
        }

        public Book GetT(int k)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == k);
            if (book != null)
            {
                return book;
            }
            return null;
        }

        public Book Update(Book t)
        {
            _context.Books.Update(t);
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
