using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarouselForBooksApplication.Migrations
{
    public partial class stuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    UserId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "BookId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Fiction" },
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
                    { 58, null, "True crime" },
                    { 30, null, "Young adult" },
                    { 28, null, "Thriller" },
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
                    { 29, null, "Western" },
                    { 14, null, "Fantasy" },
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
                    { 15, null, "Graphic novel" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Dob", "Email", "Name", "Password", "Username" },
                values: new object[] { 1, new DateTime(2022, 2, 11, 10, 14, 46, 567, DateTimeKind.Local), "john123@gmail.com", "John Wick", "P@ssw0rd123", "john123" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Cost", "DatePosted", "Description", "GenreId", "IsSold", "Language", "Picture", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 22.2, new DateTime(2022, 2, 11, 10, 14, 46, 569, DateTimeKind.Local), "Description 1", null, false, "English", "/images/book1.jpg", "Title 1", 1 },
                    { 2, 22.2, new DateTime(2022, 2, 11, 10, 14, 46, 569, DateTimeKind.Local), "Description 2", null, false, "English", "/images/book2.jfif", "Title 2", 1 },
                    { 3, 22.2, new DateTime(2022, 2, 11, 10, 14, 46, 569, DateTimeKind.Local), "Description 3", null, false, "English", "/images/book3.jpg", "Title 3", 1 },
                    { 4, 22.2, new DateTime(2022, 2, 11, 10, 14, 46, 569, DateTimeKind.Local), "Description 4", null, false, "English", "/images/book4.jfif", "Title 4", 1 },
                    { 5, 22.2, new DateTime(2022, 2, 11, 10, 14, 46, 569, DateTimeKind.Local), "Description 5", null, false, "English", "/images/book5.png", "Title 5", 1 },
                    { 6, 22.2, new DateTime(2022, 2, 11, 10, 14, 46, 569, DateTimeKind.Local), "Description 6", null, false, "English", "/images/book6.jfif", "Title 6", 1 },
                    { 7, 22.2, new DateTime(2022, 2, 11, 10, 14, 46, 569, DateTimeKind.Local), "Description 7", null, false, "English", "/images/book7.jpg", "Title 7", 1 },
                    { 8, 22.2, new DateTime(2022, 2, 11, 10, 14, 46, 569, DateTimeKind.Local), "Description 8", null, false, "English", "/images/book8.jpg", "Title 8", 1 },
                    { 9, 22.2, new DateTime(2022, 2, 11, 10, 14, 46, 569, DateTimeKind.Local), "Description 9", null, false, "English", "/images/book9.jpg", "Title 9", 1 }
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
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_BookId",
                table: "Genres",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenres_Books_BookId",
                table: "BookGenres",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenres_Genres_GenreId",
                table: "BookGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Books_BookId",
                table: "Genres",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Books_BookId",
                table: "Genres");

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
