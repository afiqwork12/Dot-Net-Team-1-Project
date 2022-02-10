using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarouselForBooksApplication.Migrations
{
    public partial class added_more_seeded_books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2022, 2, 10, 19, 17, 47, 14, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2022, 2, 10, 19, 17, 47, 14, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2022, 2, 10, 19, 17, 47, 14, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Cost", "DatePosted", "Description", "IsSold", "Language", "Picture", "Title", "UserId" },
                values: new object[,]
                {
                    { 4, 22.2, new DateTime(2022, 2, 10, 19, 17, 47, 14, DateTimeKind.Local), "Description 4", false, "English", "/images/book4.jfif", "Title 4", 1 },
                    { 5, 22.2, new DateTime(2022, 2, 10, 19, 17, 47, 14, DateTimeKind.Local), "Description 5", false, "English", "/images/book5.png", "Title 5", 1 },
                    { 6, 22.2, new DateTime(2022, 2, 10, 19, 17, 47, 14, DateTimeKind.Local), "Description 6", false, "English", "/images/book6.jfif", "Title 6", 1 },
                    { 7, 22.2, new DateTime(2022, 2, 10, 19, 17, 47, 14, DateTimeKind.Local), "Description 7", false, "English", "/images/book7.jpg", "Title 7", 1 },
                    { 8, 22.2, new DateTime(2022, 2, 10, 19, 17, 47, 14, DateTimeKind.Local), "Description 8", false, "English", "/images/book8.jpg", "Title 8", 1 },
                    { 9, 22.2, new DateTime(2022, 2, 10, 19, 17, 47, 14, DateTimeKind.Local), "Description 9", false, "English", "/images/book9.jpg", "Title 9", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 2, 10, 19, 17, 47, 12, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePosted",
                value: new DateTime(2022, 2, 10, 17, 44, 9, 202, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "DatePosted",
                value: new DateTime(2022, 2, 10, 17, 44, 9, 202, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "DatePosted",
                value: new DateTime(2022, 2, 10, 17, 44, 9, 202, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Dob",
                value: new DateTime(2022, 2, 10, 17, 44, 9, 200, DateTimeKind.Local));
        }
    }
}
