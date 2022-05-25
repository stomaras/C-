using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchoolPartBNew.Models;

namespace PrivateSchoolPartBNew.Services
{
    static class ConsoleService
    {

        /// <summary>
        /// This method help us to enter Trainer details from the keyboard
        /// </summary>
        public static void ConsoleInputTrainer()
        {
            
            string firstName, lastName, subject;
            Trainer trainer = new Trainer();
            
            Console.WriteLine("Enter Trainer First Name:\n");
            
            firstName = trainer.CheckFirstName(Console.ReadLine());
            Console.WriteLine("Enter Trainer Last Name:\n");
            lastName = trainer.CheckLastName(Console.ReadLine());
            Console.WriteLine("Enter Trainer Subject:\n");
            subject = trainer.ValidSubject(Console.ReadLine());
            DatabaseService.InsertTrainer(firstName, lastName, subject);
        }

        /// <summary>
        /// This method help us to enter Student details from the keyboard
        /// </summary>
        public static void ConsoleInputStudent()
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
            DatabaseService.InsertStudent(firstName, lastName, dateTimeOfBirth, TuitionFees);
        }
        //public static void ConsoleInputTrainer()
        //{
        //    string firstName, lastName, subject;
        //    Console.WriteLine("Enter Trainer First Name:\n");
        //    firstName = Console.ReadLine();
        //    Console.WriteLine("Enter Trainer Last Name:\n");
        //    lastName = Console.ReadLine();
        //    Console.WriteLine("Enter Trainer Subject:\n");
        //    subject = Console.ReadLine();
        //    DatabaseService.InsertTrainer(firstName, lastName, subject);
        //}

        //public static void ConsoleInputStudent()
        //{
        //    Student student = new Student();
        //    string firstName, lastName;
        //    DateTime dateTimeOfBirth;
        //    int TuitionFees;
        //    Console.WriteLine("Enter Student First Name:\n");
        //    firstName = Console.ReadLine();
        //    Console.WriteLine("Enter Student Last Name:\n");
        //    lastName = Console.ReadLine();
        //    Console.WriteLine("Enter Student Year Of Birth:\n");
        //    int year = student.CheckYearOfBirth(Console.ReadLine());
        //    Console.WriteLine("Enter Student Month Of Birth:\n");
        //    int month = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Student Day Of Birth:\n");
        //    int day = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Tuition Fees:\n");
        //    TuitionFees = Convert.ToInt32(Console.ReadLine());
        //    dateTimeOfBirth = new DateTime(year, month, day);
        //    DatabaseService.InsertStudent(firstName, lastName, dateTimeOfBirth, TuitionFees);
        //}
    }
}
