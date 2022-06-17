using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARTB.View.ErrorMessages;

namespace PARTB.Models.CustomValidations
{
    public class Helper
    {
        #region General Validations
        /// <summary>
        /// Check if an input string contains characters
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool CheckIfIsNumber(string input)
        {
            if (input.All(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        #region Validations for Student
        /// <summary>
        /// Input is a name and check if name is valid . A name is valid if contains characters between 3 and 100 characters long
        /// and characters are not numbers
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ValidName(string input)
        {
            bool containsNumbers = input.All(char.IsDigit);
            int length = input.Length;

            while (containsNumbers || length <= 2 || length > 100)
            {
                if (containsNumbers)
                {
                    ErrorMessage.InvalidNameMessage1();
                    input = Console.ReadLine();
                }
                else
                {
                    if (length <= 2 || length > 100)
                    {
                        ErrorMessage.InvalidNameMessage2();
                        input = Console.ReadLine();
                    }
                }   
            }
            return input;
            
        }
        #endregion
    }
}
