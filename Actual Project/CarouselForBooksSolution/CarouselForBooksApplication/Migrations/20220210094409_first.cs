using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarouselForBooksApplication.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genres_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookId", "GenreId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "BookId", "Name" },
                values: new object[,]
                {
                    { 32, null, "Autobiography" },
                    { 33, null, "Biography" },
                    { 34, null, "Business/economics" },
                    { 35, null, "Crafts/hobbies" },
                    { 36, null, "Cookbook" },
                    { 37, null, "Diary" },
                    { 38, null, "Dictionary" },
                    { 39, null, "Encyclopedia" },
                    { 40, null, "Guide" },
                    { 41, null, "Health/fitness" },
                    { 42, null, "History" },
                    { 43, null, "Home and garden" },
                    { 31, null, "Art/architecture" },
                    { 44, null, "Humor" },
                    { 46, null, "Math" },
                    { 47, null, "Memoir" },
                    { 48, null, "Philosophy" },
                    { 49, null, "Prayer" },
                    { 50, null, "Religion, spirituality, and new age" },
                    { 51, null, "Textbook" },
                    { 52, null, "True crime" },
                    { 53, null, "Review" },
                    { 54, null, "Science" },
                    { 55, null, "Self help" },
                    { 56, null, "Sports and leisure" },
                    { 57, null, "Travel" },
                    { 45, null, "Journal" },
                    { 30, null, "Young adult" },
                    { 29, null, "Western" },
                    { 28, null, "Thriller" },
                    { 1, null, "Fiction" },
                    { 2, null, "Nonfiction" },
                    { 3, null, "Action and adventure" },
                    { 4, null, "Alternate history" },
                    { 5, null, "Anthology" },
                    { 6, null, "Chick lit" },
                    { 7, null, "Children's" },
                    { 8, null, "Classic" },
                    { 9, null, "Comic book" },
                    { 10, null, "Coming-of-age" },
                    { 11, null, "Crime" },
                    { 12, null, "Drama" },
                    { 13, null, "Fairytale" },
                    { 14, null, "Fantasy" },
                    { 15, null, "Graphic novel" },
                    { 16, null, "Historical fiction" },
                    { 17, null, "Horror" },
                    { 18, null, "Mystery" },
                    { 19, null, "Paranormal romance" },
                    { 20, null, "Picture book" },
                    { 21, null, "Poetry" },
                    { 22, null, "Political thriller" },
                    { 23, null, "Romance" },
                    { 24, null, "Satire" },
                    { 25, null, "Science fiction" },
                    { 26, null, "Short story" },
                    { 27, null, "Suspense" },
                    { 58, null, "True crime" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Dob", "Email", "Name", "Password", "Username" },
                values: new object[] { 1, new DateTime(2022, 2, 10, 17, 44, 9, 200, DateTimeKind.Local), "john123@gmail.com", "John Wick", "P@ssw0rd123", "john123" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Cost", "DatePosted", "Description", "IsSold", "Language", "Picture", "Title", "UserId" },
                values: new object[] { 1, 22.2, new DateTime(2022, 2, 10, 17, 44, 9, 202, DateTimeKind.Local), "Description 1", false, "English", "/images/book1.jpg", "Title 1", 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Cost", "DatePosted", "Description", "IsSold", "Language", "Picture", "Title", "UserId" },
                values: new object[] { 2, 22.2, new DateTime(2022, 2, 10, 17, 44, 9, 202, DateTimeKind.Local), "Description 2", false, "English", "/images/book2.jfif", "Title 2", 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Cost", "DatePosted", "Description", "IsSold", "Language", "Picture", "Title", "UserId" },
                values: new object[] { 3, 22.2, new DateTime(2022, 2, 10, 17, 44, 9, 202, DateTimeKind.Local), "Description 3", false, "English", "/images/book3.jpg", "Title 3", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_BookId",
                table: "Genres",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenres");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
