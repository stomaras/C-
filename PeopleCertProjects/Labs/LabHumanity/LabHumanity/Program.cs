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
            
            Worker worker = new Worker("Spyros","Tomaras", 11, 13, 10.50);
            Console.WriteLine(worker.ToString());
            Student student = new Student("Chris", "Fragulis", "213");
            Console.WriteLine(student.ToString());
            
        }
    }
}
