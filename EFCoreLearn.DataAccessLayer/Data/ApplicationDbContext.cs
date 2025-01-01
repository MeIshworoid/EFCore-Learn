using EFCoreLearn.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLearn.DataAccessLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MovieDB;TrustServerCertificate = True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Movie>().Property(x => x.Price).HasPrecision(10, 5);

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    MovieName = "The Lord of The Ring",
                    Price = 1200.777M,
                    Genre = "Adventure, Action, Fantasy",
                    ActionDate = DateTime.Now,
                    ActionTaken = 1,
                    ActionType="Create"
                },
                new Movie
                {
                    MovieId = 2,
                    MovieName = "Bahubali The Conclusion",
                    Price = 800.99M,
                    Genre = "Adventure, Action, Fantasy"
                });

            var movieList = new Movie[]
            {
                new Movie
                {
                    MovieId=3,
                    MovieName = "3 Idiots",
                    Price = 3899.777M,
                    Genre = "Comedy, Drama"
                },
                new Movie
                {
                    MovieId=5,
                    MovieName = "Dhammal",
                    Price = 1145.996M,
                    Genre = "Comedy, Action",
                    ActionDate = DateTime.Now,
                    ActionTaken = 2,
                    ActionType="Create"
                },
                new Movie
                {
                    MovieId=4,
                    MovieName = "Kamal",
                    Price = 1145.996M,
                    Genre = "Comedy, Action",
                    ActionDate = DateTime.Now,
                    ActionTaken = 2,
                    ActionType="Create"
                }
            };

            modelBuilder.Entity<Movie>().HasData(movieList);
        }
    }
}
