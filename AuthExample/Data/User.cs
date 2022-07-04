using System.ComponentModel.DataAnnotations;

namespace AuthExample.Data
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = $"Длина имени пользователя не должна превышать 50 символов")]
        [MinLength(3, ErrorMessage = $"Длина имени пользователя должна быть более 3-х символов")]
        public string Login { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public Role Role { get; set; } = Role.User;

    }

    public enum Role
    {
        Administrator,
        User
    }
}