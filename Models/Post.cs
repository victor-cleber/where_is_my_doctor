using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Post{
    [Key]
    public long PostId { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }

    public string Content { get; set; }
    public DateTime Date { get; set; }
    public int CategoryId { get; set; }
    
    [ForeignKey("CategoriaID")]
    public virtual Category Category{ get; set; }
}