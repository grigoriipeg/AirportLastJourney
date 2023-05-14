using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirportLastJourney.Models;
using Microsoft.EntityFrameworkCore;

namespace AirportLastJourney
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Flights> Flights { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flights>().HasKey(x => x.id_flight);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AirportLastJourneyDatabase;Trusted_Connection=True;");
        }
    }

}
