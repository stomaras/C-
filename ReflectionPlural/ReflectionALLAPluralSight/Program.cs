using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionALLAPluralSight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Spyros";
            var stringType = name.GetType();// typeof(string)
            Console.WriteLine(stringType);

            var currentAssembly = Assembly.GetExecutingAssembly();
            var typesFromCurrentAssembly = currentAssembly.GetTypes();
            foreach (var type in typesFromCurrentAssembly)
            {
                Console.WriteLine(type.Name);
            }

            var oneTypeFromCurrentAssembly = currentAssembly.GetType("ReflectionALLAPluralSight.Person");
            Console.WriteLine(oneTypeFromCurrentAssembly.Name);

            var externalAssembly = Assembly.Load("System.Text.Json");
            var typesFromExternalAssembly = externalAssembly.GetTypes();


            Console.ReadLine();
        }
    }
}

/*
 * Documentation
 * 
 * Assemblies contains modules, modules contain types and types contain members.
 * 
 * Assemblies
 * |
 * |
 * |
 * Modules
 * |
 * |
 * |
 * Types
 * |
 * |
 * |
 * Members.
 * 
 * Assembly is a collection of types and resources that are built to work together and form a logical unit of functionality.
 * Assemblies take the form of .EXE or .DLL
 * Assemblies are the building blocks for .NET Apps.
 * Assemblies provide the common language runtime with the information it needs to be aware of type implementations.
 * Assemblies contains metadata.
 * 
 * Module 
 * Is a portable executable file, such as type .dll, or application .exe, consisting of one or more classes and interfaces.
 * There may be multiple namespaces contained in a single module, and a namespace may span multiple modules.
 * One or more modules deployed as a unit compose an assembly.
 * An Assembly contains one or more modules.
 * You will see a one-on-one match between assembly and module in 99% of the cases.
 * 
 * Type
 * A collection of members: fileds that hold data, methods, that can be executed and so on.
 * For example a class is a type, a struct is a type, an enumeration is a type.
 * A type contains metadata describing itself
 * - Base Type 
 * - Interfaces
 * - Permitted Operations
 * - A type contain members.
 * 
 * Member
 * Represents the data and behaviour of a type.
 * Examples are fileds, constructors,events, methods and so on...
 * 
 * Reflection is the process by which a computer program can observe and modify its own structure and behaviour.
 * We can get the metadata of a type and once we get that we can use that metadata to modify our app.
 * 
 * Reflection provides objects that encapsulate assemblies, modules and types.
 * - System.Reflection namespace.
 * 
 * With Reflection we can create an instance of a type.
 * With Reflection we can bind the type to an existing object.
 * With Reflection we can get the type from an existing object.
 * 
 * Reflection Use Cases 
 * 
 * - Dependecy Injection Containers
 * - Calling private or protected methods , fileds , properties
 * - Serialization
 * - Type inspector applications
 * - Code analysis tools.
 * - Tools like ORM are full of reflection.
 * 
 * In .NET most assemblies contains most one module.
 * 
 * 
 */
