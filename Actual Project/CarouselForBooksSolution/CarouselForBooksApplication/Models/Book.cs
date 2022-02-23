using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarouselForBooksApplication.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author is required.")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Language is required.")]
        public string Language { get; set; }
        [Required(ErrorMessage = "Cost is required.")]
        public double Cost { get; set; }
        [Required(ErrorMessage = "Picture is required.")]
        [Display(Name = "Image Link")]
        public string Picture { get; set; }
    }
}
