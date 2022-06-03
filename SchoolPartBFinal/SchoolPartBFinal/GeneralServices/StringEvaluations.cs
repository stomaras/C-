using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SchoolPartBFinal.GeneralServices
{
    public class StringEvaluations
    {

        Func<int, bool> validLength = (int i) => (i >= 2);

        public string CheckIfStringContainsNumberOrSpecialCharacters(string word)
        {
            
            Regex rgx = new Regex("[^A-Za-z]");
            bool hasSpecialCharsOrNumbers = rgx.IsMatch(word.ToString());
            int length = word.Length;
            bool validLengthOfFirstName = validLength(length);
            while (hasSpecialCharsOrNumbers || !validLengthOfFirstName)
            {

                GeneralPrintService.EnterStudentFirstName();
                word = Console.ReadLine();
                length = word.Length;
                hasSpecialCharsOrNumbers = rgx.IsMatch(word.ToString());
                if (hasSpecialCharsOrNumbers)
                {
                    GeneralPrintService.StudentFirstNameCannotContainsSpecialCharsOrNums();
                }
                validLengthOfFirstName = validLength(length);
                if (!validLengthOfFirstName)
                {
                    GeneralPrintService.StudentFirstNameLengthMessage();
                }
                
            }
            return word;
        }

        public string CheckIfStringIsNumber(string input)
        {
            bool isNumber = int.TryParse(input, out int number);
            string newInput = "";
            while (!isNumber)
            {
                GeneralPrintService.IsNotNumber();
                newInput = Console.ReadLine();
                isNumber = int.TryParse(input, out int num);
            }
            return newInput;
        }









    }
}
