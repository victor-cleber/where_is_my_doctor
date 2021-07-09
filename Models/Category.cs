using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class Category{
    [Key]
    public int CategoryID { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public virtual ICollection<Post>Posts { get; set; }

}