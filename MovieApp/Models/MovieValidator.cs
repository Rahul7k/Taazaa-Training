//Used to validate data while giving data from the code
using FluentValidation;
namespace MovieApp.Models
{
    public class MovieValidator : AbstractValidator<Movies>
    {
        public MovieValidator()
        {
            RuleFor(e => e.MovieName).NotNull();
            RuleFor(e => e.ReleseYear).Length(4);
            RuleFor(e => e.Rating).InclusiveBetween(1, 10);
        }
    }
}