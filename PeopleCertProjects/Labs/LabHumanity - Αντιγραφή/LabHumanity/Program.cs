using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabHumanity
{
    class Program
    {
        private static List<Worker> workers = new List<Worker>();
        static void Main(string[] args)
        {
            
            Worker worker = new Worker("Spyros","Tomaras", 11, 11, 10.523);
            Worker worker2 = new Worker("Chris", "Fragulis", 15, 11, 11.45);
           
            workers.Add(worker);
            workers.Add(worker2);
            int num = Worker.HowManyWorkers(workers);
            Console.WriteLine("How many workers??: {0}", num);
            
            Console.WriteLine(worker.ToString());
            Student student = new Student("Chris", "Fragulis", "213", "Mal");
            Console.WriteLine(student.ToString());
            
        }
    }
}
