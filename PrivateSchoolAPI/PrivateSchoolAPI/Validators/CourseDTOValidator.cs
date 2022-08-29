using FluentValidation;
using PrivateSchoolAPI.DTOS;

namespace PrivateSchoolAPI.Validators
{
    public class CourseDTOValidator : AbstractValidator<CourseDTO>
    {
        public CourseDTOValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name cannot be null")
                .NotEmpty().WithMessage("Name cannot be empty")
                .MinimumLength(2).WithMessage("Name must be at least 2 characters long")
                .MaximumLength(100).WithMessage("Name must be at most 100 characters long");
            RuleFor(x => x.Stream).NotEmpty().WithMessage("Stream Cannot be null");
            
        }
    }
}
