using Microsoft.EntityFrameworkCore;
using MovieApp.Models;
namespace MovieApp.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions contectOptions) : base(contectOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new MovieMap(modelBuilder.Entity<Movies>());
        }

        public DbSet<Movies> moviesDb{get; set;}
    }
}