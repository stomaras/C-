using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generics1 obj = new Generics1();
            // by using this method i can compare only 
            // integer values
            bool result = obj.Compare<float>(12.34f, 32);
            Console.WriteLine(result);
            bool result2 = obj.Compare<int>(10, 10);
            Console.WriteLine(result2);

            Generics2<int> obj2 = new Generics2<int>();
            // if i say int all the four methods will say int
            obj2.Add(10, 10);
            obj2.Sub(10, 20);
            obj2.Mul(10, 20);
            obj2.Div(10, 20);
        }
    }
}
