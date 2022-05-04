using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPart3
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student(104, "spyros", 12, 444.34f);
            Student s2 = new Student(243, "stathis", 2, 334.34f);
            Student s3 = new Student(45, "agathi", 25, 3.34f);
            Student s4 = new Student(789, "eleni", 120, 34.34f);

            // List contains complex type
            // when we use complex type we don't use Sort() function.

            List<Student> Students = new List<Student>() { s1, s2, s3, s4 };
            Students.Sort();// sorting performed based on sid with the help of IComparable

            CompareStudents obj = new CompareStudents();
            Students.Sort(obj);// sorting performed based on marks with the help of IComparer


            foreach (Student s in Students)
            {
                Console.WriteLine(s.Sid + " " + s.Name + " " + s.Class + " " + s.Marks);
            }
        }
    }
}
