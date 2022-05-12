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



        public EvaluationService(List<int> LotteryNumbers, List<int> TicketNumbers)
        {
            int commons = ComparisonLists();
        }

        public int ComparisonLists(List<int> LotteryNumbers, List<int> TicketNumbers)
        {
            LotteryNumbers = 
            for(int i=0; i<= Lott)
        }



    }
}
