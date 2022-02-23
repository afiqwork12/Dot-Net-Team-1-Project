using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarouselForBooksAPI.Models
{
    public class BookGenre
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public int BookId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}
