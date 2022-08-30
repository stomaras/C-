using BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { Name = "Hector", Score = 99, Birth = new DateTime(1987,04,17) };
            Student s2 = new Student() { Name = "Sofia", Score = 69, Birth = new DateTime(1991,02,12) };
            Student s3 = new Student() { Name = "Maria", Score = 70, Birth = new DateTime(1987,04,17) };

            var students = new List<Student>() { s1,s2,s3};

            //BubbleSort.OrderBy(students);

            //students.OrderBy(x => x.Score); in LINQ with one extended method create a linq

            //students.OrderBy(); this is our own extension
            students.OrderBy();

            PrintService.PrintStudents(students);
        }
    }

    public class Student
    {
        

        
        public string Name { get; set; }
        public int Score { get; set; }

        public DateTime Birth { get; set; }
    }
}
