using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Doctor
{
    [Key]
    public int DoctorID { get; set; }
    public string CRM { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }

    public string Complement { get; set; }
    public string Email { get; set; }
    public bool HealthInsurance { get; set; }
    public bool HasMedicalClinic { get; set; }
    public string WebSite { get; set; }

    public int City { get; set; }

    public int Specialty { get; set; }

}