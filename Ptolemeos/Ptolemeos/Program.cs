using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptolemeos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - Reading All Students");
                Console.WriteLine("2 - Create A Student");
                Console.WriteLine("3 - Edit A Student");
                Console.WriteLine("4 - Delete A Student");
                Console.WriteLine("Choose:");
                Console.ForegroundColor = ConsoleColor.Green;
                string choice = Console.ReadLine();
                Console.ResetColor();

                Console.Clear();
                switch (choice)
                {
                    case "1": Console.WriteLine(); break;
                    case "2": Console.WriteLine(); break;
                    case "3": Console.WriteLine(); break;
                    case "4": Console.WriteLine(); break;
                    default: Console.WriteLine("default"); break;
                }
            }
            
        }
    }
}
