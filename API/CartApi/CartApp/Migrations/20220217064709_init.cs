using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarouselForBooksAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Cost = table.Column<double>(nullable: false),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
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

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.BookId, x.Username });
                    table.ForeignKey(
                        name: "FK_Carts_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    DateOrdered = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Cost", "Description", "Language", "Picture", "Title" },
                values: new object[,]
                {
                    { 1, 22.199999999999999, "Description 1", "English", "/images/book1.jpg", "Title 1" },
                    { 2, 22.199999999999999, "Description 2", "English", "/images/book2.jfif", "Title 2" },
                    { 3, 22.199999999999999, "Description 3", "English", "/images/book3.jpg", "Title 3" },
                    { 4, 22.199999999999999, "Description 4", "English", "/images/book4.jfif", "Title 4" },
                    { 5, 22.199999999999999, "Description 5", "English", "/images/book5.png", "Title 5" },
                    { 6, 22.199999999999999, "Description 6", "English", "/images/book6.jfif", "Title 6" },
                    { 7, 22.199999999999999, "Description 7", "English", "/images/book7.jpg", "Title 7" },
                    { 8, 22.199999999999999, "Description 8", "English", "/images/book8.jpg", "Title 8" },
                    { 9, 22.199999999999999, "Description 9", "English", "/images/book9.jpg", "Title 9" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 42, "History" },
                    { 41, "Health/fitness" },
                    { 40, "Guide" },
                    { 39, "Encyclopedia" },
                    { 38, "Dictionary" },
                    { 33, "Biography" },
                    { 36, "Cookbook" },
                    { 35, "Crafts/hobbies" },
                    { 34, "Business/economics" },
                    { 43, "Home and garden" },
                    { 32, "Autobiography" },
                    { 37, "Diary" },
                    { 44, "Humor" },
                    { 48, "Philosophy" },
                    { 46, "Math" },
                    { 47, "Memoir" },
                    { 31, "Art/architecture" },
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
                    { 30, "Young adult" },
                    { 25, "Science fiction" },
                    { 28, "Thriller" },
                    { 1, "Fiction" },
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
                    { 14, "Fantasy" },
                    { 15, "Graphic novel" },
                    { 16, "Historical fiction" },
                    { 17, "Horror" },
                    { 18, "Mystery" },
                    { 19, "Paranormal romance" },
                    { 20, "Picture book" },
                    { 21, "Poetry" },
                    { 22, "Political thriller" },
                    { 23, "Romance" },
                    { 24, "Satire" },
                    { 58, "True crime" },
                    { 26, "Short story" },
                    { 27, "Suspense" },
                    { 29, "Western" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Username", "Dob", "Email", "Name", "Password", "Role" },
                values: new object[] { "john123", new DateTime(2022, 2, 17, 14, 47, 9, 315, DateTimeKind.Local).AddTicks(6921), "john123@gmail.com", "John Wick", "P@ssw0rd123", "user" });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookId", "GenreId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_GenreId",
                table: "BookGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_Username",
                table: "Carts",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_BookId",
                table: "OrderItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Username",
                table: "Orders",
                column: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenres");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
