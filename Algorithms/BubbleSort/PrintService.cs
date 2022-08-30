using BubbleSort2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public static class PrintService
    {

        public static void PrintStudents(this List<Student> students)
        {
            Console.WriteLine("Sorted:\n");
            foreach (Student stu in students)
            {
                Console.WriteLine($"{stu.Name,-15}{stu.Score,-15}{stu.birth.Date.Year,-15}");
            }
            Console.Read();
        }
    }
}
