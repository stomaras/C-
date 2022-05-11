using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoBegin.Services
{
    class TicketService
    {
        public List<int> UserNumbers { get; private set; }
        public TicketService()
        {
           
            

        }

       public bool CheckUniqueness(List<int> UserNumbers, int number)
       {
            for (int i = 0; i <= UserNumbers.Count - 1; i++)
            {
                if (UserNumbers[i] == number)
                {
                    PrintService.IsNotUniqueUserNumber();
                    return false;
                }
            }
            return true;
        }

        public int EnterValidNumber()
        {
            string number = "";
            bool isNumber = false;

            int num = -1;
            // check if is number
            while (!isNumber)
            {
                Console.WriteLine("Enter Number between 1-80:\n");
                number = Console.ReadLine();
                isNumber = CheckIfIsNumber(number);
                if (isNumber == true)
                {
                    // check if range is between 1 and 80
                    num = Convert.ToInt32(number);
                    if (num >= 1 && num <= 80)
                    {
                        return num;
                    }
                    else
                    {
                        PrintService.InvalidRangeNumberMessage();
                        isNumber = false;
                    }
                }
                else
                {
                    PrintService.InvalidNumberMessage();
                }

            }
            return num;
        }

        private bool CheckIfIsNumber(string num)
        {
            int numeric;
            bool isNumber = int.TryParse(num, out numeric);
            return isNumber;
        }
    }
}
