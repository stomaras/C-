using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6mvc.Models.CustomValidations
{
    public class MyValidationsMethods
    {

        public static ValidationResult ValidateFirstCapitalLetter(string value, ValidationContext context)
        {
            bool isValid = true;

            if (value != null)
            {
                if (char.IsLower(value[0]))
                {
                    isValid = false;
                }
            }

            if (isValid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult($"In The field {context.MemberName}, First Letter must be Capital", new List<string> { context.MemberName });
            }
        }
    }
}