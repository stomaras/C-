using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolPartBNew.Services
{
    class MenuService
    {

        public static bool Menu()
        {
            int choice;
            PrintService.EnterMenuOptions();
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 12)
            {
                return false;
            }
            else if (choice == 1)
            {
                ConsoleService.ConsoleInputStudent();
            }
            else if (choice == 2)
            {
                ConsoleService.ConsoleInputTrainer();
            }
            else if (choice == 3)
            {
                
            } else if(choice == 6)
            {
                PrintService.PrintTrainers();
            }
            return true;
        }

        private static void ConsoleInputTrainer()
        {
            string firstName, lastName, subject;
            Console.WriteLine("Enter Trainer First Name:\n");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Trainer Last Name:\n");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Trainer Subject:\n");
            subject = Console.ReadLine();
            DatabaseInputService.InsertTrainer(firstName, lastName, subject);
        }

        private static void ConsoleInputStudent()
        {
            string firstName, lastName;
            DateTime dateTimeOfBirth;
            int TuitionFees;
            Console.WriteLine("Enter Student First Name:\n");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Student Last Name:\n");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Student Year Of Birth:\n");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Month Of Birth:\n");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Day Of Birth:\n");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Tuition Fees:\n");
            TuitionFees = Convert.ToInt32(Console.ReadLine());
            dateTimeOfBirth = new DateTime(year, month, day);
            DatabaseInputService.InsertStudent(firstName, lastName, dateTimeOfBirth, TuitionFees);
        }

    }


}
