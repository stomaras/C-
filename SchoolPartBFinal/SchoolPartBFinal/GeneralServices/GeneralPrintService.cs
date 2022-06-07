using SchoolPartBFinal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPartBFinal.GeneralServices
{
    public static class GeneralPrintService
    {

        public static void StudentFirstNameCannotContainsSpecialCharsOrNums()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Student Name Cannot Contains Special Characters Or Numbers Try Again!!!\n");
            Console.ResetColor();
        }

        public static void StudentFirstNameLengthMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Student Name Must be at least 2 characters long Try Again !!!\n");
            Console.ResetColor();
        }

        public static void EnterStudentFirstName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter Valid Student  Name\n");
            Console.ResetColor();
        }

        public static void IsNotNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This Is Not Number Enter A Valid Id:\n");
            Console.ResetColor();
        }

        public static void StudentIdNotExistsMessage(int id)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Student with id {id} does not exists!!!");
            Console.ResetColor();
        }

        public static void SuccessDeleteMessage(Student deleteStudent)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Student {{ with id : {deleteStudent.StudentId} , with first name {deleteStudent.FirstName} , with last name {deleteStudent.LastName} deleted successfully!!!}}");
            Console.ResetColor();
        }

        public static void PrintYearMustBeInteger()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Student year of birth must be a number :\n");
            Console.ResetColor ();
        }

        public static void PrintYearMustBeInRange(int HighestBoundYearOfBirth, int LowestBoundYearOfBirth)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Student year of birth must be between {LowestBoundYearOfBirth} and {HighestBoundYearOfBirth} try again :\n");
            Console.ResetColor();
        }

        public static void PrintMonthMustBeInteger()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Student month of birth must be a number :\n");
            Console.ResetColor();
        }

        public static void PrintMonthMustBeInRange()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Student month of birth must be a number between << 1 and 12 >> :\n");
            Console.ResetColor();
        }

        public static void PrintDayMustBeInteger()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Student day of birth must be a number :\n");
            Console.ResetColor();
        }

        public static void PrintDayMustBeInRange()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Student day of birth must be a number between << 1 and 30 >> :\n");
            Console.ResetColor();
        }

        public static void PrintTuitionFeesMustBeInRange(int low, int high)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Student Tuition Fees must be {low} or {high} :\n");
            Console.ResetColor();
        }

        public static void PrintTuitionMustBeANumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Student Tuition fees must be a number");
            Console.ResetColor();
        }

       



    }
}
