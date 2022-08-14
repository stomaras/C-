using CitiesInfo.API.Models;
using FluentValidation;

namespace CitiesInfo.API.Validators
{
    public class PointOfInterestForCreationDTOValidator : AbstractValidator<PointOfInterestForCreationDTO>
    {
        public PointOfInterestForCreationDTOValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name cannot be null");
            RuleFor(p => p.Name).MaximumLength(50).WithMessage("Name must be at max 50 characters long");
            RuleFor(p => p.Description).MaximumLength(200).WithMessage("Description must be at most 200 characters long");
        }
    }
}
