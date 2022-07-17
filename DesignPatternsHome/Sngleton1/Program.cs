using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sngleton1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
                );
            Console.ReadLine();
        }

        private static void PrintTeacherDetails()
        {
            School fromTeacher = School.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentDetails()
        {
            School fromStudent = School.GetInstance;
            fromStudent.PrintDetails("From Student");
        }
    }
}
