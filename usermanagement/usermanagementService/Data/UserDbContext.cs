using Microsoft.EntityFrameworkCore;
using usermanagementService.Models;
namespace usermanagementService.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Linking between user and usermap
            new UserMap(modelBuilder.Entity<User>());
        }



        public DbSet<User> users{get; set;}
    }
}