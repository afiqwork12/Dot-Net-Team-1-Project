using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarouselForBooksAPI.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int BookId { get; set; }
        public string Username { get; set; }
        public int Quantity { get; set; }
    }
}
