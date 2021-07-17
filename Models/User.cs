
using System.ComponentModel.DataAnnotations;

namespace where_is_my_doctor.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Informe your name")]
        [StringLength(50, ErrorMessage = "Name should have in maximum 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe an Email")]
        [StringLength(20, ErrorMessage = "Email should have in maximum 20 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Inform a password")]
        public string Password { get; set; }
    }
}