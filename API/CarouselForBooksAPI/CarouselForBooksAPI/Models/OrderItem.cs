using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarouselForBooksAPI.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
    }
}
