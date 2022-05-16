using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinoStage1.Services;

namespace KinoStage1.Domain
{
    class Player
    {

        private static int _pid;

        public static int Pid
        {
            get { return _pid; }
            set { _pid = value; }
        }

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private Ticket _ticket;

        public Ticket Ticket
        {
            get { return _ticket; }
            set { _ticket = value; }
        }


        public Player()
        {
            FullName = RandomService.RandName();
            Age = RandomService.Age();
            Ticket = new Ticket();
            GeneratePlayerID();
        }

        public Player(bool KinoBonus)
        {
            FullName = RandomService.RandName();
            Age = RandomService.Age();
            Ticket = new Ticket(KinoBonus);
            GeneratePlayerID();
        }

        public void GeneratePlayerID()
        {
            Pid++;
        }

        

        public override string ToString()
        {
            string s = $"\t\tPlayer  {Pid}\n\t\t\tTicket {Ticket.Tid}\n";
            for (int i = 0; i < Ticket.Numbers.Count-1; i++)
            {
                s = s + $"\t\t\t\t Number {i+1}, {Ticket.Numbers[i]}\n";
            }
            if (Ticket.KinoBonus)
            {
                s = s + $"\t\t\t\t Play with Kino Bonus\n";
            }
            else
            {
                s = s + $"\t\t\t\t Don't Play with Kino Bonus\n";
            }
            return s;

        }


    }
}
