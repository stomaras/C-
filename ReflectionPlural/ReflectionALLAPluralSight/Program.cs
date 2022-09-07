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
        /*
         * Imagine we are reading some information from a configuration file that states that we want to use the Alien Class
         * imagine this is read from some sort of configuration
         */
        private static string _typeFromConfiguration = "ReflectionALLAPluralSight.Person";
        static void Main(string[] args)
        {
            var personType = typeof(Person);
            var personConstructors = personType.GetConstructors(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (var personConstructor in personConstructors)
            {
                Console.WriteLine(personConstructor);
            }

            // Default constructor is invoked.
            var person1 = personConstructors[0].Invoke(null);

            var person2 = personConstructors[1].Invoke(new Object[] {"Kevin"});

            var person3 = personConstructors[2].Invoke(new Object[] { "Kevin", 39 });


            var person4 = Activator.CreateInstance("ReflectionALLAPluralSight", "ReflectionALLAPluralSight.Person").Unwrap();

            var person5 = Activator.CreateInstance("ReflectionALLAPluralSight",
                "ReflectionALLAPluralSight.Person", 
                true, 
                BindingFlags.Instance | BindingFlags.Public,
                null,
                new object[] { "Kevin" },
                null,
                null);

            var personTypeFromString = Type.GetType("ReflectionALLAPluralSight.Person");
            var person6 = Activator.CreateInstance(personTypeFromString, new object[] { "Kevin" });


            var assembly = Assembly.GetExecutingAssembly();
            var person7 = assembly.CreateInstance("ReflectionALLAPluralSight.Person");

            // Create an instance of a configured type
            var actualTypeFromConfiguration = Type.GetType(_typeFromConfiguration);
            var iTalkInstance = Activator.CreateInstance(actualTypeFromConfiguration) as ITalk;
            iTalkInstance.Talk("Hello World");

            var PersonForManipulation = Activator.CreateInstance("ReflectionALLAPluralSight",
                "ReflectionALLAPluralSight.Person",
                true,
                BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                new object[] { "Kevin", 39 },
                null,
                null).Unwrap();

            var nameProperty = PersonForManipulation.GetType().GetProperty("Name");
            nameProperty.SetValue(PersonForManipulation, "Sven");

            var ageField = PersonForManipulation.GetType().GetField("age");
            ageField.SetValue(PersonForManipulation, 34);

            PersonForManipulation.GetType().InvokeMember("_aPrivateField", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetField,
                null, PersonForManipulation, new[] { "update for private field value" });
            Console.WriteLine(PersonForManipulation);

            // invoke method public 
            var talkMethod = PersonForManipulation.GetType().GetMethod("Talk");
            talkMethod.Invoke(PersonForManipulation, new[] { "Something to say." });


            //invoke method protected
            PersonForManipulation.GetType().InvokeMember("Yell", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.InvokeMethod,
                null, PersonForManipulation, new[] {"Something to yell"});





            Console.WriteLine(PersonForManipulation);
        }

        public void InspectingMetadata()
        {
            string name = "Kevin";

            var stringType = typeof(string);
            Console.WriteLine(stringType);

            var currentAssembly = Assembly.GetExecutingAssembly();
            var typesFromCurrentAssembly = currentAssembly.GetTypes();
            foreach (var type in typesFromCurrentAssembly)
            {
                Console.WriteLine(type.Name);
            }
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
 *                                                                    |---------> System.Reflection.MethodInfo.
 * System.Reflection.MemberInfo ---> System.Reflection.MethodBase --->|
 *                                                                    |---------> System.Reflection.ConstructorInfo.
 *     
 *     
 * Early Binding 
 * Looks for methods and properties and checks whether they exist and match at compile time.
 * 
 * Late Binding
 * It is only at runtime that the actual type is decided on.
 * The objects are dynamic, so the compiler cannot give a warning.
 * 
 * BindingFlags enumeration
 * Used to control binding and to control how reflection searches.
 * BindingFlags.Public,
 * BindingFlags.Instance,...
 * 
 * Control the binding itself
 * BindingFlags.GetProperty
 * BindingFlags.SetField
 * 
 * Can be combined bitwise
 * BindingFlags.Instance | BindingFlags.NonPublic.
 * 
 * ObjectHandle all the objects is wrapped in a wrapper
 * 
 * ObjectHandle
 * 
 * two classes implements the ITalk Interface.
 * 
 * At runtime we creating objects which does not know type at design time common use case of reflection.
 * 
 * Reflection Behind the Scenes
 * 
 * Getting the info object
 * - Type metadata parsing
 * Actual method invocation
 * - Argument validity checks.
 * - Error Handling
 * Security Checks
 * -Restricted methods
 * - Dynamic code access security permissions.
 * 
 * Dynamic activation and dynamic invocation at runtime is somthing you will run quite often when creating a library
 * An application might configure itslef via a config file that contains instructions on which classes and methods 
 * to use , with that, you get dynamic invocation and method invocation at runtime.
 * Relationships between different components are determined at runtime.
 * Decreases the amount of tight coupling.
 * Imagine a tool is running that's monitoring your network, 
 * and it notices somethig is wrong. That means it now needs to warn soemone.It could use a MailService to send email
 * or SoundHornService to sound a horn.
 * The service to use, method to use and parameter list for this method are configured in a config file.
 */
