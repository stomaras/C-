using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchoolPartBNew.Models;

namespace PrivateSchoolPartBNew.Services
{
    class ConsoleService
    {
        public static void ConsoleInputTrainer()
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

        public static void ConsoleInputStudent()
        {
            Student student = new Student();
            string firstName, lastName;
            DateTime dateTimeOfBirth;
            int TuitionFees;
            Console.WriteLine("Enter Student First Name:\n");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Student Last Name:\n");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Student Year Of Birth:\n");
            int year = student.CheckYearOfBirth(Console.ReadLine());
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
