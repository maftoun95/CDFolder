using System.ComponentModel.DataAnnotations;

namespace loginReg.Models
{
    public abstract class BaseEntity {}
    public class User :BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [MinLength(8)]
        public string Confirm { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
