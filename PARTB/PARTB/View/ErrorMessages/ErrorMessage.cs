using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARTB.Models;
using PARTB.Models.CustomValidations;

namespace PARTB.View.ErrorMessages
{
    public static class ErrorMessage
    {
        public static void InvalidNameMessage1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A Name cannot contains numbers!!!");
            Console.ResetColor();
        }

        public static void InvalidNameMessage2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A Name must be between 2 and 50 characters long!!!");
            Console.ResetColor();
        }

        public static void PrintDayMustBeInRange()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Day must be in range <<1 to 30>>!!!");
            Console.ResetColor();
        }

        public static void PrintDayMustBeInteger()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Day must be a number!!!");
            Console.ResetColor();
        }

        public static void FirstNameCannotBeNull()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("First Name Cannot be Null!!!");
            Console.ResetColor();
        }

        public static void FirstNameCannotContainNumbersOrSpecialCharacters()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("First Name Cannot Contains Numbers Or Special Characters!!!");
            Console.ResetColor();
        }

        public static void FirstNameMustBeInRange()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("First Name Must Be Between 2 and 50 characters long!!!");
            Console.ResetColor();
        }

        public static void LastNameCannotContainNumbersOrSpecialCharacters()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Last Name Cannot Contains Numbers Or Special Characters!!!");
            Console.ResetColor();
        }

        public static void LastNameMustBeInRange()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Last Name Must Be Between 2 and 50 characters long!!!");
            Console.ResetColor();
        }

        public static void DayMustBeInteger()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Day Must Be Integer!!!");
            Console.ResetColor();
        }

        public static void DayMustBeInValidRange()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Day Must Be A Number between 1 and 30!!!");
            Console.ResetColor();
        }

        public static void MonthMustBeInValidRange()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Month Must Be A Number between 1 and 12!!!");
            Console.ResetColor();
        }

        public static void MonthMustBeInteger()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Month Must Be A Number!!!");
            Console.ResetColor();
        }

        public static void YearMustBeInValidRange()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            string message = "";
            Func<string, string> yearRange = Helper.YearOfBirthValidRangeMessage;
            string yearsOfBirthRange = yearRange.Invoke(message);
            Console.WriteLine(yearsOfBirthRange);
            Console.ResetColor();
        }

        public static void YearMustBeInteger()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Year Must Be Number");
            Console.ResetColor();
        }

        public static void TuitionFeesMustBeInRange(int lowRange, int highRange)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Tuition fees must be {lowRange} or {highRange}");
            Console.ResetColor();
        }

        public static void TuitionMustBeANumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Tuition fees must be a number");
            Console.ResetColor();
        }

        public static void TypeOfCourseErrorMessage1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Type of course must be java <or> python <or> javascript <or> csharp!");
            Console.ResetColor();
        }

        public static void TypeOfCourseErrorMessage2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Type of course can not contains numbers or special characters!");
            Console.ResetColor();
        }

        public static void CourseIdMustBeNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Course Id must be a number try again:\n");
            Console.ResetColor();
        }

        public static void InValidCourseIdRange(int upperBound, int lowerBound)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Course Id must be in range {lowerBound} - {upperBound} please try again!");
            Console.ResetColor();
        }

        public static void ValidTrainerSubject()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("$ Subject must be <<java>> or <<python>> or <<javascript>> or <<csharp>>!");
            Console.ResetColor();
        }

        public static void ValidCourseTitles(List<string> validTitles)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Valid course title must be:\n");
            foreach (var title in validTitles)
            {
                Console.WriteLine(title + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Try again:\n");
            Console.ResetColor();
        }

        public static void AllValidCourseTypes(List<string> validTypes)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Valid course type must be:\n");
            foreach (var type in validTypes)
            {
                Console.WriteLine(type + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Try again:\n");
            Console.ResetColor();
        }

        public static void StartMonthMustBeInValidRange(List<int> allValidStartMonths)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"All Valid Start Course Months must be : \n");
            foreach (var start_Month in allValidStartMonths)
            {
                Console.WriteLine(start_Month + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Try again:\n");
            Console.ResetColor();
        }

        public static void CourseErrorInsertMessage(Course course)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Course with Title {course.Title} and type {course.Type} cannot insert into database");
            Console.ResetColor();
        }

        public static void WrongAssigmentTitle(List<string> allAssigmentTitles)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Assigment Title !");
            Console.WriteLine("Assigment Title must be something among :\n");
            foreach (var assigment in allAssigmentTitles)
            {
                Console.WriteLine($"{assigment}\n");
            }
            Console.WriteLine("Please Try Again:\n");
            Console.ResetColor();
        }

        public static void WrongAssigmentDescription(List<string> allDescriptions)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Assigment Description !");
            Console.WriteLine("Assigment Description must be something among :\n");
            foreach (var assigment in allDescriptions)
            {
                Console.WriteLine($"{assigment}\n");
            }
            Console.WriteLine("Please Try Again:\n");
            Console.ResetColor();
        }

        public static void InValidIdToRegister(List<Course> Courses)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            const int first = -45;
            const int second = -50;
            const int third = -45;

            Console.WriteLine("Invalid Course Id Range:\n");
            Console.WriteLine("Available options :\n");
            Console.WriteLine(($"{"---------Course Ids---------",first}{"---------Course Titles---------",second}{"---------Course Types---------",third}"));
            foreach (var course in Courses)
            {
                Console.WriteLine($"{$"{course.CourseId}",first}{$"{course.Title}",second}{$"{course.Type}",third}");
            }
            Console.ResetColor();
        }





    }
}
