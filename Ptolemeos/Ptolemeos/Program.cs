using Ptolemeos.Controllers;
using Ptolemeos.RepositoryServices.StudentRepository;
using Ptolemeos.Views.StudentView;
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
            Services service = new Services();
            while (true)
            {
                Console.WriteLine("1 - Reading All Students");
                Console.WriteLine("2 - Create A Student");
                Console.WriteLine("3 - Edit A Student");
                Console.WriteLine("4 - Delete A Student");
                Console.WriteLine("5 - Reading All Trainers");
                Console.WriteLine("6 - Create A Trainer");
                Console.WriteLine("7 - Edit A Trainer");
                Console.WriteLine("8 - Delete A Trainer");
                Console.WriteLine("Choose:");
                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();



                switch (input)
                {
                    case "1": service.ReadingService(); break;
                    case "2": service.CreatingService(); break;
                    case "3": service.EditingService(); break;
                    case "4": service.DeleteService(); break;
                    default: service.ErrorService(); break;
                }
            }
        }
    }

    
}
