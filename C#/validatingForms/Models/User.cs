using System.ComponentModel.DataAnnotations;

namespace validatingForms.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [Range(8,80)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(5)]
        public string Password { get; set; }

    }
}