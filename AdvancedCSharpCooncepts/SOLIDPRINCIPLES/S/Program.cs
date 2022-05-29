using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{

    /*
     * Single Responsibility Principle , we will call SRP rom now on 
     * Violates SRP. SRP Stands that a class should only have one responsibility or another 
     * or they should have one reason to change in 
     * SRP says there see only one reason to change per class
     * It's not hard to review what's going on in the entire class
     * If You have to scroll you have done something wrong
     * You must have to change a class for only one reason.
     * SRP = Single Responsibility Principle
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            // Ask for user information
            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);
            if (!isUserValid)
            {
                StandardMessages.EndApplicaton();
                return;
            }
            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplicaton();

        }
    }
}
