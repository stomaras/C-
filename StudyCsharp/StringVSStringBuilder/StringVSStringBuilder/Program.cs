using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringVSStringBuilder
{
    /*
     * String vs StringBuilder
     * 
     * - Strings are immutable, we can never modify a string are non-modifiable
     * - String str = "Hello"; , what will happen some memory is going to be allocated 
     *                           for you on the heap memory and
     * - str = str + "World"; when i declare like this what will happen is 
     *                        the string is not going to be concatenated with a new value
     *                        because strings are immutable , 2 different copies is going to be
     *                        created in memory
     * - str = str + "XYZ";   it keeps on making the copies to you internally                    
     * 
     * When you required to use a static string value which is require few modifications -> string
     * If you want to do more number of modifications on a string then string is not advised
     * 
     * - StringBuilder is mutable : you can make changes to this, you can make modifications to data
     * - StringBuilder sb = new StringBuilder("Hello") : 16 characters of memory will be allocated for you in the process
     * 
     * if you want to make frequent changes to string value is highly recommended to go for StringBuilder class
     * and not for string class, because strings are immutable
     * 
     * StringBuilder represents in System.Text namespace. 
     * String represents in System namespace.
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // 3 seperate copies is going to be created
            string str = "Hello";
            string s1 = str + "World";
            string s2 = s1 + "XYZ";

            StringBuilder sb = new StringBuilder("Hello");
            sb.Append("World");
            sb.Append("America");// it will automatically resize to 32 double.


            // how many modifications you make how many copies are there
            

            // will calculate how many time will take to complete this action
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for(int i=1; i<=100000; i++)
            {
                s = s + i;
            }
            sw1.Stop();

            StringBuilder sb1 = new StringBuilder();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for(int i=1; i<=100000; i++)
            {
                sb1.Append(i);
            }
            sw2.Stop();

            Console.WriteLine("Time taken from String:" + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time taken from StringBuilder" + sw2.ElapsedMilliseconds);
        }
    }
}
