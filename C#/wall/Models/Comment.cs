using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace wall.Models {
    public class Comment :BaseEntity {
        [Required]
        [MinLength(8, ErrorMessage ="You can do better than that...gimme at least 8 charachters")]
        public string text { get; set; }

        public int uid { get; set;}

        public User user { get; set;}

        public int mid { get; set;}

        public Message message { get; set;}
        
    }
}