using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarouselForBooksApplication.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateOrdered { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name ="Total Cost")]
        public double TotalCost { get; set; }
    }
}
