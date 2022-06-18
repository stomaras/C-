using PARTB.Models;
using PARTB.Models.CustomValidations;
using PARTB.ObjectFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTB.View.StudentView
{
    public class PrintStudent : IPrintStudent
    {
        Helper helper = Factory.CreateHelperObject();
        public void EnterStudentDetailsToCreate()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Enter Student Details:\n");

            Console.WriteLine("Enter Student First Name:\n");
            string firstName = helper.CheckValidFirstName(Console.ReadLine());

            Console.WriteLine("Enter Student Last Name:\n");
            string lastName = helper.CheckValidLastName(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter Student Date Of Birth:\n");
            Console.WriteLine("Enter Student Day Of Birth");
            Console.ResetColor();

            string dayOfBirthString = helper.CheckDay(Console.ReadLine());
            int dayOfBirthInt = Convert.ToInt32(dayOfBirthString);

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Enter Student Month Of Birth:\n");
            Console.ResetColor();

            string monthOfBirthString = helper.CheckMonth(Console.ReadLine());
            int monthOfBirthInt = Convert.ToInt32(monthOfBirthString);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter Student Year Of Birth:\n");
            Console.ResetColor();

            
        }

        public void PrintStudents(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students:\n");
            foreach (var student in students)
            {
                Console.WriteLine($"\t\tStudent : with first name {student.FirstName}, with last name {student.LastName}, with date of birth {student.DateOfBirth}\n");
            }
            Console.ResetColor();
        }
    }
}
