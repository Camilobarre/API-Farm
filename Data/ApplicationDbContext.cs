using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Farm.Models;
using API_Farm.Seeders;
using Microsoft.EntityFrameworkCore;

namespace API_Farm.Data
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AnimalType> AnimalTypes { get; set; }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            AnimalTypeSeeder.Seed(modelBuilder);
            AnimalSeeder.Seed(modelBuilder);
        }
    }
}