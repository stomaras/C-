using CodeWarsConsole.Helpers.Helpers.HelpersFundamentals;
using CodeWarsConsole.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsole.Views
{
    public class PrintView : IPrintView
    {
        public int EnterANumber()
        {
            Console.WriteLine("Enter a number:\n");
            string number = Console.ReadLine();
            HelperFundamentals helper = Factory.Factory.CreateHelperFundamentals();
            bool isNumber = helper.CheckIfIsAStringNumber(number);
            int numberr = helper.GetNumber(isNumber, number);
            return numberr;
        }

        public string EnterAString()
        {
            Console.WriteLine("Enter a string:\n");
            string number = Console.ReadLine();
            HelperFundamentals helper = Factory.Factory.CreateHelperFundamentals();
            string capitalNumber = helper.Validate(number);
            return capitalNumber;
        }

        public void EnterNumericValueMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please Enter A Numeric Value:\n");
            Console.ResetColor();
        }

        public void EnterStringValueNotNullAndBetween1And10CharsLong()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter a string not null and between 1 and 10 characters long");
            Console.ResetColor();
        }
    }
}
