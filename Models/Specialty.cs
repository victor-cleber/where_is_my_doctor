using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Specialty{
    [Key]
    public int SpecialtyId { get; set; }
    public string Name { get; set; }
}
