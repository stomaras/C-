using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Program
    {
        /*
         * RatingEngine Insurance which is used to rate individual policies 
         * that might be submitted to my small insurance company.
         * 
         * Typical approaches to OCP 
         * 
         * 1) Parameters passing different parameters to methods , Parameter Based Extension
         * 2) Inheritance : Many Design Patterns (Mark Method as virtual)
         * 3) Composition and Injection : Dependency Injection
         * 
         * Why use a new class?
         * 
         * Nothing in current system depends on it
         * Can add behaviour without touching existing code
         * Can follow Single Responsibility Principle
         * Can be unit-tested
         */
        static void Main(string[] args)
        {
        }
    }
}
