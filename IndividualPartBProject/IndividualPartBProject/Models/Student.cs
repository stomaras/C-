using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartBProject.Models
{
    class Student
    {
        public static int S_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }

        public Student(string FirstName, string LastName, DateTime DateOfBirth, int TuitionFees)
        {
            GenerateStudentID();
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.TuitionFees = TuitionFees;
        }

        public static void GenerateStudentID()
        {
            S_Id++;
        }

        public override string ToString()
        {
            return $"Student {{ FirstName:{FirstName}, LastName:{LastName}, DateOfBirth:{DateOfBirth}, TuitionFees{TuitionFees} }}";
        }

    }
}
