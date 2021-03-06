using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Services
{
    public interface IOrderItem<K, T, OI> : IRepo<K, T>
    {
        Task<IEnumerable<T>> GetOrderItemsByOrderId(OI orderId);
    }
}
