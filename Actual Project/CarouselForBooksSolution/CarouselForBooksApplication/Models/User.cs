using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Password is required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Re-Type Password is required.")]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match.")]
        [Display(Name = "Re-Type Password")]
        public string ConfirmPassword { get; set; }
        public string Token { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Date of Birth is required.")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Required(ErrorMessage = "Email Address is required.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        public string Role { get; set; } //user, power user, admin
    }
}
