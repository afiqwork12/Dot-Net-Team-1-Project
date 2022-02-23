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
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookGenre>().HasKey(bg => new { bg.BookId, bg.GenreId });
            modelBuilder.Entity<Cart>().HasKey(c => new { c.BookId, c.Username });
            //modelBuilder.Entity<Book>().HasMany(book => book.Genres);
            //modelBuilder.Entity<Genre>().HasMany(genre => genre.Books);
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Username = "john123",
                    Password = "P@ssw0rd123",
                    Name = "John Wick",
                    Dob = DateTime.Now,
                    Email = "john123@gmail.com",
                    Role = "user"
                }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book() { Id = 1, Title = "Title 1", Description = "Description 1", Language = "English", Cost = 22.2, Picture = "/images/book1.jpg"},
                new Book() { Id = 2, Title = "Title 2", Description = "Description 2", Language = "English", Cost = 22.2, Picture = "/images/book2.jfif"},
                new Book() { Id = 3, Title = "Title 3", Description = "Description 3", Language = "English", Cost = 22.2, Picture = "/images/book3.jpg"},
                new Book() { Id = 4, Title = "Title 4", Description = "Description 4", Language = "English", Cost = 22.2, Picture = "/images/book4.jfif"},
                new Book() { Id = 5, Title = "Title 5", Description = "Description 5", Language = "English", Cost = 22.2, Picture = "/images/book5.png"},
                new Book() { Id = 6, Title = "Title 6", Description = "Description 6", Language = "English", Cost = 22.2, Picture = "/images/book6.jfif"},
                new Book() { Id = 7, Title = "Title 7", Description = "Description 7", Language = "English", Cost = 22.2, Picture = "/images/book7.jpg"},
                new Book() { Id = 8, Title = "Title 8", Description = "Description 8", Language = "English", Cost = 22.2, Picture = "/images/book8.jpg"},
                new Book() { Id = 9, Title = "Title 9", Description = "Description 9", Language = "English", Cost = 22.2, Picture = "/images/book9.jpg"}
            );
            modelBuilder.Entity<Genre>().HasData(
                new Genre() { Id = 1, Name = "Fiction" },
                new Genre() { Id = 2, Name = "Nonfiction" },
                new Genre() { Id = 3, Name = "Action and adventure" },
                new Genre() { Id = 4, Name = "Alternate history" },
                new Genre() { Id = 5, Name = "Anthology" },
                new Genre() { Id = 6, Name = "Chick lit" },
                new Genre() { Id = 7, Name = "Children's" },
                new Genre() { Id = 8, Name = "Classic" },
                new Genre() { Id = 9, Name = "Comic book" },
                new Genre() { Id = 10, Name = "Coming-of-age" },
                new Genre() { Id = 11, Name = "Crime" },
                new Genre() { Id = 12, Name = "Drama" },
                new Genre() { Id = 13, Name = "Fairytale" },
                new Genre() { Id = 14, Name = "Fantasy" },
                new Genre() { Id = 15, Name = "Graphic novel" },
                new Genre() { Id = 16, Name = "Historical fiction" },
                new Genre() { Id = 17, Name = "Horror" },
                new Genre() { Id = 18, Name = "Mystery" },
                new Genre() { Id = 19, Name = "Paranormal romance" },
                new Genre() { Id = 20, Name = "Picture book" },
                new Genre() { Id = 21, Name = "Poetry" },
                new Genre() { Id = 22, Name = "Political thriller" },
                new Genre() { Id = 23, Name = "Romance" },
                new Genre() { Id = 24, Name = "Satire" },
                new Genre() { Id = 25, Name = "Science fiction" },
                new Genre() { Id = 26, Name = "Short story" },
                new Genre() { Id = 27, Name = "Suspense" },
                new Genre() { Id = 28, Name = "Thriller" },
                new Genre() { Id = 29, Name = "Western" },
                new Genre() { Id = 30, Name = "Young adult" },
                new Genre() { Id = 31, Name = "Art/architecture" },
                new Genre() { Id = 32, Name = "Autobiography" },
                new Genre() { Id = 33, Name = "Biography" },
                new Genre() { Id = 34, Name = "Business/economics" },
                new Genre() { Id = 35, Name = "Crafts/hobbies" },
                new Genre() { Id = 36, Name = "Cookbook" },
                new Genre() { Id = 37, Name = "Diary" },
                new Genre() { Id = 38, Name = "Dictionary" },
                new Genre() { Id = 39, Name = "Encyclopedia" },
                new Genre() { Id = 40, Name = "Guide" },
                new Genre() { Id = 41, Name = "Health/fitness" },
                new Genre() { Id = 42, Name = "History" },
                new Genre() { Id = 43, Name = "Home and garden" },
                new Genre() { Id = 44, Name = "Humor" },
                new Genre() { Id = 45, Name = "Journal" },
                new Genre() { Id = 46, Name = "Math" },
                new Genre() { Id = 47, Name = "Memoir" },
                new Genre() { Id = 48, Name = "Philosophy" },
                new Genre() { Id = 49, Name = "Prayer" },
                new Genre() { Id = 50, Name = "Religion, spirituality, and new age" },
                new Genre() { Id = 51, Name = "Textbook" },
                new Genre() { Id = 52, Name = "True crime" },
                new Genre() { Id = 53, Name = "Review" },
                new Genre() { Id = 54, Name = "Science" },
                new Genre() { Id = 55, Name = "Self help" },
                new Genre() { Id = 56, Name = "Sports and leisure" },
                new Genre() { Id = 57, Name = "Travel" },
                new Genre() { Id = 58, Name = "True crime" }
            );
            modelBuilder.Entity<BookGenre>().HasData(
                new BookGenre() { BookId = 1, GenreId = 1 }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
