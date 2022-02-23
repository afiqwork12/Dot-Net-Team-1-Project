using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarouselForBooksApplication.Models
{
    public class Cart
    {
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public int BookId { get; set; }
        [ForeignKey("Username")]
        public User User { get; set; }
        public string Username { get; set; }
        public int Quantity { get; set; }

    }
}
