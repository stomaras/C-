using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage3
{
    public delegate string GreetingsDelegate(string name);
    class Program
    {
        static void Main(string[] args)
        {
            // anonymous method
            GreetingsDelegate obj = delegate (string name)
            {
                return "Hello " + name + " a very good morning!";
            };

            String str = obj.Invoke("Tom");
            Console.WriteLine(str);
        }
    }
}

/*
 * Anonymous methods : 
 */
