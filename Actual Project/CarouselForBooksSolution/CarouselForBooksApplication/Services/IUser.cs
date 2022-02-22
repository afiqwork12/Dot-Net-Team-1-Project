using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Services
{
    public interface IUser<K, T> 
    {
        Task<T> Get(K key);
        Task<T> Add(T user);
        Task<T> Update(T user);
        Task<T> Login(T user);
    }
}
