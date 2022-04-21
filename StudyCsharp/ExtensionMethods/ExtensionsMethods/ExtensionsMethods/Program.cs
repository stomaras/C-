using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{
    /*
     * What is the Advantage of extensions methods ?
     * Suppose i have a class and this class contains 10 methods in it and i want to add some new methods, but 
     * i may not have the source code of this particular class. I may want to add some methods in String class but is not possible because i don't have the source code of the String class
     * So in the same way if the source code of a random class is not available i can't add new methods in this existing class. Sometimes you may not have permissions to make modification in the class
     * The way to solve this is with the help of inheritance and define some 5 methods
     * Class -> 10 methods
     * Child -> 5 new methods
     * So all the 15 methods can accessed by child class.
     * 
     * Inheritance is the mechanism using which we can extends functionalities of a class.
     * Problems with inheritance is that if Class is a sealed class inheritance will not work.
     * We can not apply inheritance in selaed classes
     * if the original type is not a class and it's a structure
     * 
     * We can call all 15 methods only with the instance of child class, not with the instance of Parent class, this is another issue
     * 
     * 
     * Extensions Methods:
     * - it's a mechanism of adding new methods into an existing class or structure also with out modifying the source code of the original type.
     * - with this process we don't require any permissions from original type and the original type does not require any re-compilation.(either sealed or non selaed class
     * - Class/Structure : 10 methods
     * - Static class: 5 methods, we can bind these 5 methods with the class we want
     * 
     * NOTE!!! String is a sealed class
     * Note!!! With extension methods we don't change the source code of our class.
     * Note!!! Extension Methods can be defined only in static classes.
     * Note!!! Extension Methods are define as static but once they are bound with any class or structure they turn into non-static.
     * Note!!! If an extension method if defined with the same name and signature of an existing method in the class, then extension method will not be called and the preference 
     *         always goes to the original method only. 
     * NOTE!!! The first parameter of an extension method should be the name of the type to which that method has to be bound with and this parameter is not taken into consideration 
     *         while calling the extension method.
     * NOTE!!! An extension method should have one and only one binding parameter and it should be in the first place of the parameter list.   
     * NOTE!!! If an extension method is defined with n parameters then while calling it there will be n-1 parameters only because the binding parameter is excluded.
     * NOTE!!! if you have consuming libraries go to the cool feature of extensions method
     * NOTE!!! In String class we have no permissions, no access to source code , is a sealed class
     * 
     */
    class Program
    {
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }

        public void Test2()
        {
            Console.WriteLine("Method 2");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            
            
        }
    }
}
