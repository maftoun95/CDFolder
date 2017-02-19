using System;
using System.ComponentModel.DataAnnotations;

namespace quotingDojo.Models{
    public abstract class BaseEntity {}
    public class Posts : BaseEntity{
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        public string Quote { get; set; }

        [Required]
        public DateTime Created_At { get; set; }
    }
}