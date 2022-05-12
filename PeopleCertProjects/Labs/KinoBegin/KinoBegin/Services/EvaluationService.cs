using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoBegin.Domains;

namespace KinoBegin.Services
{
    class EvaluationService
    {

        private Ticket _Ticket;

        public Ticket Ticket
        {
            get { return _Ticket; }
            set { _Ticket = value; }
        }

        private Lottery _lottery;

        public Lottery Lottery
        {
            get { return _lottery; }
            set { _lottery = value; }
        }

        private int _CountOfWinNumbers;

        public int CountOfWinNumbers
        {
            get { return _CountOfWinNumbers; }
            set { _CountOfWinNumbers = value; }
        }

        private bool _kinoBonus;

        public bool KinoBonus
        {
            get { return _kinoBonus; }
            set { _kinoBonus = value; }
        }


        public EvaluationService(List<int> LotteryNumbers, List<int> TicketNumbers, bool KinoBonus)
        {
            CountOfWinNumbers = ComparisonLists(LotteryNumbers, TicketNumbers);
            KinoBonus = KinoBonusSearch(LotteryNumbers, TicketNumbers);
            
        }

        public EvaluationService(List<int> LotteryNumbers, List<int> TicketNumbers)
        {
            CountOfWinNumbers = ComparisonLists(LotteryNumbers, TicketNumbers);
        }

        public int ComparisonLists(List<int> LotteryNumbers, List<int> TicketNumbers)
        {
           
            int count = 0;
            for(int i=0; i<= LotteryNumbers.Count-1; i++)
            {
                
                for (int j = 0; j < TicketNumbers.Count-1; j++)
                {
                    
                    if(LotteryNumbers[i] == TicketNumbers[j])
                    {   
                        count++;
                    }
                    
                }
            }
            return count;
        }
        public bool KinoBonusSearch(List<int> LotteryNumbers, List<int> TicketNumbers)
        {
            bool countBonus = false;
            for (int i = 0; i <= LotteryNumbers.Count - 1; i++)
            {

                for (int j = 0; j < TicketNumbers.Count - 1; j++)
                {

                    if (LotteryNumbers[i] == TicketNumbers[j] && LotteryNumbers[i] == LotteryNumbers.Count - 1)
                    {
                        countBonus = true;
                    }

                }
            }
            return countBonus;
        }

        public void PrintWinNumbers(int num)
        {
               Console.WriteLine($"Player  of win numbers {num} / 6");
        }



    }
}
