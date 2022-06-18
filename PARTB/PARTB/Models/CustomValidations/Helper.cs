using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARTB.View.ErrorMessages;
using System.Text.RegularExpressions;

namespace PARTB.Models.CustomValidations
{
    public class Helper
    {
        private int numericValue;
        #region General Validations
        /// <summary>
        /// Check if an input string contains characters
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool CheckIfIsNumber(string input)
        {
            if (input.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        #region Validations for Student
        /// <summary>
        /// Input is a name and check if name is valid . A name is valid if contains characters between 3 and 100 characters long
        /// and characters are not numbers
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string CheckValidFirstName(string nameInput)
        {
            
            bool isValid = false;
            bool containsRegularDigits = false;
            while (!isValid || !containsRegularDigits)
            {

                if (string.IsNullOrEmpty(nameInput))
                {
                    isValid = false;
                    ErrorMessage.FirstNameCannotBeNull();
                    nameInput = Console.ReadLine();
                }
                else
                {

                    //process 1
                    containsRegularDigits = Regex.IsMatch(nameInput, @"^[a-zA-Z]+$");
                    if (!containsRegularDigits)
                    {
                        ErrorMessage.FirstNameCannotContainNumbersOrSpecialCharacters();
                        nameInput = Console.ReadLine();
                    }
                    else
                    {
                        containsRegularDigits = true;
                        if (nameInput.Length < 2 || nameInput.Length > 50)
                        {
                            isValid = false;
                            ErrorMessage.FirstNameMustBeInRange();
                            nameInput = Console.ReadLine();
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                }
            }
            return nameInput;
        }

    }

    //    public int CheckDay(string day)
    //    {
    //        int numericValue;
    //        bool isNumber = false;
    //        bool isValidRange = false;
    //        int InputDay = -1;
    //        while (!isNumber || !isValidRange)
    //        {
    //            isNumber = int.TryParse(day, out numericValue);

    //            if (isNumber)
    //            {
    //                InputDay = numericValue;
    //                Func<int, bool> ValidDayRange = null;
    //                Func<int, bool> IsInValidDay = ValidDayRange;
    //                bool IsInValidDayRange = IsInValidDay.Invoke(InputDay);
    //                if (IsInValidDayRange)
    //                {
    //                    isValidRange = true;
    //                }
    //                else
    //                {
    //                    isValidRange = false;
    //                    ErrorMessage.PrintDayMustBeInRange();
    //                    day = Console.ReadLine();
    //                }
    //            }
    //            else
    //            {
    //                ErrorMessage.PrintDayMustBeInteger();
    //                day = Console.ReadLine();
    //            }
    //        }
    //        return InputDay;
    //    }
    //    public static bool ValidDayRange(int day)
    //    {
    //        bool LowestDayRange = day >= 1;
    //        bool HighestDayRange = day <= 30;
    //        if (LowestDayRange && HighestDayRange)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //#endregion





    #endregion
}
