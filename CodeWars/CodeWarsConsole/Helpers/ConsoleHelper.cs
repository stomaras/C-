using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsConsole.Helpers
{
    public class ConsoleHelper
    {
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
    }
}
