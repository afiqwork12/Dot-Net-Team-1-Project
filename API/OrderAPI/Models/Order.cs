using System;
using System.ComponentModel.DataAnnotations;

namespace OrderAPI.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime DateOrdered { get; set; }
    }
}
