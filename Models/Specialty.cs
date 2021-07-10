using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace where_is_my_doctor.Models
{
    public class Specialty
    {
        [Key]
        public int SpecialtyId { get; set; }
        [Required(ErrorMessage = "Inform the specialty name")]
        public string Name { get; set; }
    }
}