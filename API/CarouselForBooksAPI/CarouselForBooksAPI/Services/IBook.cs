using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksAPI.Services
{
    public interface IBook<K, T, Q>
    {
        Task<T> Add(T item);
        Task<T> Update(T item);
        Task<T> Delete(K key);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Search(Q query);
        Task<IEnumerable<T>> Filter(Q query);
        Task<T> GetT(K key);
    }
}
