using FluentValidation;
using PrivateSchoolAPI.DTOS;

namespace PrivateSchoolAPI.Validators
{
    public class CourseForCreationDTOValidator : AbstractValidator<CourseForCreationDTO>
    {
        public CourseForCreationDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be null")
                .MaximumLength(100).MinimumLength(2).WithMessage("Name must be between 2 and 100 chars long");
            RuleFor(x => x.Stream).NotEmpty().WithMessage("Stream cannot be null");
            RuleFor(x => x.StartDateTime).NotEmpty().WithMessage("StartDateTime cannot be null");
            RuleFor(x => x.EndDateTime).NotEmpty().WithMessage("EndDateTime cannot be null");
        }
    }
}
