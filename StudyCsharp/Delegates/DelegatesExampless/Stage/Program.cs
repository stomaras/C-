using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

         /*
          * A class is a userd-defined type, a struct is a user-defined type, 
          * an interface is a user-defined type, a delegate is a user-defined type
          * A delegate should be defined under a namespace, you can define inside of class also
         * Delegate: It's a type safe function pointer
         * 
         * A delegate holds the reference of a method and then calls the method 
         * for execution
         * 1st way : If the methods are non static we can this by the instance of the class
         * 2nd way : if the method is static we can call this method by the ClassName
         * 3rd way : with the help of delegate
         * 
         * Return type of Delegate should be exactly same with the return type of the method
         * Parameters of Delegate should be exactly same with the parameters of the method
         * 
         * To call a method by using a delegate we have 3 steps:
         * 
         * 1) Define a delegate
         * [<modifiers>]delegate void|type <Name>([<parameter list>])
         * 
         * public delegate void AddDelegate(int a, int b);
         * 
         * public void AddNums(int a, int b)
         * 
         * 
         * 
         */

/*
 * Note: A non static method of a class can't be accessed by a static block directly
 * 
 */




namespace Stage
{
    // Step 1: Defining a delegate
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string s);
    class Program
    {

        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        
        static void Main(string[] args)
        {
            // Instance of the Program class
            Program p = new Program();
            p.AddNums(100, 200);
            

            // Class name . method
            string name = Program.SayHello("Tom");
            Console.WriteLine(name);



            // Step 2: Instantiate a Delegate (instance of a Delegate)
            // you need to pass the method name as a parameter to that Delegate
            AddDelegate ad = new AddDelegate(p.AddNums);
            SayDelegate sd = new SayDelegate(SayHello);

            ad.Invoke(3, 3);// a method is going to execute
            sd.Invoke("Tom");

            // Step 3: Now call the delegate by passing required parameter values, so that
            // internally the method which is bound with the delegate gets executed.

        }
    }
}
