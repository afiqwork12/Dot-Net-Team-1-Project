﻿// <auto-generated />
using System;
using CarouselForBooksApplication.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarouselForBooksApplication.Migrations
{
    [DbContext(typeof(CFBDBContext))]
    partial class CFBDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarouselForBooksApplication.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cost");

                    b.Property<DateTime>("DatePosted");

                    b.Property<string>("Description");

                    b.Property<bool>("IsSold");

                    b.Property<string>("Language");

                    b.Property<string>("Picture");

                    b.Property<string>("Title");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Books");

                    b.HasData(
                        new { Id = 1, Cost = 22.2, DatePosted = new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), Description = "Description 1", IsSold = false, Language = "English", Picture = "/images/book1.jpg", Title = "Title 1", UserId = 1 },
                        new { Id = 2, Cost = 22.2, DatePosted = new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), Description = "Description 2", IsSold = false, Language = "English", Picture = "/images/book2.jfif", Title = "Title 2", UserId = 1 },
                        new { Id = 3, Cost = 22.2, DatePosted = new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), Description = "Description 3", IsSold = false, Language = "English", Picture = "/images/book3.jpg", Title = "Title 3", UserId = 1 },
                        new { Id = 4, Cost = 22.2, DatePosted = new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), Description = "Description 4", IsSold = false, Language = "English", Picture = "/images/book4.jfif", Title = "Title 4", UserId = 1 },
                        new { Id = 5, Cost = 22.2, DatePosted = new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), Description = "Description 5", IsSold = false, Language = "English", Picture = "/images/book5.png", Title = "Title 5", UserId = 1 },
                        new { Id = 6, Cost = 22.2, DatePosted = new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), Description = "Description 6", IsSold = false, Language = "English", Picture = "/images/book6.jfif", Title = "Title 6", UserId = 1 },
                        new { Id = 7, Cost = 22.2, DatePosted = new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), Description = "Description 7", IsSold = false, Language = "English", Picture = "/images/book7.jpg", Title = "Title 7", UserId = 1 },
                        new { Id = 8, Cost = 22.2, DatePosted = new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), Description = "Description 8", IsSold = false, Language = "English", Picture = "/images/book8.jpg", Title = "Title 8", UserId = 1 },
                        new { Id = 9, Cost = 22.2, DatePosted = new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), Description = "Description 9", IsSold = false, Language = "English", Picture = "/images/book9.jpg", Title = "Title 9", UserId = 1 }
                    );
                });

            modelBuilder.Entity("CarouselForBooksApplication.Models.BookGenre", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("GenreId");

                    b.HasKey("BookId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("BookGenres");

                    b.HasData(
                        new { BookId = 1, GenreId = 1 }
                    );
                });

            modelBuilder.Entity("CarouselForBooksApplication.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new { Id = 1, Name = "Fiction" },
                        new { Id = 2, Name = "Nonfiction" },
                        new { Id = 3, Name = "Action and adventure" },
                        new { Id = 4, Name = "Alternate history" },
                        new { Id = 5, Name = "Anthology" },
                        new { Id = 6, Name = "Chick lit" },
                        new { Id = 7, Name = "Children's" },
                        new { Id = 8, Name = "Classic" },
                        new { Id = 9, Name = "Comic book" },
                        new { Id = 10, Name = "Coming-of-age" },
                        new { Id = 11, Name = "Crime" },
                        new { Id = 12, Name = "Drama" },
                        new { Id = 13, Name = "Fairytale" },
                        new { Id = 14, Name = "Fantasy" },
                        new { Id = 15, Name = "Graphic novel" },
                        new { Id = 16, Name = "Historical fiction" },
                        new { Id = 17, Name = "Horror" },
                        new { Id = 18, Name = "Mystery" },
                        new { Id = 19, Name = "Paranormal romance" },
                        new { Id = 20, Name = "Picture book" },
                        new { Id = 21, Name = "Poetry" },
                        new { Id = 22, Name = "Political thriller" },
                        new { Id = 23, Name = "Romance" },
                        new { Id = 24, Name = "Satire" },
                        new { Id = 25, Name = "Science fiction" },
                        new { Id = 26, Name = "Short story" },
                        new { Id = 27, Name = "Suspense" },
                        new { Id = 28, Name = "Thriller" },
                        new { Id = 29, Name = "Western" },
                        new { Id = 30, Name = "Young adult" },
                        new { Id = 31, Name = "Art/architecture" },
                        new { Id = 32, Name = "Autobiography" },
                        new { Id = 33, Name = "Biography" },
                        new { Id = 34, Name = "Business/economics" },
                        new { Id = 35, Name = "Crafts/hobbies" },
                        new { Id = 36, Name = "Cookbook" },
                        new { Id = 37, Name = "Diary" },
                        new { Id = 38, Name = "Dictionary" },
                        new { Id = 39, Name = "Encyclopedia" },
                        new { Id = 40, Name = "Guide" },
                        new { Id = 41, Name = "Health/fitness" },
                        new { Id = 42, Name = "History" },
                        new { Id = 43, Name = "Home and garden" },
                        new { Id = 44, Name = "Humor" },
                        new { Id = 45, Name = "Journal" },
                        new { Id = 46, Name = "Math" },
                        new { Id = 47, Name = "Memoir" },
                        new { Id = 48, Name = "Philosophy" },
                        new { Id = 49, Name = "Prayer" },
                        new { Id = 50, Name = "Religion, spirituality, and new age" },
                        new { Id = 51, Name = "Textbook" },
                        new { Id = 52, Name = "True crime" },
                        new { Id = 53, Name = "Review" },
                        new { Id = 54, Name = "Science" },
                        new { Id = 55, Name = "Self help" },
                        new { Id = 56, Name = "Sports and leisure" },
                        new { Id = 57, Name = "Travel" },
                        new { Id = 58, Name = "True crime" }
                    );
                });

            modelBuilder.Entity("CarouselForBooksApplication.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dob");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Dob = new DateTime(2022, 2, 15, 15, 2, 41, 62, DateTimeKind.Local), Email = "john123@gmail.com", Name = "John Wick", Password = "P@ssw0rd123", Username = "john123" }
                    );
                });

            modelBuilder.Entity("CarouselForBooksApplication.Models.Book", b =>
                {
                    b.HasOne("CarouselForBooksApplication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarouselForBooksApplication.Models.BookGenre", b =>
                {
                    b.HasOne("CarouselForBooksApplication.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarouselForBooksApplication.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
