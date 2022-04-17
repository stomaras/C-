using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabHumanity
{
    class Student
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string FacultyNumber { get; set; }

        private string Gender { get; set; }

        public Student(string firstName, string lastName, string facultyNumber, string Gender)
        {
            FirstName = firstName;
            LastName = lastName;
            checkFacultyNumber(facultyNumber);
            CheckGender(Gender);

        }

        public override string ToString()
        {
            String studentString = $" First Name : Student's {FirstName}\n Last Name: Student's {LastName}\n Faculty Number: Student's {FacultyNumber}\n Gender : Student's {Gender}";
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

        public void CheckGender(string gender)
        {
            if(gender == "Male" || gender == "Female" || gender == "Other")
            {
                Gender = gender;
            } else
            {
                do
                {
                    Console.WriteLine("Please enter student's gender: Must be Male (or) Female (or) Other\n");
                    string gen = Console.ReadLine();
                    gender = gen;
                } while (gender != "Male" && gender != "Female" && gender != "Other");
                Gender = gender;
            }
        }
    }
}
