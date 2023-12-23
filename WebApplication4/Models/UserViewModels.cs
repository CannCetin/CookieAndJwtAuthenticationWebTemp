using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class UserModel
    {

        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string UserName { get; set; }
        public bool Locked { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? ProfileImageFileName { get; set; } = "nopicture.jpg";
        public string Role { get; set; } = "user";
    }
    public class CreateUserModel
    {
        [Required(ErrorMessage = "Username is Required.")]
        [StringLength(30, ErrorMessage = "Username can be max 30 characters.")]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        public bool Locked { get; set; }

        [Required(ErrorMessage = "Password is Required.")]
        [MinLength(6, ErrorMessage = "Username can be min 6 characters.")]
        [MaxLength(16, ErrorMessage = "Username can be max 16 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Re-Password is Required.")]
        [MinLength(6, ErrorMessage = "Username can be min 6 characters.")]
        [MaxLength(16, ErrorMessage = "Username can be max 16 characters.")]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }
        public string? Done { get; set; }
    }
    public class EditUserModel 
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Username is Required.")]
        [StringLength(30, ErrorMessage = "Username can be max 30 characters.")]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        public bool Locked { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }
        public string? Done { get; set; }
    }

}
