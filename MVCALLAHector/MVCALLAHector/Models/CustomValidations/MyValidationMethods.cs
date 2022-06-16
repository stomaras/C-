using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCALLAHector.Models.CustomValidations
{
    public class MyValidationMethods
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
                return new ValidationResult($"In The field {context.MemberName}, First Letter must be Capital", new List<string> { context.MemberName});
            }
        }

        public static ValidationResult ValidateOfGenre(string value, ValidationContext context)
        {
            bool isValidKindGenre = true;
            string AlertMessageErrors = "";
            if (value != null)
            {
                Func<string, bool> isValidKindOfGenre = ValidKindOfGenre;
                if (isValidKindOfGenre.Invoke(value))
                {
                    isValidKindGenre = true;
                }
                else
                {
                    isValidKindGenre = false;
                    AlertMessageErrors = CustomValidationAlertErrors(context);
                }
            }
            if (isValidKindGenre)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(AlertMessageErrors, new List<string> { context.MemberName });
            }
        }

        public static bool ValidKindOfGenre(string value)
        {
            if ((value.ToLower() == "comedy" || value.ToLower() == "thriller" || value.ToLower() == "drama"
                || value.ToLower() == "action" || value.ToLower() == "fantasy"  || value.ToLower() == "romance" 
                || value.ToLower() == "mystery"  || value.ToLower() == "western" || value.ToLower() == "horror"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Custom Validation Alert Errors for field kind
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static string CustomValidationAlertErrors(ValidationContext context)
        {
            string alertErrors = $"The field {context.MemberName}, must be <<comedy>> or <<thriller>> or <<drama>> or <<action>> or <<horror>> or <<fantasy>> or <<romance>> or <<mystery>> or <<western>>";
            return alertErrors;
        }
    }
}