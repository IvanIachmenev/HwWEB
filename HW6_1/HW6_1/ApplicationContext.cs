using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HW6_1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=PerfumeStoreSix;Username=postgres;Password=Aa3sdf&;");
        }
    }
}
