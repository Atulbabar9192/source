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
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Account> Accounts { get;  set; }
        public DbSet<DepositMode> DepositModes { get;  set; }
        public DbSet<TransactionType> TransactionTypes { get;  set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data source=(LocalDB)\\MSSQLLocalDB; Initial Catalog=ATMDB;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);

        }// Data Modeling
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(b => b.FirstName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.LastName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Address1).HasColumnType("varchar(500)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Address2).HasColumnType("varchar(500)");
            modelBuilder.Entity<User>().Property(b => b.Landmark).HasColumnType("varchar(100)");
            modelBuilder.Entity<User>().Property(b => b.city).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.State).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Pin).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Mobile).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Email).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.status).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<AccountType>().Property(b => b.Name).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Status>().Property(b => b.Name).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.AccountNumber).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.AccountType).HasColumnType("varchar(50)").IsRequired();
            modelBuilder.Entity<Account>().Property(b => b.AvilableBalance).HasColumnType("decimal(10,2)").IsRequired();
            modelBuilder.Entity<DepositMode>().Property(b => b.Name).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<TransactionType>().Property(b => b.Name).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<TransactionType>().Property(b => b.ShortCode).HasColumnType("varchar(20)").IsRequired();


        }
    }
} 

