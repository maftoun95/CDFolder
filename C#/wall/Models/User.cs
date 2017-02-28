using System;
using System.ComponentModel.DataAnnotations;

namespace wall.Models
{
    public class User :BaseEntity
    {
        
        [Required]
        [MinLength(2, ErrorMessage ="First name must be at least 2 characters long")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2, ErrorMessage ="Last name must be at least 2 characters long")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [MinLength(8, ErrorMessage ="Password must be at least 8 characters long")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [MinLength(8, ErrorMessage ="Password must be at least 8 characters long")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="The supplied passwords do not match, please try again.")]
        public string Confirm { get; set; }

    }
}
