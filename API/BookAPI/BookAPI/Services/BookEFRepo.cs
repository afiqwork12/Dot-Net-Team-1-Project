using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Services
{
    public class BookEFRepo : IRepo<int, Book, string>
    {
        private readonly BookAPIContext _context;
        public BookEFRepo(BookAPIContext context)
        {
            _context = context;
        }
        public async Task<Book> Add(Book item)
        {
            await _context.Books.AddAsync(item);
            if (await SaveChanges())
            {
                return item;
            }
            return null;
        }

        public async Task<Book> Delete(int key)
        {
            var item = await GetT(key);
            if (item != null)
            {
                _context.Books.Remove(item);
                if (await SaveChanges())
                {
                    return item;
                }
            }
            return null;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            return _context.Books;
        }

        public async Task<Book> GetT(int key)
        {
            return _context.Books.SingleOrDefault(b => b.Id == key);
        }

        public async Task<Book> Update(Book item)
        {
            _context.Books.Update(item);
            if (await SaveChanges())
            {
                return item;
            }
            return null;
        }
        public async Task<IEnumerable<Book>> Search(string query)
        {
            var books = _context.Books.Where(b => (b.Title + "," + b.Description + "," + b.Language).Contains(query)).ToList();
            if (books != null)
            {
                return books;
            }
            return null;
        }
        public async Task<bool> SaveChanges()
        {
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Book>> Filter(string query)
        {
            var genres = _context.Genres.Where(g => query.Contains(g.Name)).Select(g => g.Id).ToList();
            if (genres != null)
            {
                var bookGenres = _context.BookGenres.Where(bg => genres.Contains(bg.GenreId)).Select(bg => bg.BookId).ToList();
                if (bookGenres != null)
                {
                    var books = _context.Books.Where(b => bookGenres.Contains(b.Id)).ToList();
                    if (books != null)
                    {
                        return books;
                    }
                }
            }
            return null;
        }
    }
}
