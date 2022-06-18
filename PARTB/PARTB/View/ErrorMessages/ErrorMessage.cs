using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
