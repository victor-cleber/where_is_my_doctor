using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace where_is_my_doctor.Models
{
    public class City
    {
        [Key] public int CityId { get; set; }

        [Required(ErrorMessage = "Inform the city name")]
        public string Name { get; set; }

    }
}