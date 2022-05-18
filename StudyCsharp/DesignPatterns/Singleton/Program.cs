using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /*
     * What is Singleton Design Pattern
     * Singleton as Creational Pattern
     * Implementation Guidelines
     * How do we Implement a Singleton class
     * 
     * Singleton Pattern 
     * Singleton Pattern belongs to Creational Type Pattern.
     * 
     * This pattern is used when we need to ensure that only one object of a particular class need to be created. 
     * All further References to the objects are reffered to the same underlying instance created
     * Advantages of Singleton
     * >> Singleton controls concurrent access to the resource.
     * >> It ensures there is only one object available across the application in a controlled state.
     * 
     * >> Implementation Guidelines
     * >> Ensure that only one instance of the class exists
     * >> Provide global access to that instance by 
     * >>>> Declaring all constructors of the class to be private
     * >>>> Providing static method that returns a reference to the instance
     * >>>> The instance is stored as a private static variable.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("thgis is first message");
            fromEmployee.PrintDetails("something");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            Console.ReadLine();
        
        }
    }
}
