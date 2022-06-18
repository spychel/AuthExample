using System.ComponentModel.DataAnnotations;

namespace AuthExample.Data
{
    public class User
    {
      /*  [Key]
        public int Id { get; set; }*/

        [Required(ErrorMessage = "Error")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Error")]
        public string Password { get; set; }
    }
}