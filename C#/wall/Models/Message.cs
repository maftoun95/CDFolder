using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace wall.Models {
    public class Message :BaseEntity {
        [Required]
        [MinLength(8, ErrorMessage ="You can do better than that...gimme at least 8 charachters")]
        public string text { get; set; }

        [Required]
        public int uid { get; set;}

        public User user { get; set;}

        public List<Comment> comments {get; set;}
    }
}