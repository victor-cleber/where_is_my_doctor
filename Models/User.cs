
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Users
{
    [Key]
    public int UserID { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}