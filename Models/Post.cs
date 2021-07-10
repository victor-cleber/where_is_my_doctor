using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Post
{
    [Key]
    public long PostId { get; set; }
    [Required(ErrorMessage = "Inform the title")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Inform the summary")]
    public string Summary { get; set; }
    [Required(ErrorMessage = "Inform the content")]
    public string Content { get; set; }
    [Required(ErrorMessage = "Inform the date")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Inform the category")]
    public int CategoryId { get; set; }

    [ForeignKey("CategoriaID")]
    public virtual Category Category { get; set; }
}