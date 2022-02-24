using Microsoft.EntityFrameworkCore;

namespace OrderAPI.Models
{
    public class OrderAPIContext : DbContext
    {
        public OrderAPIContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
