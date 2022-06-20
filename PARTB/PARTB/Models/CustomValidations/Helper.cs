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

        public string CheckValidLastName(string nameInput)
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
                        ErrorMessage.LastNameCannotContainNumbersOrSpecialCharacters();
                        nameInput = Console.ReadLine();
                    }
                    else
                    {
                        containsRegularDigits = true;
                        if (nameInput.Length < 2 || nameInput.Length > 50)
                        {
                            isValid = false;
                            ErrorMessage.LastNameMustBeInRange();
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
        public string CheckDay(string day)
        {
            int numericValue;
            bool isNumber = false;
            bool isValidRange = false;
            int InputDay = -1;

            while (!isNumber || !isValidRange)
            {
                isNumber = int.TryParse(day, out numericValue);

                if (isNumber)
                {
                    InputDay = numericValue;

                    bool IsInValidDayRange = (InputDay >= 1 && InputDay <= 30);
                    if (IsInValidDayRange)
                    {
                        isValidRange = true;
                    }
                    else
                    {
                        isValidRange = false;
                        ErrorMessage.DayMustBeInValidRange();
                        day = Console.ReadLine();
                    }
                }
                else
                {
                    isNumber = false;
                    ErrorMessage.DayMustBeInteger();
                    day = Console.ReadLine();

                }
            }
            return day;
        }

        public string CheckMonth(string month)
        {
            int numericValue;
            bool isNumber = false;
            bool isValidRange = false;
            int InputMonth = -1;

            while (!isNumber || !isValidRange)
            {
                isNumber = int.TryParse(month, out numericValue);

                if (isNumber)
                {
                    InputMonth = numericValue;

                    bool IsInValidMonthRange = (InputMonth >= 1 && InputMonth <= 12);
                    if (IsInValidMonthRange)
                    {
                        isValidRange = true;
                    }
                    else
                    {
                        isValidRange = false;
                        ErrorMessage.MonthMustBeInValidRange();
                        month = Console.ReadLine();
                    }
                }
                else
                {
                    isNumber = false;
                    ErrorMessage.MonthMustBeInteger();
                    month = Console.ReadLine();

                }
            }
            return month;
        }

        public string CheckYear(string year)
        {
            int numericValue;
            bool isNumber = false;
            bool isValidRange = false;
            int InputYear = -1;

            while (!isNumber || !isValidRange)
            {
                isNumber = int.TryParse(year, out numericValue);

                if (isNumber)
                {
                    InputYear = numericValue;

                    Func<int, bool> IsInValidYear = ValidYearRange;
                    bool IsInValidYearRange = IsInValidYear.Invoke(InputYear);

                    if (IsInValidYearRange)
                    {
                        isValidRange = true;
                    }
                    else
                    {
                        isValidRange = false;
                        ErrorMessage.YearMustBeInValidRange();
                        year = Console.ReadLine();
                    }
                }
                else
                {
                    isNumber = false;
                    ErrorMessage.YearMustBeInteger();
                    year = Console.ReadLine();

                }
            }
            return year;

        }

        public int CheckTuitionFees(string tuitionFees)
        {
            int numericValue;
            bool isNumber = false;
            bool isValidRange = false;
            int InputTuitionFees = -1;
            while (!isNumber || !isValidRange)
            {
                isNumber = int.TryParse(tuitionFees, out numericValue);

                if (isNumber)
                {
                    InputTuitionFees = numericValue;
                    Func<int, bool> isValidTuitionRange = ValidTuitonRange;
                    bool IsInValidTuitionFeesRange = isValidTuitionRange.Invoke(InputTuitionFees);

                    if (IsInValidTuitionFeesRange)
                    {
                        isValidRange = true;
                    }
                    else
                    {
                        isValidRange = false;
                        int LowerTuition = 2100;
                        int HigherTuition = 2500;
                        ErrorMessage.TuitionFeesMustBeInRange(LowerTuition, HigherTuition);
                        tuitionFees = Console.ReadLine();
                    }
                }
                else
                {
                    ErrorMessage.TuitionMustBeANumber();
                    tuitionFees = Console.ReadLine();
                }
            }
            return InputTuitionFees;
        }

        public string CourseTypeValidation(string type)
        {
            bool isValidType = false;
            bool isValidRegex = Regex.IsMatch(type, @"^[a-zA-Z]+$");
            Func<string, bool> isValidCourseType = IsValidCourseType;
            isValidType = isValidCourseType.Invoke(type);
            while (!isValidRegex || !isValidType)
            {

                if (isValidRegex)
                {
                    isValidRegex = true;
                    if (isValidType)
                    {
                        isValidType = true;
                    }
                    else
                    {
                        isValidType = false;
                        ErrorMessage.TypeOfCourseErrorMessage1();
                        type = Console.ReadLine();
                    }

                }
                else
                {
                    isValidRegex = false;
                    ErrorMessage.TypeOfCourseErrorMessage2();
                    type = Console.ReadLine();
                }
            }
            return type;
        }

        public int GetValidNumber(string number)
        {
            bool isNumber = Regex.IsMatch(number, @"^[0-9]+$");
            while (!isNumber)
            {
                ErrorMessage.CourseIdMustBeNumber();
                number = Console.ReadLine();
                isNumber = Regex.IsMatch(number, @"^[0-9]+$");
            }
            int courseId = Convert.ToInt32(number);
            return courseId;
        }




        public bool IsValidCourseType(string type)
        {
            bool isValidCourseType = ((type.ToLower().Equals("java")) || (type.ToLower().Equals("python")) || (type.ToLower().Equals("javascript")) || (type.ToLower().Equals("csharp")));
            return isValidCourseType;
        }


        public bool ValidYearRange(int inputYear)
        {
            bool isValidYear = (inputYear >= 1960 && 18 <= DateTime.Now.Year - inputYear);
            return isValidYear;
        }

        public static string YearOfBirthValidRangeMessage(string message)
        {
            message = $"Year Must be between 1960 and {DateTime.Now.Year - 18}";
            return message;
        }

        public static bool ValidTuitonRange(int TuitionFees)
        {
            bool LowerTuition = (TuitionFees == 2100);
            bool HigherTuition = (TuitionFees == 2500);

            if (LowerTuition || HigherTuition)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


    #endregion






}
