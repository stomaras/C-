using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchoolRepeatPartA.Interfaces;

namespace PrivateSchoolRepeatPartA.Models
{
    public class Student : IPeople
    {
        public int Student_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TuitionFees { get; set; }

        // Navigation Properties 

        // A Student teached only one course
        public Course Course { get; set; }
        // A Student have to submit multiple Assigments
        public List<Assigment> Assigments { get; set; } = new List<Assigment>();

        

        /// <summary>
        /// This method print an object of type Student
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{Student_Id,-15}{FirstName,-15}{LastName,-15}{BirthDate,-15}{TuitionFees,-25}");
        }
    }
}
