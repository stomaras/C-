using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoBegin.Services;

namespace KinoBegin.Domains
{
    class Ticket
    {
        private int _numOfIterations = 5;

        private List<int> _numbers;

        public List<int> Numbers
        {
            get { return _numbers; }
            set { _numbers = value; }
        }

        private int _tid;

        public int Tid
        {
            get { return _tid; }
            set { _tid = value; }
        }


        public Ticket()
        {
            TicketService ticketService = new TicketService();
            GenerateTicket(ticketService);
            Tid++;
        }

        public List<int> GenerateTicket(TicketService ticketService)
        {
            for (int i = 0; i <= _numOfIterations; i++)
            {
                if (i == 0)
                {
                    Numbers = new List<int>();
                    int num = ticketService.EnterValidNumber();
                    Numbers.Add(num);
                }
                else
                {
                    bool isUnique = false;
                    while (!isUnique)
                    {
                        int num = ticketService.EnterValidNumber();
                        isUnique = ticketService.CheckUniqueness(Numbers, num);
                        if (isUnique)
                        {
                            Numbers.Add(num);
                        }
                    }
                }
            }
            return Numbers;
        }

        public override string ToString()
        {
            string s = $" Ticket {Tid} {{ \n";
            for(int i=0; i<= Numbers.Count-1; i++)
            {
                s = s + $" Number: {i+1} -> " + Numbers[i] + "\n";
            }
            s = s + $" }} ";
            return s;
        }



    }
}
