using System.ComponentModel.DataAnnotations;

namespace AuthExample.Data
{
    public class User
    {
        [Required]
        [StringLength(50, ErrorMessage = $"Длина имени пользователя не должна превышать 50 символов")]
        [MinLength(3, ErrorMessage = $"Длина имени пользователя должна быть более 3-х символов")]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
    }
}