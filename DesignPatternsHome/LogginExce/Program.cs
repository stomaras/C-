using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogginExce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Input("Give your first number");
            var b = Input("Give your second number");
            var result = Sum(a, b);
            Print(result);
            LogService log = LogService.CreateLog;
            log.ReadFromLog();
        }

        public static int Input(string message)
        {
            Console.WriteLine(message);
            var a = Convert.ToInt32(Console.ReadLine());

            LogService log = LogService.CreateLog;
            log.WriteToLog($"User gave {a}");

            return a;
        }

        public static int Sum(int a, int b)
        {

            var sum = a + b;
            LogService log = LogService.CreateLog;
            log.WriteToLog($"The Sum of {a}, {b} is {sum}");
            return sum;
        }

        public static void Print(int number)
        {
            LogService log = LogService.CreateLog;
            log.WriteToLog($"User prints the result: {number}");
            Console.WriteLine("Final Result : " + number);
        }


    }
}
