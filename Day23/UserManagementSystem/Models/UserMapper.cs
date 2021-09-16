using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace UserManagementSystem.Models
{
    // implementing fluent api for defining the structure or schema for user
    public class UserMapper
    {
        public UserMapper(EntityTypeBuilder<User> entityTypeBuildar)
        {
            entityTypeBuildar.HasKey(t => t.Id);
            entityTypeBuildar.Property(e => e.Name).IsRequired();
            entityTypeBuildar.Property(t => t.Phone).IsRequired();
        }
    }
}