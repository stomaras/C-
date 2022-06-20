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

    }


    #endregion






}
