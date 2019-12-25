using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFCore.DomainModels;

namespace EFCore.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Privence> Privences { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=EFCoreDemo; Trusted_Connection=True;");
        }
    }
}
