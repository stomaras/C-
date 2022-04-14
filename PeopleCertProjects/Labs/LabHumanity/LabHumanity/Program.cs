using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabHumanity
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Spyros", "Tomaras", "123456789");
            Console.WriteLine(student.ToString());
            Worker worker = new Worker("Spyros", "Tomaras", 220.23, 9, 10.50);
            Console.WriteLine(worker.ToString());
        }
    }
}
