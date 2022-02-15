using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarouselForBooksApplication.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        [ForeignKey("BuyerId")]
        public User Buyer { get; set; }
        public int BuyerId { get; set; }
        [ForeignKey("SellerId")]
        public User Seller { get; set; }
        public int SellerId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public int BookId { get; set; }
        public bool BuyerSold { get; set; }
        public bool SellerReceived { get; set; }
        public DateTime DateCreated { get; set; }
        public string Status { get; set; }
    }
}
