using Microsoft.EntityFrameworkCore.Migrations;

namespace CartApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartId", "BookId", "Quantity", "Username" },
                values: new object[] { 1, 1, 2, "afiq123" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "CartId", "BookId", "Quantity", "Username" },
                values: new object[] { 2, 2, 3, "afiq123" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");
        }
    }
}
