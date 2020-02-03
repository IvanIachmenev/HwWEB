using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HW5.Models
{
    public class WaterContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Water> Waters { get; set; }
        public WaterContext(DbContextOptions<WaterContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=password");
        }
    }
}
