using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace blog.Models
{
    public class Author
    {

        [Key]
        public int AuthorId { get; set; }
        [Required(ErrorMessage = "Inform the author name")]
        public string Name { get; set; }

        /* Add many to many
        after created the database  */
    }
}