using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    /*
     * When you create an instance at runtime without know the type of object 
     * you use late binding.
     * Late Bidning : At runtime you load an assembly dynamically and then you check the assembly
     * The class tha i am looking for is that existing in that assembly. If yes create an instance of 
     * that class and then if you want to invoke some methods on that you will then invoke a method.
     * Late Binding : Create an instance of a class at runtime.
     * Reflection enables you to use code that is not available at compile time.
     * 
     * Early Binding : You have to know information or knowledge about that class for which 
     *                 you are creating an instance at runtime
     * Consider an example where we have two alternate implementations of an interface.
     * 
     * Reflection is the ability of inspecting the Assemblies metadata at runtime 
     * Used by IDES to show the object properties somebodys selects them a classical example is 
     * visual studio
     * 
     * Anothe major use of reflection is late binding
     * To get a type of a specific class or a structure etc there are three ways.
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type T = Type.GetType("Reflection.Customer");


            Type T = typeof(Customer);
            PropertyInfo[] properties = T.GetProperties();
            Console.WriteLine("Full Name = {0}", T.FullName);
            Console.WriteLine("Just the Name = {0}", T.Name);
            Console.WriteLine("Just the Namespace = {0}", T.Namespace);
            Console.WriteLine();
            Console.WriteLine("Properties in Customers:\n");
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine($"with name {property.Name} " +
                    $"with type {property.PropertyType.Name}"); 
            }

            Console.WriteLine();
            Console.WriteLine("Methods in Customer class");
            MethodInfo[] methods = T.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"Method return type : {method.ReturnType.Name} method name : {method.Name}, method parameters : {method.GetParameters()}");
            }

            Console.WriteLine();
            Console.WriteLine("Constructors in Customer class");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintID()
        {
            Console.WriteLine("ID = {0}",this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name = {0}",this.Name);
        }
    }
}
