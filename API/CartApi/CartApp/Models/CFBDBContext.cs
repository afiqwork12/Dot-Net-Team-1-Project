using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarouselForBooksAPI.Models
{
    public class CFBDBContext : DbContext
    {
        public CFBDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cart> Carts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>().HasData(
                new Cart() {CartId = 1,BookId = 1, Username = "afiq123", Quantity = 2 },
                new Cart() { CartId = 2, BookId = 2, Username = "afiq123", Quantity = 3 }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
