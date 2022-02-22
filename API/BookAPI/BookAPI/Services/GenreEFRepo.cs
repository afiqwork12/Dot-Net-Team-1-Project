using BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Services
{
    public class GenreEFRepo : IRepo<int, Genre, string>
    {
        private readonly BookAPIContext _context;
        public GenreEFRepo(BookAPIContext context)
        {
            _context = context;
        }
        public async Task<Genre> Add(Genre item)
        {
            await _context.Genres.AddAsync(item);
            if (await SaveChanges())
            {
                return item;
            }
            return null;
        }

        public async Task<Genre> Delete(int key)
        {
            var item = await GetT(key);
            if (item != null)
            {
                _context.Genres.Remove(item);
                if (await SaveChanges())
                {
                    return item;
                }
            }
            return null;
        }

        public async Task<IEnumerable<Genre>> GetAll()
        {
            return _context.Genres;
        }

        public async Task<Genre> GetT(int key)
        {
            return _context.Genres.SingleOrDefault(g => g.Id == key);
        }

        public async Task<Genre> Update(Genre item)
        {
            _context.Genres.Update(item);
            if (await SaveChanges())
            {
                return item;
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

        public Task<IEnumerable<Genre>> Search(string query)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Genre>> Filter(string query)
        {
            throw new NotImplementedException();
        }
    }
}
