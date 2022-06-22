using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.chair = new Chair(1, 20.2);

            Caretaker caretaker = new Caretaker();
            caretaker.AddMemento(originator.CreateMemento());

            originator.chair = new Chair(1, 15.8);
            caretaker.AddMemento(originator.CreateMemento());

            originator.chair = new Chair(1, 12.8);
            Console.WriteLine("\nOriginator current state" + originator.GetDetails());

            Console.WriteLine("\nOriginator restoring inch LED TV");
            originator.chair = caretaker.GetMemento(0).Chair;

            Console.WriteLine("\nOriginator current state" + originator.GetDetails());
            Console.ReadKey();

        }
    }
}
