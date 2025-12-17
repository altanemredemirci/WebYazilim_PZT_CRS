using _03_EntityFramework_CodeFirst.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFramework_CodeFirst.Context
{
    internal class ProjectContext:DbContext //EntityFrameworkCore paketinden geliyor
    {
        //SQL Bağlantı Kodu
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Windows Authentication

            //UseSqlServer EntityFrameWorkCore.SqlServer
            //optionsBuilder.UseSqlServer("Server=202-3\\SQLDERS; Database=ETicaretDB; Trusted_Connection=true;TrustServerCertificate=true");

            //SQL Server Authentication
            optionsBuilder.UseSqlServer("Server=202-3\\SQLDERS; Database=ETicaretDB; uid=sa; pwd=1;TrustServerCertificate=true");
        }

        //class isimlerinin sonuna 's' gelmesi plurazing işlemidir. 
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
