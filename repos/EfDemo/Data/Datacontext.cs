using LinqToDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfDemo.Data
{
    public class Datacontext : DbContext
    {
        public DbSet<Patient> patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=EfDatabase;Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);
           
        
        
        }

    }
}