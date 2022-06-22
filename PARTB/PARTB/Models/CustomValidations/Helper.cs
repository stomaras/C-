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
        public int CheckDay(string day)
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
            return Convert.ToInt32(day);
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

        
        public string CheckSubject(string subject)
        {
            bool isValidSubject = false;
            while (!isValidSubject)
            {
                if (subject.ToLower() == "java" || subject.ToLower() == "python" || subject.ToLower() == "javascript" || subject.ToLower() == "csharp")
                {
                    isValidSubject = true;
                    break;
                }
                else
                {
                    isValidSubject = false;
                    ErrorMessage.ValidTrainerSubject();
                    subject = Console.ReadLine();
                }
            }
            return subject;
        }

        public DateTime InitializeEndDate(string ValidType, DateTime start_date)
        {
            DateTime endDate = DateTime.MinValue;
            Func<string, DateTime ,DateTime> InitializeEndDate = ConditionsOfEndDate;
            if (ValidType.ToLower() == "part time")
            {
                endDate = InitializeEndDate.Invoke(ValidType, start_date);
            }
            else
            {
                endDate = InitializeEndDate.Invoke(ValidType, start_date);
            }
            return endDate;
        }

        public string CheckValidTitle(string title, List<Course> Courses)
        {
            bool isValidTitle = false;
            bool exists = false;
            while (!isValidTitle)
            {
                Func<string, bool> validTitle = ValidCourseTitle;
                isValidTitle = validTitle.Invoke(title);
                if (isValidTitle)
                {
                   
                }
                else
                {
                    Func<List<string>> acceptableTitles = AcceptableTitles;
                    List<string> AcceptableTitleCourses = acceptableTitles.Invoke();
                    ErrorMessage.ValidCourseTitles(AcceptableTitleCourses);
                    title = Console.ReadLine();
                }
            }
            foreach (var course in Courses)
            {
                if (course.Title == title)
                {
                    exists = true;
                }
            }
            if (!exists)
            {
                return title;
            }
            else
            {
                return $"Course with title {title} already exists!";
            }
           
        }

        public string CourseTypeValidation(string type)
        {
            bool isValidCourseType = false;
            while (!isValidCourseType)
            {
                Func<string, bool> validCourseType = ValidCourseTypes;
                Func<List<string>> types = ValidTypes;
                List<string> typesValid = types.Invoke();
                bool isValidTypeOfCourse = validCourseType.Invoke(type);
                if (isValidTypeOfCourse)
                {
                    isValidCourseType = true;
                }
                else
                {
                    ErrorMessage.AllValidCourseTypes(typesValid);
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

        public int CheckStartMonth(string month)
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
                    Func<int, bool> validStartMonth = ValidStartMonthCourse;
                    Func<List<int>> allValidStartMonthsOfCourse = AllValidStartMonths;
                    List<int> allValidSartMonthOfCourse = allValidStartMonthsOfCourse.Invoke();
                    bool IsInValidMonthRange = validStartMonth.Invoke(InputMonth);
                    if (IsInValidMonthRange)
                    {
                        isValidRange = true;
                    }
                    else
                    {
                        isValidRange = false;
                        ErrorMessage.StartMonthMustBeInValidRange(allValidSartMonthOfCourse);
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
            return Convert.ToInt32(month);
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

        public bool ValidCourseTitle(string title)
        {
            if (title.ToLower() == "java" || title.ToLower() == "python" || title.ToLower() == "javascript" || title.ToLower() == "csharp" ||
                title.ToLower() == "sql"  || title.ToLower() == "css3"    || title.ToLower() == "html5"     || title.ToLower() == "angular"||
                title.ToLower() == "react" || title.ToLower() == "vue" || title.ToLower() == "django" || title.ToLower() == "mongodb" 
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> AcceptableTitles()
        {
            List<string> AcceptableTitles = new List<string>();
            AcceptableTitles.Add("java");
            AcceptableTitles.Add("python");
            AcceptableTitles.Add("csharp");
            AcceptableTitles.Add("css3");
            AcceptableTitles.Add("sql");
            AcceptableTitles.Add("javascript");
            AcceptableTitles.Add("react");
            AcceptableTitles.Add("angular");
            AcceptableTitles.Add("django");
            AcceptableTitles.Add("mongodb");
            AcceptableTitles.Add("vue");
            AcceptableTitles.Add("html5");

            return AcceptableTitles;
            
        }

        public bool ValidCourseTypes(string type)
        {
            if (type.ToLower() == "full time" || type.ToLower() == "part time")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> ValidTypes()
        {
            List<string> types = new List<string>();
            types.Add("full time");
            types.Add("part time");

            return types;
        }

        public List<int> AllValidStartMonths()
        {
            List<int> allValidStartMonths = new List<int>();
            allValidStartMonths.Add(2);
            allValidStartMonths.Add(10);
            return allValidStartMonths;
        }

        public bool ValidStartMonthCourse(int month)
        {
            if (month == 2 || month == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public DateTime ConditionsOfEndDate(string ValidType, DateTime start_date)
        {
            int startDay = start_date.Day;
            int startMonth = start_date.Month;
            int startYear = start_date.Year;
            DateTime EndDateTime = new DateTime();
            if (ValidType.ToLower() == "part time" )
            {
                if (startMonth == 10)
                {
                    EndDateTime =  new DateTime(startYear + 1, startMonth - 6, startDay);
                }
                else
                {
                    EndDateTime = new DateTime(startYear, startMonth + 6, startDay);
                }
            }
            else
            {
                if (startMonth == 10)
                {
                    EndDateTime = new DateTime(startYear + 1, startMonth - 8, startDay);
                }
                else
                {
                    EndDateTime = new DateTime(startYear, startMonth + 3, startDay);
                }

            }
            return EndDateTime;
        }

    }


    #endregion






}
