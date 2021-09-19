//used to validate data on the database/table
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MovieApp.Models
{
    public class MovieMap
    {
        public MovieMap(EntityTypeBuilder<Movies> entityType)
        {
            entityType.HasKey(e => e.MovieName);
            entityType.Property(e => e.MovieName).ValueGeneratedNever();
            entityType.Property(e => e.MovieName).HasMaxLength(50);
            entityType.Property(e => e.ReleseYear).IsRequired();
            entityType.Property(e => e.ReleseYear).HasMaxLength(4);
            entityType.Property(e => e.Rating).IsRequired();
        }
    }
}