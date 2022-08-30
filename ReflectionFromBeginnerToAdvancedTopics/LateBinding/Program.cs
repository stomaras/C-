using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LateBinding
{
    internal class Program
    {
        /*
         * CTRL+G --> We go to the line we want in Visual Studio Code.
         * 
         * Late Binding is complicated and has performance issues.
         * 
         * 99% of time we prefer early binding.
         * 
         * Difference between Late Binding and Early Binding
         * 1) Early Binding can flag errors at compile time. With late binding there is a risk of run time
         *    exceptions.
         * 2) Early Binding is much better for performance and should always be preffered over late binding.
         *    Use late binding only when working with an object's that are not available at compile time.
         *    
         *    Early Binding
         *    Customer c1 = new Customer();
         *    string fullName = c1.GetFullName("Paragim","Tech");
         *    Console.WriteLine("FullName = {0}",fullName);
         * 
         */
        static void Main(string[] args)
        {
            /*
             * Step 1)
             * Create an instance of the Customer class
             */
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customer = executingAssembly.GetType("LateBinding.Customer");

            object customerInstance = Activator.CreateInstance(customer);

            /*
             * Step 2)
             * Get the method which we want to execute. 
             */
            MethodInfo getFullNameMethod = customer.GetMethod("GetFullName");

            /*
             * Step 3) 
             * Get the parameters that methods expect.
             */
            string[] parameters = new string[2];
            parameters[0] = "Spyros";
            parameters[1] = "Tomaras";

            /*
             * 
             * In order to create this method we required the object instance itself
             * and also the parameters of the method.
             * 
             */

            /*
             * Step 4 Invoke the method.
             * 
             */
            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name = {0}", fullName);
            /*
             * If we try to create an instance of a class for which we don't have 
             * information at compile time . In case we don;t have indormation about the type 
             * which we want to instantiate, is not available at compile time we go for late binding.
             * I get this assembly which contains this class
             * GetFullName is an instance method so we require the instance f the class
             * if the method was static we don;t required the instance.
             */

            //Customer c1 = new Customer();
            //string fullName = c1.GetFullName("Spyros", "Tomaras");
            //Console.WriteLine("Full Name = {0}", fullName);
        }
    }

    /*
     * This class must be present on runtime in other case we get a null refernece exception.
     * 
     */
    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
