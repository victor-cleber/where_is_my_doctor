using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Author
{

    [Key]
    public int AuthorId { get; set; }
    public string Name { get; set; }

    /* Add many to many
    after created the database  */
}