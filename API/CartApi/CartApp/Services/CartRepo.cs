using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarouselForBooksAPI.Models;
using CarouselForBooksAPI.Services;

namespace CartApp.Services
{
    public class CartRepo : IRepo<int, Cart>//public class BookEFRepo : IRepo<int, Book>
    {
        private readonly CFBDBContext _context;
        public CartRepo(CFBDBContext context)
        {
            _context = context;
        }
        public Cart Add(Cart t)
        {
            _context.Carts.Add(t);
            if (SaveChanges())
            {
                return t;
            }
            return null;
        }

        public Cart Delete(int k)
        {
            var cart = GetT(k);
            if (cart != null)
            {
                _context.Carts.Remove(cart);
                if (SaveChanges())
                {
                    return cart;
                }
            }
            return null;
        }

        public ICollection<Cart> GetAll()
        {
            var cart = _context.Carts.ToList();
            if (cart.Count <= 0 || cart == null)
            {
                return null;
            }
            else
            {
                return cart;
            }
        }

        public Cart GetT(int k)
        {
            var cart = _context.Carts.SingleOrDefault(c => c.CartId == k);
            if (cart != null)
            {
                return cart;
            }
            return null;
        }

        public Cart Update(Cart t)
        {
            _context.Carts.Update(t);
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
