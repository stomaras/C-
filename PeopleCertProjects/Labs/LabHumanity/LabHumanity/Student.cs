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
            FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            String studentString = $" First Name : Student's {FirstName}\n Last Name: Student's {LastName}\n Faculty Number: Student's {FacultyNumber}";
            return studentString;

        }
    }
}
