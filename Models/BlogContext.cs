using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
public class BlogContext : DbContext
{
    /* public BlogContext() : base("name=BlogContext")
    {
        Database.Connection.ConnectionString =
        @"data source=FABRCIOSANC36FC\SQLEXPRESS;
        initial catalog=BlogBDLivro; Integrated Security=SSPI";
    } */

    public DbSet<Post> Posts { get; set; }
    public DbSet<Category> Categories { get; set; }
}