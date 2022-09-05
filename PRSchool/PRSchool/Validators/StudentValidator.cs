using FluentValidation;
using PRSchool.Entities;

namespace PRSchool.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName cannot be null")
                .MaximumLength(100).WithMessage("First Name must be at most 100 characters long.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name cannot be null")
                .MaximumLength(100).WithMessage("Last Name must be at most 100 characters long");
        }

    }
}
