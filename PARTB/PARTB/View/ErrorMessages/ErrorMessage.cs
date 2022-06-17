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
            Console.WriteLine("A Name must be between 2 and 100 characters long!!!");
            Console.ResetColor();
        }
    }
}
