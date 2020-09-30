﻿
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.ATM.Data
{
    public class ATMContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data source=(LocalDB)\\MSSQLLocalDB; Initial Catalog=ATMDB;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);

        }// Data Modeling
        protected override void OnModelCreating(ModelBuilder modelBuilder)   
        {
            modelBuilder.Entity<User>().Property(b=>b.FirstName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b=>b.LastName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b=>b.Address1).HasColumnType("varchar(500)").IsRequired();
            modelBuilder.Entity<User>().Property(b=>b.Address2).HasColumnType("varchar(500)");
            modelBuilder.Entity<User>().Property(b=>b.Landmark).HasColumnType("varchar(100)");
            modelBuilder.Entity<User>().Property(b=>b.city).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b=>b.State).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b=>b.Pin).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b=>b.Mobile).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b=>b.Email).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b=>b.Status).HasColumnType("varchar(20)").IsRequired();
            
        }
    }
}
