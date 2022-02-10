using CarouselForBooksApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Services
{
    public class CFBDBContext : DbContext
    {
        public CFBDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Username = "john123",
                    Password = "P@ssw0rd123",
                    Name = "John Wick",
                    Dob = DateTime.Now,
                    Email = "john123@gmail.com"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
