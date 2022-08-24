using FluentValidation;
using SchoolPrivateWebAPI.Entities;

namespace SchoolPrivateWebAPI.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Id).NotNull().NotEmpty();
            RuleFor(x => x.FirstName).NotNull()
                .NotEmpty().MaximumLength(100).MinimumLength(2)
                .WithMessage("First Name must be between 2 and 100 characters long");
            RuleFor(x => x.LastName).NotNull()
                .NotEmpty().MaximumLength(100).MinimumLength(2)
                .WithMessage("Last Name must be between 2 and 100 characters long");
            RuleFor(x => x.Age).NotNull().InclusiveBetween(18, 65)
                .WithMessage("Age must be between 18 and 65 years old!");
        }
    }
}

