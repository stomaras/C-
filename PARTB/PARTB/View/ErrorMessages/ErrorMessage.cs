﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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





    }
}
