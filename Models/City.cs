using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class City
{
    [Key] public int CityId { get; set; }

    [Required(ErrorMessage = "Inform the city name")]
    public string Name { get; set; }

}