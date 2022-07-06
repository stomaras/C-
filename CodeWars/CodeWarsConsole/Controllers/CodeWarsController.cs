using CodeWarsConsole.Views;
using System;
using static CodeWarsConsole.Factory.Factory;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsole.Controllers
{
    public class CodeWarsController
    {
        /// <summary>
        /// Convert a string to a number
        /// </summary>
        public void ConvertStringToNummber()
        {
            PrintView pr = new PrintView();
            pr.EnterANumber();
        }


        /// <summary>
        /// Your coworker was supposed to write a simple helper function to capitalize a string
        /// Don't Worry about the numbers, special characters, or non-string types being passed to the function
        /// The strings length will be from 1 character up to 10 characters, but will never be empty
        /// </summary>
        public void CapitalizeWord()
        {
            PrintView pr = Factory.Factory.CreatePrintView();
            string CapitalizeFirstWord = pr.EnterAString();
            Console.WriteLine(CapitalizeFirstWord);

        }

        public void ErrorService()
        {
            Console.WriteLine("Wrong Number Try again!");
        }
    }
}
