using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace where_is_my_doctor.Models
{
    public class WhereIsMyDoctorContext : DbContext
    {
        /* public BlogContext() : base("name=BlogContext")
        {
            Database.Connection.ConnectionString =
            @"data source=FABRCIOSANC36FC\SQLEXPRESS;
            initial catalog=BlogBDLivro; Integrated Security=SSPI";
        } */

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet <User>Users { get; set; }

        public DbSet<Specialty> Specialties { get; set; }
    }
}