using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = Bank.CreateBank;
            Bank b2 = Bank.CreateBank;
            Bank b3 = Bank.CreateBank;
            Bank b4 = Bank.CreateBank;
            Bank b5 = Bank.CreateBank;

            b1.cart.Add("TURBOX");
            b1.cart.Add("Samsung");

            b2.cart.Add("potatoes");

            foreach (var item in Bank.CreateBank.cart)
            {
                Console.WriteLine(item);
            }

            b1.Name = "Mpampis";
            b2.Name = "Lakis";
            b3.Name = "Tom";

            Console.WriteLine(b1.Name);
            Console.WriteLine(b2.Name);
            Console.WriteLine(b3.Name);
            
        }
    }
}
