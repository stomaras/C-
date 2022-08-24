using FluentValidation;
using SchoolPrivateWebAPI.Entities;

namespace SchoolPrivateWebAPI.Validators
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull();
            RuleFor(x => x.CourseName).NotNull()
                .NotEmpty().WithMessage("Course cannot be null")
                .Must(a => a.Contains("Java") || a.Contains("Python") || a.Contains("Csharp") || a.Contains("Javascript")).WithMessage("Course must be java or python or c# or javascript");
            RuleFor(x => x.Stream).NotNull()
                .NotEmpty().WithMessage("Stream can not be null")
                .WithMessage("Stream must be String Number");
            RuleFor(x => x.StartDateTime).NotNull()
                .NotEmpty().WithMessage("Start Date Time cannot be null")
                .Must(BeValidStartDateTime).WithMessage("Must be valid start date time");
            RuleFor(x => x.EndDateTime).NotNull()
                .NotEmpty().WithMessage("End Date Time cannot be null");
            RuleForEach(x => x.Students).SetValidator(new StudentValidator());

            // custom method properties goes here 
           
        }

        public bool BeValidStartDateTime(DateTime startDateTime)
        {
            Func<DateTime, bool> date = CheckStartDateTime;
            if (date.Invoke(startDateTime))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        #region Functions For Delegates

            /// <summary>
            /// Check if StartDateTime is valid
            /// </summary>
            /// <param name="startDateTime"></param>
            /// <returns></returns>
            public bool CheckStartDateTime(DateTime startDateTime)
            {
                if (startDateTime.Year >= DateTime.Now.Year
                   )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        #endregion

    }
}
