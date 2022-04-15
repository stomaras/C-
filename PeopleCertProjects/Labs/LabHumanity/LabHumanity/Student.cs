using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabHumanity
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FacultyNumber { get; set; }

        public Student(string firstName, string lastName, string facultyNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            checkFacultyNumber(facultyNumber);

        }

        public override string ToString()
        {
            String studentString = $" First Name : Student's {FirstName}\n Last Name: Student's {LastName}\n Faculty Number: Student's {FacultyNumber}";
            return studentString;

        }

        public void checkFacultyNumber(string facultyNumber)
        {
            if(facultyNumber.Length >= 5 && facultyNumber.Length <= 10)
            {
                FacultyNumber = facultyNumber;
            } else
            {
                do
                {
                    Console.WriteLine("Faculty Number must be among 5 and 10 characters Long!\n");
                    Console.Write("Please Enter A Faculty Number:");
                    string faculty = Console.ReadLine();
                    facultyNumber = faculty;
                } while (facultyNumber.Length < 5 || facultyNumber.Length > 10);
                FacultyNumber = facultyNumber;
            }
        }
    }
}
