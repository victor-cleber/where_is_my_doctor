using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace blog.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Inform the category name")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Inform the category description")]
        public string Description { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}