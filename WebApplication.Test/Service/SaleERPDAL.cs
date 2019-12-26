using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.Test.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WebApplication.Test.Service
{
    public class SaleERPDAL : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=SaleERPDB; User ID=sa;Password=121308", b => b.UseRowNumberForPaging());
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);


        }
        public DbSet<Employee> Employees { get; set; }
    }
}
