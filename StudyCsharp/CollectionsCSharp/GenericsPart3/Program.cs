using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPart3
{
    class Program
    {
        public static int CompareNames(Student S1, Student S2)
        {
            return S1.Name.CompareTo(S2.Name);
        }
        static void Main(string[] args)
        {

            Student s1 = new Student(104, "spyros", 12, 444.34f);
            Student s2 = new Student(243, "stathis", 2, 334.34f);
            Student s3 = new Student(45, "agathi", 25, 3.34f);
            Student s4 = new Student(789, "eleni", 120, 34.34f);
            Student s5 = new Student(567, "georgia", 100, 67.89f);
            Student s6 = new Student(435, "sotiris", 111, 70.78f);
            Student s7 = new Student(342, "tolias", 107, 89.90f);
            Student s8 = new Student(189, "antonia", 109, 84.78f);

            // List contains complex type
            // when we use complex type we don't use Sort() function.

            List<Student> Students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7 , s8};
            Students.Sort();// sorting performed based on sid with the help of IComparable

            Console.WriteLine("-----------------------------------------------------\n");
            Console.WriteLine("---------------- Comparison 2 ----------------------\n");
            Console.WriteLine("-----------------------------------------------------\n");

            CompareStudents obj = new CompareStudents();
            Students.Sort(obj);// sorting performed based on marks with the help of IComparer


            foreach (Student s in Students)
            {
                Console.WriteLine(s.Sid + " " + s.Name + " " + s.Class + " " + s.Marks);
            }

            Console.WriteLine("-----------------------------------------------------\n");
            Console.WriteLine("---------------- Comparison 3 ----------------------\n");
            Console.WriteLine("-----------------------------------------------------\n");

            CompareStudents obj2 = new CompareStudents();
            Students.Sort(1, 4, obj2);

            foreach (Student s in Students)
            {
                Console.WriteLine(s.Sid + " " + s.Name + " " + s.Class + " " + s.Marks);
            }

            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine("---------------- Comparison Delegate ---------------------------\n");
            Console.WriteLine("----------------------------------------------------------------\n");

            Comparison<Student> obj3 = new Comparison<Student>(CompareNames);
            Students.Sort(obj3);
            foreach(Student S in Students)
            {
                Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
            }
            Console.ReadLine();
        }
    }
}
