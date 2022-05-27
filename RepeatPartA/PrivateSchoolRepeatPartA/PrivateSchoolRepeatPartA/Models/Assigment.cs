using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchoolRepeatPartA.Models
{
    public class Assigment
    {
        public int Assigment_Id { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        // Navigation Properties
        // A Assigment has many students to submit
        public List<Student> Students { get; set; } = new List<Student>();

        // A Assigment has one course
        public Course Course { get; set; }

        /// <summary>
        /// This method print an object of type Assigment
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{Assigment_Id,-15}{Description,-15}{"",-15}{SubmissionDateTime,-15}");
        }
    }
}
