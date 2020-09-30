
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.ATM.Data
{
    public class ATMContext : DbContext

    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data source=(LocalDB )\MSSQLLocalDB;Initial Catalog=EfDatabase;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);

           
        }
    }
}
