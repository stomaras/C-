using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{
    class TestExtensionMethods
    {
        static void Main()
        {
            Program p = new Program();
            p.Test1();
            p.Test2();
            p.Test3(3);

            int i = 5;
            long results = i.Factorial();
            Console.WriteLine("Factorial of {0} is : {1}", i, results);

            String str = "hElLo hOw Are YOU";
            // I want to convert the above mentioned String in propercase
            // ProperCase means in every words first character should be in uppercase.

            String s = "hOW Are YoU";
            
            Console.WriteLine(s.ToProper());
            Console.ReadLine();
        }
    }
}
