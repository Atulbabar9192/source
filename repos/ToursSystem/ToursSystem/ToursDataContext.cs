using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace ToursSystem
{
    class ToursDataContext : DbContext

    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TMSDB;Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
