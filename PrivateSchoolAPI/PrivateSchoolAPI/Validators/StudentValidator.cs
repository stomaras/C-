using FluentValidation;
using PrivateSchoolAPI.Entities;

namespace PrivateSchoolAPI.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Age).NotEmpty();
            RuleFor(x=>x.Course).NotNull();
        }
    }
}
