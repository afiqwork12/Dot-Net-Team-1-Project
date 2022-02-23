using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarouselForBooksAPI.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime DateOrdered { get; set; }
    }
}
