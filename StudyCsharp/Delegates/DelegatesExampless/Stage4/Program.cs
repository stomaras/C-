using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage4
{
    public delegate string GreetingsDelegate(string fname);
    class Program
    {
        public static string Greetings(string name)
        {
            return " Hello " + name + " a very good morning ";
        }
        static void Main(string[] args)
        {
            GreetingsDelegate gd = (name) =>
            {
                return "Hello" + name + " a very good morning!";
            };
            String message = gd.Invoke("Tom");
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
