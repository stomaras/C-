using CodeWarsConsole.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsole.Helpers.Helpers.HelpersFundamentals
{
    public class HelperFundamentals
    {

        public bool CheckIfIsAStringNumber(string number)
        {
            int n;
            bool isNumeric = int.TryParse(number, out n);
            if (isNumeric)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Validate(string number)
        {
            PrintView pr = Factory.Factory.CreatePrintView();
            Func<string, bool> isValid = ValidateString;
            while (!isValid.Invoke(number))
            {
                pr.EnterStringValueNotNullAndBetween1And10CharsLong();
                number = Console.ReadLine();
            }
            string returnNumber = "";

            List<char> chars = new List<char>();
            chars.AddRange(number);
            for (int i = 0; i <= chars.Count - 1; i++ )
            {
                 chars[0] = char.ToUpper(chars[0]);
                 returnNumber += chars[i];
            }
            
            return returnNumber;
        }

        public int GetNumber(bool isNumber, string number)
        {
            PrintView pr = new PrintView();
            if (isNumber)
            {
                return Convert.ToInt32(number);
            }
            else
            {
                while (!isNumber)
                {
                    pr.EnterNumericValueMessage();
                    number = Console.ReadLine();
                    int n;
                    isNumber = int.TryParse(number, out n);
                }

            }
            return Convert.ToInt32(number);
        }


        /*
         * Helper Delegates
         */

        public bool ValidateString(string astring)
        {
            
            if (astring != null)
            {
                int length = astring.Length;
                if (length >= 1 && length <= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
    }
}
