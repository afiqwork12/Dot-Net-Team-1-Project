using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksAPI.Services
{
    public interface IOrder<K, T, U> : IRepo<K, T>
    {
        Task<IEnumerable<T>> GetOrdersByUsername(U username);
    }
}
