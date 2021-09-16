using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models;
namespace UserManagementSystem.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<User> users{get; set;}
    }
}