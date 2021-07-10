using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace where_is_my_doctor.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }

        [Required(ErrorMessage = "Inform the CRM")]
        [StringLength(30, ErrorMessage = "CRM should have in maxim 30 charactheres")]
        public string CRM { get; set; }

        [Required(ErrorMessage = "Inform the name")]
        [StringLength(80, ErrorMessage = "Name should have in maximum 80 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Inform the address")]
        [StringLength(100, ErrorMessage = "Address should have in maximum 100 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Inform the District")]
        [StringLength(60, ErrorMessage = "District shoul have in maximum 60 characters")]
        public string District { get; set; }

        [Required(ErrorMessage = "Inform the e-mail")]
        [StringLength(100, ErrorMessage = "E-mail should have in maximum 100 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Inform if there is Health Insurance")]
        public bool HealthInsurance { get; set; }

        [Required(ErrorMessage = "Inform if there is a medical mlinic")]
        public bool HasMedicalClinic { get; set; }

        [StringLength(80, ErrorMessage = "Web site shoul have in maximum 80 characters")]
        public string WebSite { get; set; }

        [Required(ErrorMessage = "Informe the city")]
        public int CodCity { get; set; }

        [Required(ErrorMessage = "Inform the speciality")]
        public int CodSpecialty { get; set; }

    }
}