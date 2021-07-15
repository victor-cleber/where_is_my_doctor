using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace where_is_my_doctor.Models
{
    public class Banner
    {
        [Key] public int BannerId { get; set; }

        [Required(ErrorMessage = "Inform the title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Inform the file")]
        public string File { get; set; }
        
        [Required(ErrorMessage = "Inform the link")]
        public string Link { get; set; }

    }
}