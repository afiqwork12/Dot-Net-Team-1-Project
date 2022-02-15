using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarouselForBooksApplication.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Picture = table.Column<string>(nullable: true),
                    IsSold = table.Column<bool>(nullable: false),
                    DatePosted = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookGenres",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenres", x => new { x.BookId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_BookGenres_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 32, "Autobiography" },
                    { 33, "Biography" },
                    { 34, "Business/economics" },
                    { 35, "Crafts/hobbies" },
                    { 36, "Cookbook" },
                    { 37, "Diary" },
                    { 38, "Dictionary" },
                    { 39, "Encyclopedia" },
                    { 40, "Guide" },
                    { 41, "Health/fitness" },
                    { 42, "History" },
                    { 43, "Home and garden" },
                    { 31, "Art/architecture" },
                    { 44, "Humor" },
                    { 46, "Math" },
                    { 47, "Memoir" },
                    { 48, "Philosophy" },
                    { 49, "Prayer" },
                    { 50, "Religion, spirituality, and new age" },
                    { 51, "Textbook" },
                    { 52, "True crime" },
                    { 53, "Review" },
                    { 54, "Science" },
                    { 55, "Self help" },
                    { 56, "Sports and leisure" },
                    { 57, "Travel" },
                    { 45, "Journal" },
                    { 58, "True crime" },
                    { 30, "Young adult" },
                    { 28, "Thriller" },
                    { 2, "Nonfiction" },
                    { 3, "Action and adventure" },
                    { 4, "Alternate history" },
                    { 5, "Anthology" },
                    { 6, "Chick lit" },
                    { 7, "Children's" },
                    { 8, "Classic" },
                    { 9, "Comic book" },
                    { 10, "Coming-of-age" },
                    { 11, "Crime" },
                    { 12, "Drama" },
                    { 13, "Fairytale" },
                    { 29, "Western" },
                    { 14, "Fantasy" },
                    { 16, "Historical fiction" },
                    { 17, "Horror" },
                    { 18, "Mystery" },
                    { 19, "Paranormal romance" },
                    { 20, "Picture book" },
                    { 21, "Poetry" },
                    { 22, "Political thriller" },
                    { 23, "Romance" },
                    { 24, "Satire" },
                    { 25, "Science fiction" },
                    { 26, "Short story" },
                    { 27, "Suspense" },
                    { 15, "Graphic novel" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Dob", "Email", "Name", "Password", "Username" },
                values: new object[] { 1, new DateTime(2022, 2, 15, 15, 2, 41, 62, DateTimeKind.Local), "john123@gmail.com", "John Wick", "P@ssw0rd123", "john123" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Cost", "DatePosted", "Description", "IsSold", "Language", "Picture", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 22.2, new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), "Description 1", false, "English", "/images/book1.jpg", "Title 1", 1 },
                    { 2, 22.2, new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), "Description 2", false, "English", "/images/book2.jfif", "Title 2", 1 },
                    { 3, 22.2, new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), "Description 3", false, "English", "/images/book3.jpg", "Title 3", 1 },
                    { 4, 22.2, new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), "Description 4", false, "English", "/images/book4.jfif", "Title 4", 1 },
                    { 5, 22.2, new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), "Description 5", false, "English", "/images/book5.png", "Title 5", 1 },
                    { 6, 22.2, new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), "Description 6", false, "English", "/images/book6.jfif", "Title 6", 1 },
                    { 7, 22.2, new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), "Description 7", false, "English", "/images/book7.jpg", "Title 7", 1 },
                    { 8, 22.2, new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), "Description 8", false, "English", "/images/book8.jpg", "Title 8", 1 },
                    { 9, 22.2, new DateTime(2022, 2, 15, 15, 2, 41, 74, DateTimeKind.Local), "Description 9", false, "English", "/images/book9.jpg", "Title 9", 1 }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookId", "GenreId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_GenreId",
                table: "BookGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenres");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
