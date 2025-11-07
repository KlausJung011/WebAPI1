using System.ComponentModel.DataAnnotations;

namespace WebAPI1.Models.DTOs
{
    public class RegisterUserDto
    {
        [Required, MaxLength(100)]
        public string UserName { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }

    public class UpdateUserDto
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? UserName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Password { get; set; }
    }

    public class UpdateUserEmailDto
    {
        public int Id { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }

    public class DeleteUserDto
    {
        public int Id { get; set; }
    }

}
