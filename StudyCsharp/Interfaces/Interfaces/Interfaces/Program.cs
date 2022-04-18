using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        /*
         * Think of interfaces as contracts where a class that implements an interface agrees to provide implementations for all objects 
         * defined by that interface. This means an interface will contain the contract terms, methods and properties.
         * But how we implement them is up to the class that implements the interface. So their names are generally prefixed with the eye to distinguish 
         * them from Other Csharp objects. So one of the most used functionalities in our Csharp classes is comparing to instances of a class this is done 
         * using the equals method. This will compare to see if the references to both of the classes is the same. However, we want to compare them and see if they are 
         * equal based on some other fields so we can achieve this by implementing an interface called IEquatable. So in our case we have a class called ticket and it defines
         * one property called duration in hours.
         * Equals is a method that is inside of the object class. And the object class always has this equal method because every class inherits from object.
         * 
         * 
         */
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(11);
            Console.WriteLine(t2.Equals(t1));
        }
    }
}
