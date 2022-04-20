using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Predifined Generic - Delegates :
 * 1) func delegate
 * 2) action delegate
 * 3) predicate 
 * 
 * 1) The func delegate is used when a method is going to return a value - value returning method
 * 2) The action delegate is gonna be used when a method is going to return void
 * 3) The predicate delegate is used when the return value is boolean
 * 
 */
namespace Stage5
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Func Delegate if method is value-returning
            Func<int, float, double, double> del1 = new Func<int, float, double, double>(GenericDelegates.AddNums1);
            double result1 = del1.Invoke(100, 34.93f, 192.345);
            Console.WriteLine(result1);

            // Action Delegate is used when method is non-value-returning method
            Action<int, float, double> del2 = new Action<int, float, double>(GenericDelegates.AddNums2);
            del2.Invoke(100, 23.34f, 214.22);

            // Predicate Delegate is used when method is bool-value-returning
            Predicate<string> del3 = new Predicate<string>(GenericDelegates.CheckLength);
            bool status = del3.Invoke("tomyBroskis");
            Console.WriteLine(status);

            Console.ReadKey();
        }
    }
}
