using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;


using Microsoft.EntityFrameworkCore.Design;


namespace where_is_my_doctor.Models{
    public class ApplicationDbContext : DbContext{     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            var connectionStringBuilder = new SqliteConnectionStringBuilder {
                 DataSource = "database.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
        public void EnsureCreated(){}      

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Specialty> Specialties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Specialty>()  
               .HasData(  
               new Specialty()  
               {  
                   SpecialtyId = 1,  
                   Name = "Test Emp1"                   
               },  
                new Specialty()  
                {  
                    SpecialtyId = 2,  
                    Name = "Test Emp2"
                }); 
        }
    }
}
