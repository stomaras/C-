using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoBegin.Services;
using KinoBegin.Domains;

namespace KinoBegin.Services
{
    class TicketService
    {

        private int _numOfIterations = 5;
        public List<int> UserNumbers { get; private set; }

        

        public TicketService()
        {
            UserNumbers = GenerateTicket();
        }

        public List<int> GenerateTicket()
        {
            TicketService ticketService = new TicketService();
            for (int i = 0; i <= _numOfIterations; i++)
            {
                if (i == 0)
                {
                    UserNumbers = new List<int>();
                    int num = ticketService.EnterValidNumber();
                    UserNumbers.Add(num);
                }
                else
                {
                    bool isUnique = false;
                    while (!isUnique)
                    {
                        int num = ticketService.EnterValidNumber();
                        isUnique = ticketService.CheckUniqueness(UserNumbers, num);
                        if (isUnique)
                        {
                            UserNumbers.Add(num);
                        }
                    }
                }
            }
            return UserNumbers;
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
                PrintService.EnterNumberBetween1And80();
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

        

        public string PrintTicketNumber(int NumOfTickets)
        {
            string s = PrintService.EnterNewTicketNumber() + $"{NumOfTickets}" + $" registered ";
            return s;
        }
    }
}
