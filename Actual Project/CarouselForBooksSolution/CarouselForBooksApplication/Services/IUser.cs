using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Services
{
    public interface IUser<K, T> : IRepo<K, T>
    {
        Task<T> LoginCheck(T t);
    }
}
