using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencynversion
{
    // High Level Module depend on the lower level module
    /*
     * Both High Level Module and Low Level Module should depends on Abstractions 
     * and those Abstractions should not depend on details. Interfaces is a way of doing DI well.
     * When you catch yourself doing new , all of these are tightly coupled dependedncies. on lower level module.
     * Dependency Inveersion is The Principle... Dependency Injection Is One Way To Make Principle Work.
     * We have Interfaces Instead of Actual Implementations
     * Not Direct Dependencies --> Only dependency must be Abstraction.
     * Dependecy Injection Is The Implementation Of This Principle -> Dependency Inversion
     * Dependency Inversion Is The Idea Of Not having new in the code
     * Dependency Inversion Talk About Disconnecting And Everything talk about Interfaces.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Tim";
            owner.LastName = "Corey";
            owner.EmailAddress = "tim@iamtimcorey.com";
            owner.PhoneNumber = "555-1212";
            

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();
        }
    }
}
