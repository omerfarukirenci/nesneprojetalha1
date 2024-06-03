using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneprojetalha1.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Blocks> Blockies { get; set; }
        public DbSet<Doorman> Doormans { get; set; }
        public DbSet<CarPark> CarParks { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-4G394V6\\SQLEXPRESS;initial catalog=CBS05DB;user id=sa;password=123;TrustServerCertificate=True");
        }
    }
}