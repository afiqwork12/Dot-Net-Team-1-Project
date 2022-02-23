using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksAPI.Services
{
    public interface IRepo<K, T>
    {
        T Add(T t);
        T Update(T t);
        T Delete(K k);
        ICollection<T> GetAll();
        T GetT(K k);
    }
}
