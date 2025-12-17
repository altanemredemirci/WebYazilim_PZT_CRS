using _03_EntityFramework_CodeFirst_2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EntityFramework_CodeFirst_2.Context
{
    internal class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=202-3\\SQLDERS; Database=OkulDB; uid=sa; pwd=1;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //OneToOne Relation Mapping
            modelBuilder.Entity<Ogrenci>()
                .HasOne(o => o.TC)
                .WithOne(i => i.Ogrenci)
                .HasForeignKey<TC>(i => i.OgrenciId);
        }



        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ogretmen> Ogretmenler { get; set; }
        public DbSet<Mudur> Mudurler { get; set; }
    }
}
