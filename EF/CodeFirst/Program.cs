using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // when change entity state and we have not info with someone migrations - > we have conflict
            MyContext db = new MyContext();

            var students = db.Students;

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
