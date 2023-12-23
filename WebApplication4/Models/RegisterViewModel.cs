using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is Required.")]
        [StringLength(30, ErrorMessage = "Username can be max 30 characters.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required.")]
        [MinLength(6, ErrorMessage = "Username can be min 6 characters.")]
        [MaxLength(16, ErrorMessage = "Username can be max 16 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Re-Password is Required.")]
        [MinLength(6, ErrorMessage = "Username can be min 6 characters.")]
        [MaxLength(16, ErrorMessage = "Username can be max 16 characters.")]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
    }
}
