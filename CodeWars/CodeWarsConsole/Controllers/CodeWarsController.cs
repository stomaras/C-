using CodeWarsConsole.Views;
using System;
using static CodeWarsConsole.Factory.Factory;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsConsole.Helpers.Helpers.HelpersFundamentals;

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

        public void ConvertBooleanToString()
        {
            PrintView pr = Factory.Factory.CreatePrintView();
            string booleanToString = pr.ConvertBooleanToString(false);
            pr.OutPutBoolean(booleanToString);
        }

        public void FriendOrFoe()
        {
            string[] names = new string[5] {"Spyros","Tom","Niki","Natalia","Nat"};
            HelperFundamentals helper = new HelperFundamentals();
            var realFriends = HelperFundamentals.FriendOrNot(names);
            Console.WriteLine("Real Friends:\n");
            foreach (var friend in realFriends)
            {
                Console.WriteLine("Friend:" + friend);
            }
        }
        /*
         * Return the number (count) of vowels in the given string.
            We will consider a, e, i, o, u as vowels for this Kata (but not y).
            The input string will only consist of lower case letters and/or spaces.
         * 
         * 
         */
        public void VowelCount()
        {

        }

        public void ErrorService()
        {
            Console.WriteLine("wrong try again!");
        }





    }
}

