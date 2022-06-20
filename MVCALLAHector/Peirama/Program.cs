using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peirama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, int> t1 = new Tuple<string, int>("Ektoras", 35);
            Console.WriteLine(t1.Item2);

            string name;
            int age;
            t1.Deconstruct(out name, out age);

            Tuple<int, bool, string> t2 = new Tuple<int, bool, string>(30,true,"Orestis");
            

            (double, int, string) t3 = (4.3, 35, "Makis");

            

            Console.WriteLine(t3.Item1);
            Console.WriteLine(t3.Item2);
            Console.WriteLine(t3.Item3);

            Method(t2, t3.ToTuple());

        }

        public static void Method(Tuple<int,bool,string> tuple, Tuple<double,int,string> moo)
        {
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
        }
    }

    
}
