using FluentValidation;
using PRSchool.Entities;

namespace PRSchool.Validators
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name of the course cannot be null");
           
        }
    }
}
