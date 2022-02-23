using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksAPI.Services
{
    public interface ICart<K, T, U> : IRepo<K, T>
    {
        Task<IEnumerable<T>> GetCartsByUsername(U username);
    }
}
