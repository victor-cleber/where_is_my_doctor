using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;


using Microsoft.EntityFrameworkCore.Design;


namespace where_is_my_doctor.Models
{
    public class ApplicationDbContext : DbContext
    {
        /* public BlogContext() : base("name=BlogContext")
        {
            Database.Connection.ConnectionString =
            @"data source=FABRCIOSANC36FC\SQLEXPRESS;
            initial catalog=BlogBDLivro; Integrated Security=SSPI";
        } */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder {
                 DataSource = "MyDb.db" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
        public void EnsureCreated(){}
        public void Eigraae(){}

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
    }
}
