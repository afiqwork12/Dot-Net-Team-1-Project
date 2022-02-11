using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Models
{
    public class BookGenre
    {
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public int BookId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}
    