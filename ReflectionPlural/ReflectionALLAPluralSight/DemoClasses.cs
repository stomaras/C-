using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionALLAPluralSight
{
    public interface ITalk
    {
        void Talk(string message);
    }

    public class EmployeeMarkerAttribute : Attribute
    {

    }

    public class Employee : Person
    {
        public string Company { get; set; }
    }

    public class Alien : ITalk
    {
        public void Talk(string message)
        {
            Console.WriteLine($"Alien talking ... : {message}");
        }
    }

    public class Person : ITalk 
    { 
        public string Name { get; set; }
        public int age;
        private string _aPrivateField = "initial private field value";

        public Person()
        {
            Console.WriteLine("A person is created...");
        }

        public Person(string name)
        {
            Console.WriteLine($"A person is created with name {name}");
            Name = name;
        }

        private Person(string name, int age)
        {
            Console.WriteLine($"A person with name {name} and age {age} " + $"is being created using a private constructor");
            Name = name;
            this.age = age;
        }

        public void Talk(string message)
        {
            Console.WriteLine($"Talking...:{message}");
        }

        protected void Yell(string message)
        {
            Console.WriteLine($"Yelling!{message}");
        }

        public override string ToString()
        {
            return $"{Name} {age} {_aPrivateField}";
        }
    }

}
