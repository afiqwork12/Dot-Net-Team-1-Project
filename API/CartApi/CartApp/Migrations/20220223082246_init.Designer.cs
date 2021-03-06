// <auto-generated />
using CarouselForBooksAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CartApp.Migrations
{
    [DbContext(typeof(CFBDBContext))]
    [Migration("20220223082246_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarouselForBooksAPI.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CartId");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            CartId = 1,
                            BookId = 1,
                            Quantity = 2,
                            Username = "afiq123"
                        },
                        new
                        {
                            CartId = 2,
                            BookId = 2,
                            Quantity = 3,
                            Username = "afiq123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
